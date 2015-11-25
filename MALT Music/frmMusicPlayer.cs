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
    public partial class frmMusicPlayer : Form
    {
        // Contains functions for the music controller
        MusicController musicController;
        int trackLength;

        /// <summary>
        /// Init for form
        /// </summary>
        public frmMusicPlayer()
        {
            InitializeComponent();

            // Setup music controller
            musicController = new MusicController();
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

            trbTrackSelect.Maximum = trackLength;
            prbTrackBar.Maximum = trackLength;
            trbTrackSelect.Value = 0;
            prbTrackBar.Value = 0;

            tmrTracker.Enabled = true;

            musicController.playSong();

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

            trbTrackSelect.Value = 0;
            prbTrackBar.Value = 0;
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
            // If not at maximum
            if (trbTrackSelect.Value != trbTrackSelect.Maximum)
            {
                trbTrackSelect.Value++;
                prbTrackBar.Value = trbTrackSelect.Value;
                TimeSpan timeFactor = TimeSpan.FromSeconds(trackLength - trbTrackSelect.Value);
                lblTimeOne.Text = timeFactor.ToString("mm':'ss");
            }
            else // If at max, disable
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


        private void trbTrackSelect_Scroll(object sender, EventArgs e)
        {
            TimeSpan newTrackTime = TimeSpan.FromSeconds(trackLength * trbTrackSelect.Value / 100.0);
            prbTrackBar.Value = trbTrackSelect.Value;
            musicController.updatePlayTime(newTrackTime);
        }
    }
}
