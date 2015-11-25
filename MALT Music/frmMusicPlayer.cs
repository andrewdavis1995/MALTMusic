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
        //Boolean to state whether track is playing or not
        bool isPlaying;

        // Hosts the player
        //MusicControl musicControl;

        /// <summary>
        /// Init for form
        /// </summary>
        public frmMusicPlayer()
        {
            InitializeComponent();

            // Setup music controller

            musicControl = new MusicControl();

            //Set to not playing
            isPlaying = false;

            //musicControl = new MusicControl();

        }

        /// <summary>
        /// Plays the mp3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //musicControl.play();
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
            //musicControl.stop();
        }

        private void ofdMusicOpener_FileOk(object sender, CancelEventArgs e)
        {
            lblFileName.Text = ofdMusicOpener.FileName;
            //musicControl.open(lblFileName.Text);
        }

        /// <summary>
        /// Loads a test file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openTest(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string[] resourceList = assembly.GetManifestResourceNames();

            var resourceName = "MALT_Music.Resources.Test.mp3";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string filePath = reader.ReadToEnd();
                string path = Path.GetFullPath(@"..\..\Resources\Test.mp3");
                lblFileName.Text = path;
                //musicControl.open(path);
            }

            
            
            //musicControl.open();
        }


        //Clicking play or pause
        private void picBoxPlayPause_Click(object sender, EventArgs e)
        {
            if (isPlaying == false)
            {
                //Plays the song
                musicControl.play();

                //Run code to play song, eventually setting isPlaying to true if successful
                isPlaying = true;

                //Change image to pause image
                picBoxPlayPause.Image = Properties.Resources.pause_track;
            }
            else if (isPlaying == true)
            {
                //Pauses the song
                musicControl.pause();

                //Run code to pause song
                isPlaying = false;

                //Change image to play image
                picBoxPlayPause.Image = Properties.Resources.play_track;

            }
        }
    }
}
