using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MALT_Music.DataObjects;
using MALT_Music.Models;

namespace MALT_Music
{
    public partial class ViewPlaylist : Form
    {

        List<Label> positionLabels = new List<Label>();
        List<Label> songLabels = new List<Label>();
        List<Label> artistLabels = new List<Label>();
        List<PictureBox> removeLabels = new List<PictureBox>();
        Playlist thePlaylist;
        int selectedSong = 0;

        User currentUser;

        List<Song> songs;

        frmMusicPlayer musicPlayer;


        public ViewPlaylist(Playlist playlist, frmMusicPlayer music, User currentUser)
        {
            InitializeComponent();

            //Set player, playlist, user
            this.musicPlayer = music;
            this.currentUser = currentUser;
            this.thePlaylist = playlist;
            lblPlaylistName.Text = thePlaylist.getPlaylistName();
            lblOwner.Text = thePlaylist.getOwner();
            
            //Initially hide edit box
            txtPlaylistNameEdit.Hide();

            List<Song> songs = thePlaylist.getSongs();
            int numSongs = thePlaylist.getSongs().Count;

            lblNumSongs.Text = numSongs.ToString();

            if (numSongs == 1) { lblNumSongs.Text += " song"; } else { lblNumSongs.Text += " songs"; }

            //Get total playlist length
            int totalLength = 0;
            for (int i = 0; i < songs.Count; i++) 
            {
                totalLength += songs[i].getLength();
            }

            int hours = totalLength / 3600;
            int minutes = (totalLength - hours * 3600) / 60;
            int seconds = totalLength - (hours * 3600) - (minutes * 60);

            //Set up string saying how long the playlist is
            String output = "";
            if(hours > 0)
            {
                output += hours.ToString() + " hours, \n";
            }
            if (minutes > 0)
            {
                output += minutes.ToString() + " minutes, \n";
            }
            if (seconds > 0)
            {
                output += seconds.ToString() + " seconds, \n";
            }

            if (output.Equals(""))
            {
                output = "O seconds";
            }
            else {
                output = output.Substring(0, output.Length - 3);
            }

            //Set length to label
            lblTime.Text = output;

            String currUser = this.currentUser.getUsername();
            String owner = thePlaylist.getOwner();

            if (currUser.Equals(owner))
            {
                picSave.Visible = false;
            }
            else
            {
                picSave.Left = lblPlaylistName.Left + lblPlaylistName.Width + 10;
            }
        }

        public ViewPlaylist()
        {
            InitializeComponent();
        }


        private void setSelected(Object sender, EventArgs e) 
        {
            Label theLabel = (Label)sender;
            int index = int.Parse(theLabel.Tag.ToString());

            this.selectedSong = index;

            pnlOptions.Visible = true;
        }

        public void setupLabels() 
        {
            songs = thePlaylist.getSongs();

            for (int i = 0; i < songs.Count; i++)
            {
                #region Song Name Label
                Label theSongLabel = new Label();

                theSongLabel.Text = songs[i].getTrackName();
                theSongLabel.Size = new Size(344, 30);
                theSongLabel.Location = new Point(423, 156 + (33 * i));
                theSongLabel.Tag = i.ToString();
                theSongLabel.Click += setSelected;
                theSongLabel.ForeColor = Color.FromArgb(225, 225, 225);
                theSongLabel.TextAlign = ContentAlignment.MiddleLeft;
                theSongLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                if (i % 2 == 0)
                {
                    theSongLabel.BackColor = Color.FromArgb(60, 60, 60);
                }
                else
                {
                    theSongLabel.BackColor = Color.FromArgb(40, 40, 40);
                }

                songLabels.Add(theSongLabel);

                this.Controls.Add(songLabels[i]);
                #endregion 

                #region Position Label
                Label thePositionLabel = new Label();

                thePositionLabel.Text = (i + 1).ToString();
                thePositionLabel.Size = new Size(50, 30);
                thePositionLabel.Location = new Point(370, 156 + (33 * i));
                thePositionLabel.Tag = i.ToString();
                //thePositionLabel.Click += clickEvent;
                thePositionLabel.ForeColor = Color.FromArgb(225, 225, 225);
                thePositionLabel.TextAlign = ContentAlignment.MiddleLeft;
                thePositionLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                if (i % 2 == 0)
                {
                    thePositionLabel.BackColor = Color.FromArgb(60, 60, 60);
                }
                else
                {
                    thePositionLabel.BackColor = Color.FromArgb(40, 40, 40);
                }

                positionLabels.Add(thePositionLabel);

                this.Controls.Add(positionLabels[i]);
                #endregion

                #region Artist Label
                Label theArtistLabel = new Label();

                theArtistLabel.Text = songs[i].getArtist();
                theArtistLabel.Size = new Size(250, 30);
                theArtistLabel.Location = new Point(770, 156 + (33 * i));
                theArtistLabel.Tag = i.ToString();
                //theArtistLabel.Click += clickEvent;
                theArtistLabel.ForeColor = Color.FromArgb(225, 225, 225);
                theArtistLabel.TextAlign = ContentAlignment.MiddleLeft;
                theArtistLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                if (i % 2 == 0)
                {
                    theArtistLabel.BackColor = Color.FromArgb(60, 60, 60);
                }
                else
                {
                    theArtistLabel.BackColor = Color.FromArgb(40, 40, 40);
                }

                artistLabels.Add(theArtistLabel);

                this.Controls.Add(artistLabels[i]);
                #endregion
                
                #region Remove Icon
                if (thePlaylist.getOwner().Equals(currentUser.getUsername()))
                {
                    PictureBox removeIcon = new PictureBox();

                    removeIcon.Size = new Size(20, 20);
                    removeIcon.Location = new Point(1025, 161 + (33 * i));
                    removeIcon.BackgroundImage = Properties.Resources.removeFromPlaylist;
                    removeIcon.BackgroundImageLayout = ImageLayout.Stretch;
                    removeIcon.Tag = i.ToString();
                    removeIcon.Click += removeSong;
                    removeIcon.ForeColor = Color.FromArgb(225, 225, 225);
                    
                    removeLabels.Add(removeIcon);

                    this.Controls.Add(removeLabels[i]);
                }
                #endregion

            }
        }

        private void removeSong(object sender, EventArgs e) 
        {
            // Convert the sender to a picture box
            PictureBox picBox = (PictureBox)sender;
            // Get the index from the tag
            int index = int.Parse(picBox.Tag.ToString());
            // Get the relevant song
            Song theSong = songs[index];

            // Remove the song from the playlist
            PlaylistModel playlistModel = new PlaylistModel();
            playlistModel.removeSongFromPlaylist(thePlaylist, theSong);


            this.Controls.Remove(removeLabels[index]);
            removeLabels.RemoveAt(index);

            this.Controls.Remove(artistLabels[index]);
            artistLabels.RemoveAt(index);

            this.Controls.Remove(songLabels[index]);
            songLabels.RemoveAt(index);

            this.Controls.Remove(positionLabels[index]);
            positionLabels.RemoveAt(index);

            songs.RemoveAt(index);

            for (int i = index; i < songs.Count; i++)
            {
                removeLabels[i].Top -= 33;
                artistLabels[i].Top -= 33;
                positionLabels[i].Top -= 33;
                songLabels[i].Top -= 33;
                positionLabels[i].Text = (i + 1).ToString();
                removeLabels[i].Tag = (i).ToString();
                artistLabels[i].Tag = (i).ToString();
                positionLabels[i].Tag = (i).ToString();
                songLabels[i].Tag = (i).ToString();

                if (i % 2 == 0)
                {
                    positionLabels[i].BackColor = Color.FromArgb(60, 60, 60);
                    songLabels[i].BackColor = Color.FromArgb(60, 60, 60);
                    artistLabels[i].BackColor = Color.FromArgb(60, 60, 60);
                }
                else
                {
                    positionLabels[i].BackColor = Color.FromArgb(40, 40, 40);
                    songLabels[i].BackColor = Color.FromArgb(40, 40, 40);
                    artistLabels[i].BackColor = Color.FromArgb(40, 40, 40);
                }

                setupAlbumCovers(songs);

            }


        }

        //Set up thumbnail for playlist consisting of four album covers
        public void setupAlbumCovers(List<Song> songs)
        {
            List<String> taken = new List<String>();

            // Reset images - needed incase of reload (auto update). Andrew understands this comment
            coverImage1.BackgroundImage = null;
            coverImage2.BackgroundImage = null;
            coverImage3.BackgroundImage = null;
            coverImage4.BackgroundImage = null;

            int i = 0;

            while (i < songs.Count && taken.Count < 4) 
            {
                if (!taken.Contains(songs[i].getAlbum() + songs[i].getArtist()))
                {
                    Image coverImage;

                    try
                    {
                        coverImage = Image.FromFile(@"../../tracks/" + songs[i].getArtist() + "/" + songs[i].getAlbum() + "/" + songs[i].getAlbum() + ".jpg");
                    }
                    catch (Exception) {
                        coverImage = Properties.Resources.logo;
                    }

                    //Set up album images of first four albums
                    if (taken.Count == 0)
                    {
                        coverImage1.BackgroundImage = coverImage;
                    }
                    else if (taken.Count == 1)
                    {
                        coverImage2.BackgroundImage = coverImage;
                    }
                    else if (taken.Count == 2)
                    {
                        coverImage3.BackgroundImage = coverImage;
                    }
                    else
                    {
                        coverImage4.BackgroundImage = coverImage;
                    }

                    taken.Add(songs[i].getAlbum() + songs[i].getArtist());
                }

                i++;

            }
        }

        //Play song in music player
        private void lblPlay_Click(object sender, EventArgs e)
        {
            //Get song
            Song toAdd = new Song();
            String songName = songLabels[selectedSong].Text;

            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i].getTrackName().Equals(songName))
                {
                    toAdd = songs[i];
                    break;
                }
            }

            //Play in music player
            if (toAdd.getTrackName() != null && toAdd.getTrackName() != "")
            {
                //Get filepath of song, stop currently playing song
                String filePath = toAdd.getFileLocation();
                musicPlayer.stopSong();

                //Play song at path
                String imagePath = "../../tracks/" + toAdd.getArtist() + "/" + toAdd.getAlbum() + "/" + toAdd.getAlbum() + ".jpg";
                musicPlayer.setSongPath(@"" + filePath, imagePath);
                musicPlayer.playCurrentSong();
            }

            pnlOptions.Visible = false;
        }

        //On clicking the playlist name, allow user to edit it
        private void lblPlaylistName_Click(object sender, EventArgs e)
        {

            picSave.Left = txtPlaylistNameEdit.Left + txtPlaylistNameEdit.Width + 10;

            //Set contents of edit box to playlist name
            txtPlaylistNameEdit.Text = lblPlaylistName.Text;

            //Display edit box
            txtPlaylistNameEdit.Show();

            //Hide label
            lblPlaylistName.Hide();
        }

        //When leaving mouse hover of edit box, save
        private void txtPlaylistNameEdit_MouseLeave(object sender, EventArgs e)
        {
            //Get new name
            if (txtPlaylistNameEdit.Text != "")
            {
                //Update text for user
                lblPlaylistName.Text = txtPlaylistNameEdit.Text;

                //Convert to string for use in method
                String newPlaylistName = txtPlaylistNameEdit.Text;

                //Update playlistname in database
                PlaylistModel playlistModel = new PlaylistModel();

                playlistModel.renamePlaylist(thePlaylist, newPlaylistName);

                //Hide textbox
                txtPlaylistNameEdit.Hide();

                //Show label again
                lblPlaylistName.Show();

                picSave.Left = lblPlaylistName.Left + lblPlaylistName.Width + 10;
            }
            else
            {
                //Do nothing
            }
        }

        private void picRecommend_Click(object sender, EventArgs e)
        {
            SongModel songModel = new SongModel();
            List<Song> songList = songModel.getAllSongs();

            List<Song> songsInPlaylist = thePlaylist.getSongs();

            // get all artists 
            
            List<String> artists = new List<String>();

            for (int i = 0; i < thePlaylist.getSongs().Count; i++) 
            {
                String artist = thePlaylist.getSongs()[i].getArtist();

                if (!artists.Contains(artist))
                {
                    artists.Add(thePlaylist.getSongs()[i].getArtist());
                }
            }

            List<Song> artistMatch = songList.Where(song => artists.Contains(song.getArtist())).ToList();

            // Remove songs that already exist in playlist
            for (int i = 0; i < songsInPlaylist.Count; i++) 
            {
                artistMatch.Remove(songsInPlaylist[i]);
            }

            // get all genres
            List<String> genres = new List<String>();

            for (int i = 0; i < thePlaylist.getSongs().Count; i++)
            {
                if (!genres.Contains(thePlaylist.getSongs()[i].getGenre()))
                {
                    genres.Add(thePlaylist.getSongs()[i].getGenre());
                }
            }

            List<Song> genresMatch = songList.Where(song => genres.Contains(song.getGenre())).ToList();



            // GET SONGS - REMEMBER NOT TO SELECT IF ALREADY IN LIST OR ALREADY IN PLAYLIST
            // look for ones that match both artist and genre - max 5 - random 'seed' to select where to start looking?

            // try to get 7/8 matching the genre

            // match about 3 with artist if matches available

        }

        //Pressing enter on textbox does same thing as leaving
        private void txtPlaylistNameEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPlaylistNameEdit_MouseLeave(this, new EventArgs());
            }
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            PlaylistModel playlistModel = new PlaylistModel();
            playlistModel.savePlaylist(this.thePlaylist, currentUser);
        }

    }
}
