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
using MALT_Music.DataObjects;
using MALT_Music.Models;

namespace MALT_Music
{
    // Contains functions for the music controller
    public partial class frmMusicPlayer : Form
    {
        // Class variables
        MusicController musicController;
        HomePage parent;
        Playlist activePlaylist;
        Song thisSong;

        int trackLength;
        int playlistIndex;
        bool isPlaying;
        bool playPause;
        bool timeIndic;
        float volumeLevel;

        /// <summary>
        /// Variables for slider bar.
        /// </summary>
        private int sliderValue;
        private bool mouseIsDown;

        /// <summary>
        /// Init for form
        /// </summary>
        public frmMusicPlayer(HomePage thisParent)
        {
            InitializeComponent();

            // Setup music controller
            musicController = new MusicController();

            // Acquire the parent form (the home page)
            parent = thisParent;

            isPlaying = false;
            playPause = true; // Sets to pause mode
            timeIndic = false; // Sets timer to negative
            lblPlayerStatus.Text = "No song selected";

            // Updates volume control
            setVolume(0.5f);

            // Initialise slider
            sliderValue = 0;
            trackLength = 0;
            mouseIsDown = false;
            ttpSliderIndicator.Hide(this);
        }

        #region Event Actions ### Contains all event handlers for controls
        /// <summary>
        /// Triggers the play routine
        /// </summary>.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pcbPlay_Click(object sender, EventArgs e)
        {
            playCurrentSong();
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
        #endregion

        /// <summary>
        /// Acquires the file path of the song via the playlist
        /// </summary>
        /// <returns>The file location of the song</returns>
        private string getNextSong()
        {
            // Acquires the song
            thisSong = activePlaylist.getSongByID(playlistIndex);

            // Get and the album artwork
            string imagePath = thisSong.getImagePath();

            // Sets the album art image
            if (imagePath != "" && imagePath != null)
            {
                picBoxAlbumArt.ImageLocation = imagePath;
            }
            else
            {
                picBoxAlbumArt.Image = MALT_Music.Properties.Resources.logo;
            }
            
            // Acquires the path
            string songPath = thisSong.getFileLocation();

            return songPath;
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
                    // Get the file path
                    string songPath = getNextSong();

                    // Sets song to be played
                    musicController.setSong(songPath);
                    string trackDetails = "Now Playing: " + thisSong.getTrackName() + " by " + thisSong.getArtist();
                    lblPlayerStatus.Text = trackDetails;

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
                
                // Updates playcount for particular song
                VoteModel voteModel = new VoteModel();
                Song updSong = activePlaylist.getSongByID(playlistIndex);
                voteModel.updatePlayCount(thisSong.getSongID());

                // Initiates playing of song
                musicController.playSong();
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
        /// Sets the playlists of songs
        /// </summary>
        /// <param name="incomingPlaylist">The playlist to be played</param>
        /// <param name="playIndex">The starting position of the playlist (ie. track 3)</param>
        public void setPlaylist(Playlist incomingPlaylist, int playIndex)
        {
            // Sets the incoming playlist parameters
            activePlaylist = incomingPlaylist;
            playlistIndex = playIndex;
        }

       

        /// <summary>
        /// Stops playing the track
        /// </summary>
        public void stopSong()
        {
            // Disables track timer
            tmrTracker.Enabled = false;

            // Resets position of tracker
            SetValue(0);

            // Stops the track
            musicController.stopSong();
            isPlaying = false;

            // Updates status of controls
            playPause = false;
            lblTimeOne.Text = "";
            lblTimeTwo.Text = "";

            // Changes button image to play
            pcbPlay.Image = Properties.Resources.playtrack;
            playPause = true;

            // If a file is loaded
            if (lblPlayerStatus.Text != "")
            {
                pcbPlay.Enabled = true;
            }
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
            // Holds the time
            TimeSpan currentTime;

            if (timeIndic) // If negative count down
            {
                int num = trackLength - sliderValue;
                currentTime = TimeSpan.FromSeconds(num);
                lblTimeOne.Text = "-" + currentTime.ToString("mm':'ss");
            }
            else // If positive count up
            {
                currentTime = TimeSpan.FromSeconds(sliderValue);
                lblTimeOne.Text = currentTime.ToString("mm':'ss");
            }

            // Returns the current time
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
            if (value >= trackLength) // End of the song
            {
                // Checks where to increment the index counter to (if not repeating)
                if (playlistIndex < activePlaylist.getPlaylistSize() && !rbnCurrent.Checked  && !rbnOnce.Checked)
                {
                    playlistIndex++;
                }

                // Checks repeat status
                if (rbnNone.Checked)
                {
                    // Resets tracker bar
                    value = 0;

                        stopSong();

                    // If it is at the end of the playlist
                    if (!(playlistIndex >= activePlaylist.getPlaylistSize() - 1))
                    {
                        // Stops current song, and plays the next song    
                        playCurrentSong();  
                    }
    
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
                    value = 0;

                    // If at the end of the playlist
                    if (playlistIndex >= activePlaylist.getPlaylistSize())
                    {
                        playlistIndex = 0;
                    }

                    // Stops the current song, and starts the next song
                    stopSong();
                    playCurrentSong(); 
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

        /// <summary>
        /// Toggles the state of the clock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTimeOne_Click(object sender, EventArgs e)
        {
            if (timeIndic) // Negative count down
            {
                updateTimeIndicator();
                timeIndic = false;
            }
            else // Positive count up
            {
                updateTimeIndicator();
                timeIndic = true;
            }
        }


        #region Volume Control ## Functions for the volume control
        private void pcbVolume_MouseDown(object sender, MouseEventArgs e)
        {
            // Return if no track loaded
            //if (!isPlaying)
            //{ return; }

            // Update mouse down tracker
            mouseIsDown = true;

            // Updates value of slider
            setVolume(XtoValue(e.X));
        }

        /// <summary>
        /// Sets the volume of the player
        /// </summary>
        /// <param name="value">The new value for the volume</param>
        public void setVolume(float value)
        {
            // Make sure the new value is within bounds.
            if (value < 0f) value = 0f;
            if (value > 1f) value = 1f;

            // See if the value has changed.
            if (volumeLevel == value) return;

            // Save the new value.
            volumeLevel = value;

            // Redraw to show the new value.
            pcbVolume.Refresh();

            // Display the value tooltip.
            int tip_x = pcbVolume.Left + (int)volValueToX(volumeLevel);
            int tip_y = pcbVolume.Top;
            ttpVolumeIndicator.Show(volumeLevel.ToString("0.00"), this, tip_x, tip_y, 3000);

            // Updates label
            int vol = Convert.ToInt32(volumeLevel * 100);
            lblVolumeLevel.Text = vol.ToString() + "%";
        }

        /// <summary>
        /// Converts the value into a coordinate
        /// </summary>
        /// <param name="value">The raw value to convert to coordinate</param>
        /// <returns></returns>
        private float volValueToX(float value)
        {
            return (pcbVolume.ClientSize.Width - 1) * (value / 1f);
        }

        /// <summary>
        /// Converts the coordinate into a value
        /// </summary>
        /// <param name="x">Float raw value of coordinate</param>
        /// <returns></returns>
        private float volXtoValue(int x)
        {
            return 1 * x / (float)(pcbVolume.ClientSize.Width - 1);
        }


        private void pcbVolume_MouseMove(object sender, MouseEventArgs e)
        {
            // Return if no track loaded
            //if (!isPlaying)
            //{ return; }

            // If mouse button is pushed, update position
            if (!mouseIsDown) return;
            setVolume(volXtoValue(e.X));

            // Updates volume level
            musicController.setVolume(volumeLevel);
        }

        private void pcbVolume_MouseUp(object sender, MouseEventArgs e)
        {
            // Return if no track loaded
            if (!isPlaying)
            { return; }

            mouseIsDown = false;
            ttpVolumeIndicator.Hide(this);
        }

        private void pcbVolume_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the needle's X coordinate.
            float x = volValueToX(volumeLevel);

            if (x > 0)
            {
                // Draw it.
                e.Graphics.DrawLine(Pens.Black,
                    x, 0,
                    x, pcbVolume.ClientSize.Height);
            }
        }
        #endregion

        /// <summary>
        /// Skips to next song in playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pcbForwardSkip_Click(object sender, EventArgs e)
        {
            // If not playing a song
            if (!isPlaying)
            { return; }

            // If there is a playlist
            if (activePlaylist != null)
            {
                // If not at the end of the playlist
                if (!(playlistIndex >= activePlaylist.getPlaylistSize() - 1))
                {
                    playlistIndex++;
                    stopSong();
                    playCurrentSong();
                }
                else // Reset to index 0
                {
                    playlistIndex = 0;
                    stopSong();
                    playCurrentSong();
                }
            }
        }

        /// <summary>
        /// Skips to previous song in playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pcbBackSkip_Click(object sender, EventArgs e)
        {
            // If not playing a song
            if (!isPlaying)
            { return; }

            // If there is a playlist
            if (activePlaylist != null)
            {
                // If not at the start of the playlist
                if (!(playlistIndex <= 0))
                {
                    playlistIndex--;
                    stopSong();
                    playCurrentSong();
                }
                else // Set play index to final song
                {
                    playlistIndex = activePlaylist.getPlaylistSize() - 1;
                    stopSong();
                    playCurrentSong();
                }
            }
        }
    }
}
