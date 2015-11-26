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
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace MALT_Music
{
    // Contains functions for the music controller
    public partial class frmMusicPlayer : Form
    {
        // Class variables
        MusicController musicController;
        int trackLength;

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
            musicController.setSong(lblFileName.Text);

            trackLength = musicController.getTrackLength();
            TimeSpan totalLength = TimeSpan.FromSeconds(trackLength);
            lblTimeTwo.Text = totalLength.ToString("mm':'ss");
            maxValue = totalLength.Minutes;

            tmrTracker.Enabled = true;

            musicController.playSong();

            btnStop.Enabled = true;
            btnPause.Enabled = true;
            btnPlay.Enabled = false;
            btnTest.Enabled = false;
            btnOpen.Enabled = false;
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

            btnPlay.Enabled = false;
            btnOpen.Enabled = true;
            btnTest.Enabled = true;
            btnPause.Enabled = false;

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
            btnPause.Enabled = false;
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

            // Display the value tooltip.
            int tip_x = pcbSliderBar.Left + (int)ValueToX(sliderValue);
            int tip_y = pcbSliderBar.Top;
            ttpSliderIndicator.Show(sliderValue.ToString("0.00"), this, tip_x, tip_y, 3000);

            // Take action here if desired.
            lblTimeOne.Text = sliderValue.ToString("0.00");
        }

        // Draw the needle.
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

        private void pcbSliderBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
            SetValue(XtoValue(e.X));
            TimeSpan newTime = TimeSpan.FromMinutes(sliderValue);
            musicController.updatePlayTime(newTime);
        }

        private void pcbSliderBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseIsDown) return;
            SetValue(XtoValue(e.X));
        }

        private void picSliderBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
            ttpSliderIndicator.Hide(this);
        }
        #endregion
    }
}
