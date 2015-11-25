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
            musicController.playSong();

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
    }
}
