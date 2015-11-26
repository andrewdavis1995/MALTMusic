using System;
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

        /// <summary>
        /// Variables for slider bar.
        /// Information on this found <see cref="http://csharphelper.com/blog/2011/07/use-a-picturebox-to-make-a-slider-with-a-needle-in-c/"/> HERE
        /// </summary>
        private float sliderValue;
        private float maxValue;
        private float minValue;
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

            // Initialise slider
            sliderValue = 0f;
            maxValue = 0f;
            minValue = 0f;
            mouseIsDown = false;
            ttpSliderIndicator.Hide(this);
        }

        /// <summary>
        /// Plays the mp3
        /// </summary>.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Text == "Play")
            {
                // Change to pause
                btnPlay.Text = "Pause";

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
                    maxValue = totalLength.Minutes;
                    sliderValue = 0f;
                    isPlaying = true;
                }

                // Begins the timer
                tmrTracker.Enabled = true;
                
                // Initiates playing of song
                musicController.playSong();

                // Updates button states
                btnStop.Enabled = true;
                btnTest.Enabled = false;
                btnOpen.Enabled = false;
            }
            else
            {
                // Sets up for paused playback
                tmrTracker.Enabled = false;
                btnPlay.Text = "Play";

                // Pauses playback
                musicController.pauseSong();
            }
        }

        /// <summary>
        /// Opens an mp3 file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            ofdMusicOpener.ShowDialog();
        }

        /// <summary>
        /// Stops playing the track
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            musicController.stopSong();
            isPlaying = false;

            btnPlay.Enabled = false;
            btnOpen.Enabled = true;
            btnTest.Enabled = true;

            tmrTracker.Enabled = false;
        }

        /// <summary>
        /// Sets the song to be played
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ofdMusicOpener_FileOk(object sender, CancelEventArgs e)
        {
            lblFileName.Text = ofdMusicOpener.FileName;
            btnPlay.Enabled = true;
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
            btnPlay.Enabled = true;
        }

        /// <summary>
        /// Pauses the track
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPause_Click(object sender, EventArgs e)
        {
            musicController.pauseSong();
            tmrTracker.Enabled = false;
            btnPlay.Enabled = true;
        }

        /// <summary>
        /// Increments the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrTracker_Tick(object sender, EventArgs e)
        {
            if (sliderValue != maxValue)
            {
                SetValue(sliderValue + 0.01f);
            }
            else
            {
                this.Enabled = false;
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

        #region SliderControl ## Functions for slider control
        /// <summary>
        /// Convert an X coordinate to a value
        /// </summary>
        /// <param name="x">int value to convert to float</param>
        /// <returns>Returned coordinate</returns>
        private float XtoValue(int x)
        {
            return minValue + (maxValue - minValue) * x / (float)(pcbSliderBar.ClientSize.Width - 1);
        }

        /// <summary>
        /// Convert value to an X coordinate
        /// </summary>
        /// <param name="value">coordinate to convert to float</param>
        /// <returns>Returned float</returns>
        private float ValueToX(float value)
        {
            return (pcbSliderBar.ClientSize.Width - 1) *
                (value - minValue) / (float)(maxValue - minValue);
        }

        /// <summary>
        /// Updates the first time box text
        /// </summary>
        /// <param name="value">Float of time value</param>
        private void updateTimeIndicator(float value)
        {
            TimeSpan currentTime = TimeSpan.FromMinutes(value);
            lblTimeOne.Text = currentTime.TotalMinutes.ToString();
        }

        /// <summary>
        /// Updates the position of the slider based on the passed value
        /// </summary>
        /// <param name="value">The new value of the slider</param>
        private void SetValue(float value)
        {
            // Make sure the new value is within bounds.
            if (value < minValue) value = minValue;
            if (value > maxValue) value = maxValue;

            // See if the value has changed.
            if (sliderValue == value) return;

            // Save the new value.
            sliderValue = value;

            // Redraw to show the new value.
            pcbSliderBar.Refresh();

            // Updates the time indicator
            updateTimeIndicator(value);

            // If tracking position
            if (mouseIsDown)
            {
                // Display the value tooltip.
                int tip_x = pcbSliderBar.Left + (int)ValueToX(sliderValue);
                int tip_y = pcbSliderBar.Top;
                ttpSliderIndicator.Show(sliderValue.ToString("00.00"), this, tip_x, tip_y, 3000);
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
            // Update mouse down tracker
            mouseIsDown = true;

            // Updates value of slider
            SetValue(XtoValue(e.X));

            // Send new position (time) to player
            TimeSpan newTime = TimeSpan.FromMinutes(sliderValue);
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
            // If mouse button is pushed, update position
            if (!mouseIsDown) return;
            SetValue(XtoValue(e.X));

            // Send new position (time) to player
            TimeSpan newTime = TimeSpan.FromMinutes(sliderValue);
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
            mouseIsDown = false;
            ttpSliderIndicator.Hide(this);
        }
        #endregion
    }
}
