﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MALT_Music
{
    // Contains functions for the music controller
    public partial class frmMusicPlayer : Form
    {
        // Class variables
        MusicController musicController;
        int trackLength;
        bool isPlaying;
        bool playPause;

        /// <summary>
        /// Variables for slider bar.
        /// </summary>
        private int sliderValue;
        private bool mouseIsDown;
        
        /// <summary>
        /// Init for form
        /// </summary>
        public frmMusicPlayer()
        {
            InitializeComponent();

            // Setup music controller
            musicController = new MusicController();

            isPlaying = false;
            playPause = false; // Sets to pause mode

            // Initialise slider
            sliderValue = 0;
            trackLength = 0;
            mouseIsDown = false;
            ttpSliderIndicator.Hide(this);
        }

        /// <summary>
        /// Plays the currently loaded song in the NAudio drivers
        /// </summary>
        public void playCurrentSong()
        {
            if (playPause)
            {
                // Changes button image to pause
                pcbPlay.Image = Properties.Resources.pausetrack;

                // Change to pause
                playPause = false;

                // If not playing active track
                if (!isPlaying)
                {
                    // Sets song to be played
                    musicController.setSong(lblFileName.Text);

                    // Sets the length of the track
                    trackLength = musicController.getTrackLength();
                    TimeSpan totalLength = TimeSpan.FromSeconds(trackLength);
                    lblTimeTwo.Text = totalLength.ToString("mm':'ss");

                    // Sets upper threshold for track
                    sliderValue = 0;
                    isPlaying = true;
                }

                // Begins the timer
                tmrTracker.Enabled = true;
                
                // Initiates playing of song
                musicController.playSong();

                // Updates button states
                btnStop.Enabled = true;
                btnTest.Enabled = false;
            }
            else
            {
                // Changes button image to play
                pcbPlay.Image = Properties.Resources.playtrack;

                // Sets up for paused playback
                tmrTracker.Enabled = false;
                playPause = true;

                // Pauses playback
                musicController.pauseSong();
            }
        }

        /// <summary>
        /// Updates the file path to the passed song
        /// </summary>
        /// <param name="pathName">The location of the path</param>
        public void setSongPath(string pathName)
        {
            lblFileName.Text = pathName;
        }

        /// <summary>
        /// Triggers the play routine
        /// </summary>.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pcbPlay_Click(object sender, EventArgs e)
        {
            playCurrentSong();
            btnStop.Enabled = true;
            btnTest.Enabled = false;
        }

        /// <summary>
        /// Calls function to stop the playback
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            stopSong();
        }

        /// <summary>
        /// Stops playing the track
        /// </summary>
        public void stopSong()
        {
            // Disables track timer
            tmrTracker.Enabled = false;
            btnStop.Enabled = false;

            // Resets position of tracker
            SetValue(0);

            // Stops the track
            musicController.stopSong();
            isPlaying = false;

            // Allows using test track
            btnTest.Enabled = true;

            // Updates status of controls
            playPause = false;
            lblTimeOne.Text = "";
            lblTimeTwo.Text = "";

            // If a file is loaded
            if (lblFileName.Text != "")
            {
                pcbPlay.Enabled = true;
            }
        }

        /// <summary>
        /// Loads a test file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openTest(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(@"..\..\Resources\Test.mp3");
            lblFileName.Text = path;
            pcbPlay.Enabled = true;
        }

        /// <summary>
        /// Increments the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrTracker_Tick(object sender, EventArgs e)
        {
            if (sliderValue != trackLength)
            {
                SetValue(sliderValue + 1);    
            }
        }

        /// <summary>
        /// Sets up form settings for initial load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMusicPlayer_Load(object sender, EventArgs e)
        {
            lblTimeOne.Text = "";
            lblTimeTwo.Text = "";
        }

        // Based on code from http://csharphelper.com/blog/2011/07/use-a-picturebox-to-make-a-slider-with-a-needle-in-c/"/>
        #region SliderControl ## Functions for slider control
        /// <summary>
        /// Convert an X coordinate to a value
        /// </summary>
        /// <param name="x">int value to convert to float</param>
        /// <returns>Returned coordinate</returns>
        private int XtoValue(int x)
        {
            return trackLength * x / (pcbSliderBar.ClientSize.Width - 1);
        }

        /// <summary>
        /// Convert value to an X coordinate
        /// </summary>
        /// <param name="value">coordinate to convert to float</param>
        /// <returns>Returned float</returns>
        private float ValueToX(int value)
        {
            if (trackLength == 0)
            { return 0; }
            else
            {
                return (pcbSliderBar.ClientSize.Width - 1) * value / (float)trackLength;
            }
        }

        /// <summary>
        /// Updates the first time box text
        /// </summary>
        /// <param name="value">Float of time value</param>
        private TimeSpan updateTimeIndicator()
        {
            int num = trackLength - sliderValue;
            TimeSpan currentTime = TimeSpan.FromSeconds(num);
            lblTimeOne.Text = "-" + currentTime.ToString("mm':'ss");

            return currentTime;
        }

        /// <summary>
        /// Updates the position of the slider based on the passed value
        /// </summary>
        /// <param name="value">The new value of the slider</param>
        private void SetValue(int value)
        {
            // Return if no track loaded
            if (!isPlaying)
            { return; }

            // Make sure the new value is within bounds.
            if (value < 0) value = 0;
            if (value > trackLength) value = trackLength;
            if (value >= trackLength)
            {
                // Checks repeat status
                if (rbnNone.Checked)
                {
                    sliderValue = 0;
                    stopSong();
                }
                else if (rbnOnce.Checked) // Repeat Once
                {
                    value = 0;
                    musicController.updatePlayTime(TimeSpan.FromSeconds(0));
                    rbnNone.Checked = true;
                }
                else if (rbnCurrent.Checked) // Repeat eternally
                {
                    value = 0;
                    musicController.updatePlayTime(TimeSpan.FromSeconds(0));
                }
                else if (rbnPlaylist.Checked) // Repeat playlist
                {
                    stopSong();
                }
            }

            // See if the value has changed.
            if (sliderValue == value) return;

            // Save the new value.
            sliderValue = value;

            // Redraw to show the new value.
            pcbSliderBar.Refresh();

            // Updates the time indicator
            TimeSpan currentTime = updateTimeIndicator();

            // If tracking position
            if (mouseIsDown)
            {
                // Display the value tooltip.
                int tip_x = pcbSliderBar.Left + (int)ValueToX(sliderValue);
                int tip_y = pcbSliderBar.Top;
                ttpSliderIndicator.Show(currentTime.ToString("mm':'ss"), this, tip_x, tip_y, 3000);
            }
        }

        /// <summary>
        /// Draws the 'needle' of the slider onto the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picSliderBar_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the needle's X coordinate.
            float x = ValueToX(sliderValue);

            if (x > 0)
            {
                // Draw it.
                e.Graphics.DrawLine(Pens.White,
                    x, 0,
                    x, pcbSliderBar.ClientSize.Height);
            }
        }

        /// <summary>
        /// When the mouse button is pressed,
        /// update song play position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pcbSliderBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Return if no track loaded
            if (!isPlaying)
            { return; }

            // Update mouse down tracker
            mouseIsDown = true;

            // Updates value of slider
            SetValue(XtoValue(e.X));

            // Send new position (time) to player
            TimeSpan newTime = TimeSpan.FromSeconds(sliderValue);
            //lblPosition.Text = newTime.ToString();

            musicController.updatePlayTime(newTime);
        }

        /// <summary>
        /// When the mouse is moved over the component,
        /// updates the value of the bar if the button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pcbSliderBar_MouseMove(object sender, MouseEventArgs e)
        {
            // Return if no track loaded
            if (!isPlaying)
            { return; }

            // If mouse button is pushed, update position
            if (!mouseIsDown) return;
            SetValue(XtoValue(e.X));

            // Send new position (time) to player
            TimeSpan newTime = TimeSpan.FromSeconds(sliderValue);
            musicController.updatePlayTime(newTime);
        }

        /// <summary>
        /// If mouse button is no longer pushed,
        /// hide the tip, and set mouse to not being pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picSliderBar_MouseUp(object sender, MouseEventArgs e)
        {
            // Return if no track loaded
            if (!isPlaying)
            { return; }

            mouseIsDown = false;
            ttpSliderIndicator.Hide(this);
        }
        #endregion

        /// <summary>
        /// Tells the controller what to do with the song after completing play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void rbnAndrewIsA_CheckedChanged(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Is a what?", "Tell me", "Default", -1, -1);
            rbnAndrewIsA.Text = "Andrew is a..." + input;

            rbnNone.Checked = true;
        }
    }
}
