using MALT_Music.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MALT_Music.Models;

namespace MALT_Music
{
    public partial class ViewAllResults : Form
    {
        public ViewAllResults(frmMusicPlayer musicPlayer, List<Playlist> userPlaylists, HomePage parent)
        {
            InitializeComponent();
            this.musicPlayer = musicPlayer;
            this.usersPlaylists = userPlaylists;
            this.parent = parent;
        }


        private List<Song> songList = new List<Song>();
        private List<Playlist> playlistList = new List<Playlist>();
        private List<String> artistList = new List<String>();

        HomePage parent;

        int selectedSong = -1;

        List<Label> playlistLabels = new List<Label>();

        List<Playlist> usersPlaylists;
        frmMusicPlayer musicPlayer;

        List<Label> songLabelsA = new List<Label>();
        List<Label> songLabelsB = new List<Label>();
        List<Label> songLabelsC = new List<Label>();
        List<Label> songLabelsD = new List<Label>();


        List<Label> playlistLabelName = new List<Label>();
        List<Label> playlistLabelOwner = new List<Label>();
        List<Label> artistLabel = new List<Label>();

        public void setSongs(List<Song> listS)      { this.songList = listS; }
        public void setPlaylists(List<Playlist> p)  { this.playlistList = p; }
        public void setArtists(List<String> a) { this.artistList = a; }

        public void createSongList(String searchText)
        {
            this.lblSearchedFor.Text = "Search Results for: '" + searchText + "':";

            int i = 0;
            while (i < this.songList.Count)
            {

                Label newLabelSongName = new Label();
                newLabelSongName.Text = songList[i].getTrackName();
                newLabelSongName.Size = new Size(306, 30);
                newLabelSongName.Location = new Point(0, (40 + (i * 32)));
                newLabelSongName.TextAlign = ContentAlignment.MiddleLeft;
                newLabelSongName.ForeColor = Color.White;
                newLabelSongName.UseMnemonic = false;   // & symbol thing
                if (i % 2 == 0) { newLabelSongName.BackColor = Color.FromArgb(60, 60, 60); } else { newLabelSongName.BackColor = Color.FromArgb(90, 90, 90); }
                newLabelSongName.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabelSongName.Tag = i.ToString();
                newLabelSongName.Click += clickEventSongs;
                newLabelSongName.MouseEnter += hoverEvent;
                newLabelSongName.MouseLeave += leaveEvent;


                LinkLabel newLabelSongArtist = new LinkLabel();
                newLabelSongArtist.Text = songList[i].getArtist();
                newLabelSongArtist.Size = new Size(196, 30);
                newLabelSongArtist.Location = new Point(309, (40 + (i * 32)));
                newLabelSongArtist.TextAlign = ContentAlignment.MiddleLeft;
                newLabelSongArtist.ForeColor = Color.White;
                newLabelSongArtist.LinkColor = Color.White;
                newLabelSongArtist.VisitedLinkColor = Color.White;
                newLabelSongArtist.LinkBehavior = LinkBehavior.HoverUnderline;
                newLabelSongArtist.UseMnemonic = false;   // & symbol thing
                if (i % 2 == 0) { newLabelSongArtist.BackColor = Color.FromArgb(60, 60, 60); } else { newLabelSongArtist.BackColor = Color.FromArgb(90, 90, 90); }
                newLabelSongArtist.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabelSongArtist.Tag = i.ToString();

                newLabelSongArtist.Click += clickEventSongs;
                newLabelSongArtist.MouseEnter += hoverEvent;
                newLabelSongArtist.MouseLeave += leaveEvent;
                newLabelSongArtist.LinkClicked += goToArtist;


                Label newLabelSongAlbum = new Label();
                newLabelSongAlbum.Text = songList[i].getAlbum();
                newLabelSongAlbum.Size = new Size(196, 30);
                newLabelSongAlbum.Location = new Point(508, (40 + (i * 32)));
                newLabelSongAlbum.TextAlign = ContentAlignment.MiddleLeft;
                newLabelSongAlbum.ForeColor = Color.White;
                newLabelSongAlbum.UseMnemonic = false;   // & symbol thing
                if (i % 2 == 0) { newLabelSongAlbum.BackColor = Color.FromArgb(60, 60, 60); } else { newLabelSongAlbum.BackColor = Color.FromArgb(90, 90, 90); }
                newLabelSongAlbum.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabelSongAlbum.Tag = i.ToString();

                newLabelSongAlbum.Click += clickEventSongs;
                newLabelSongAlbum.MouseEnter += hoverEvent;
                newLabelSongAlbum.MouseLeave += leaveEvent;


                Label newLabelSongYear = new Label();
                newLabelSongYear.Text = songList[i].getYear().ToString();
                newLabelSongYear.Size = new Size(73, 30);
                newLabelSongYear.Location = new Point(707, (40 + (i * 32)));
                newLabelSongYear.TextAlign = ContentAlignment.MiddleLeft;
                newLabelSongYear.ForeColor = Color.White;
                newLabelSongYear.UseMnemonic = false;   // & symbol thing
                if (i % 2 == 0) { newLabelSongYear.BackColor = Color.FromArgb(60, 60, 60); } else { newLabelSongYear.BackColor = Color.FromArgb(90, 90, 90); }
                newLabelSongYear.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabelSongYear.Tag = i.ToString();

                newLabelSongYear.Click += clickEventSongs;
                newLabelSongYear.MouseEnter += hoverEvent;
                newLabelSongYear.MouseLeave += leaveEvent;

                songLabelsA.Add(newLabelSongName);
                this.Controls.Add(songLabelsA[i]);

                songLabelsB.Add(newLabelSongArtist);
                this.Controls.Add(songLabelsB[i]);

                songLabelsC.Add(newLabelSongAlbum);
                this.Controls.Add(songLabelsC[i]);

                songLabelsD.Add(newLabelSongYear);
                this.Controls.Add(songLabelsD[i]);

                i++;
            }

            Label spaceLabel = new Label();
            spaceLabel.Top = (songList.Count * 42) - 20;
            spaceLabel.Height = 10;
            spaceLabel.BackColor = Color.Black;
            this.Controls.Add(spaceLabel);

            addPlaylistLabels();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goToArtist(object sender, EventArgs e)
        {
            LinkLabel theLabel = (LinkLabel)sender;
            String artist = theLabel.Text;

            pnlOptions.Visible = false;
            pnlPlaylists.Visible = false;

            SongModel songModel = new SongModel();
            List<Song> songsForArtist = songModel.getSongsByArtist(artist);
            
            //Call the method in parent to open artist window, passing data back
            parent.artistSelected(artist, songsForArtist);
            this.Hide();

        }

        public void addPlaylistLabels()
        {
            if (usersPlaylists.Count > 0)
            {
                for (int i = 0; i < usersPlaylists.Count; i++)
                {
                    Label newLabel = new Label();

                    newLabel.Location = new Point(1, 1 + (i * 29));
                    newLabel.ForeColor = Color.White;
                    newLabel.BackColor = Color.FromArgb(40, 40, 40);
                    newLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newLabel.Tag = i.ToString();
                    newLabel.Size = new Size(140, 26);
                    newLabel.Text = usersPlaylists[i].getPlaylistName();
                    newLabel.TextAlign = ContentAlignment.MiddleCenter;
                    newLabel.Click += addSongToPlaylist;
                    newLabel.MouseEnter += playlistHover;
                    newLabel.MouseLeave += playlistLeave;

                    playlistLabels.Add(newLabel);
                    pnlPlaylists.Controls.Add(playlistLabels[i]);
                }
            }
            else
            {
                Label newLabel = new Label();

                newLabel.Location = new Point(1, 1);
                newLabel.ForeColor = Color.Gray;
                newLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabel.Size = new Size(140, 50);
                newLabel.Text = "You currently have no playlists";
                newLabel.TextAlign = ContentAlignment.MiddleCenter;

                pnlPlaylists.Controls.Add(newLabel);
            }
        }

        //Method when clicking artist
        private void artistClick(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            String artist = artistLabel[id].Text;

            SongModel songModel = new SongModel();
            List<Song> songsForArtist = songModel.getSongsByArtist(artist);


            //Call the method in parent to open artist window, passing data back
            parent.artistSelected(artist, songsForArtist);
            this.Close();

        }

        public void createArtistList(String searchText)
        {
            this.lblSearchedFor.Text = "Search Results for: '" + searchText + "':";
            int i = 0;
            while (i < this.artistList.Count)
            {
                Label newArtist = new Label();
                newArtist.Text = artistList[i];
                newArtist.Size = new Size(780, 30);
                newArtist.Location = new Point(0, (40 + (i * 32)));
                newArtist.TextAlign = ContentAlignment.MiddleLeft;
                newArtist.ForeColor = Color.White;
                newArtist.UseMnemonic = false;
                if (i % 2 == 0) { newArtist.BackColor = Color.FromArgb(60, 60, 60); } else { newArtist.BackColor = Color.FromArgb(90, 90, 90); }
                newArtist.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newArtist.Tag = i.ToString();
                newArtist.Click += artistClick;
                newArtist.MouseLeave += artistLeave;
                newArtist.MouseEnter += artistHover;


                artistLabel.Add(newArtist);
                this.Controls.Add(artistLabel[i]);

                i++;
            }
        }


        //Double click event to play a playlist
        private void playPlaylist(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int index = int.Parse(theLabel.Tag.ToString());

            musicPlayer.setPlaylist(playlistList[index], 0);
            musicPlayer.playCurrentSong();

        }


        public void createPlaylistList(String searchText)
        {
            this.lblSearchedFor.Text = "Search Results for: '" + searchText + "':";
            int i = 0;
            while (i < this.playlistList.Count)
            {
                Label newPlaylist = new Label();
                newPlaylist.Text = playlistList[i].getPlaylistName();
                newPlaylist.Size = new Size(407, 30);
                newPlaylist.Location = new Point(0, (40 + (i * 32)));
                newPlaylist.TextAlign = ContentAlignment.MiddleLeft;
                newPlaylist.ForeColor = Color.White;
                newPlaylist.UseMnemonic = false;
                newPlaylist.DoubleClick += playPlaylist;
                
                if (i % 2 == 0) { newPlaylist.BackColor = Color.FromArgb(60, 60, 60); } else { newPlaylist.BackColor = Color.FromArgb(90, 90, 90); }
                newPlaylist.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                
                newPlaylist.Tag = i.ToString();
                newPlaylist.Click += goToPlaylist;
                newPlaylist.MouseLeave += playlistSearchHover;
                newPlaylist.MouseEnter += playlistSearchHover;

                playlistLabelName.Add(newPlaylist);
                this.Controls.Add(playlistLabelName[i]);

                Label newPlaylistOwner = new Label();
                newPlaylistOwner.Text = playlistList[i].getOwner();
                newPlaylistOwner.Size = new Size(370, 30);
                newPlaylistOwner.Location = new Point(410, (40 + (i * 32)));
                newPlaylistOwner.TextAlign = ContentAlignment.MiddleLeft;
                newPlaylistOwner.ForeColor = Color.White;
                newPlaylistOwner.UseMnemonic = false;
                newPlaylistOwner.DoubleClick += playPlaylist;
                if (i % 2 == 0) { newPlaylistOwner.BackColor = Color.FromArgb(60, 60, 60); } else { newPlaylistOwner.BackColor = Color.FromArgb(90, 90, 90); }
                newPlaylistOwner.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                
                newPlaylistOwner.Tag = i.ToString();
                newPlaylistOwner.Click += goToPlaylist;
                newPlaylistOwner.MouseLeave += playlistSearchLeave;
                newPlaylistOwner.MouseEnter += playlistSearchHover;

                playlistLabelOwner.Add(newPlaylistOwner);
                this.Controls.Add(playlistLabelOwner[i]);

                i++;
            }
        }

        private void goToPlaylist(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int index = int.Parse(theLabel.Tag.ToString());
            String playlistName = playlistLabelName[index].Text;
            String owner = playlistLabelOwner[index].Text;

            PlaylistModel playlistModel = new PlaylistModel();
            Playlist thePlaylist = playlistModel.getPlaylist(playlistName, owner);
            
            parent.showViewPlaylist(thePlaylist);

            this.Close();

        }

        #region mouse event handlers

        //Highlights blue over artist selection
        private void artistHover(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            artistLabel[id].BackColor = Color.DodgerBlue;

        }

        //Change backcolour when leaving artist hover selection
        private void artistLeave(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            if (id % 2 == 0)
            {
                artistLabel[id].BackColor = Color.FromArgb(60, 60, 60);
            }
            else
            {
                artistLabel[id].BackColor = Color.FromArgb(90, 90, 90);
            }

        }

        private void playlistSearchHover(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            playlistLabelName[id].BackColor = Color.DodgerBlue;
            playlistLabelOwner[id].BackColor = Color.DodgerBlue;

        }

        //Change backcolour when leaving artist hover selection
        private void playlistSearchLeave(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            if (id % 2 == 0)
            {
                playlistLabelName[id].BackColor = Color.FromArgb(60, 60, 60);
                playlistLabelOwner[id].BackColor = Color.FromArgb(60, 60, 60);
            }
            else
            {
                playlistLabelName[id].BackColor = Color.FromArgb(90, 90, 90);
                playlistLabelOwner[id].BackColor = Color.FromArgb(90, 90, 90);
            }

        }



        private void hoverEvent(object sender, System.EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            if (!(songLabelsA[id].BackColor == Color.FromArgb(255, 50, 50)))
            {
                songLabelsA[id].BackColor = Color.DodgerBlue;
                songLabelsB[id].BackColor = Color.DodgerBlue;
                songLabelsC[id].BackColor = Color.DodgerBlue;
                songLabelsD[id].BackColor = Color.DodgerBlue;
            }

        }

        private void leaveEvent(object sender, System.EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            if (!(songLabelsA[id].BackColor == Color.FromArgb(50, 255, 50)))
            {

                if (id % 2 == 0)
                {
                    songLabelsA[id].BackColor = Color.FromArgb(60, 60, 60);
                    songLabelsB[id].BackColor = Color.FromArgb(60, 60, 60);
                    songLabelsC[id].BackColor = Color.FromArgb(60, 60, 60);
                    songLabelsD[id].BackColor = Color.FromArgb(60, 60, 60);
                }
                else
                {
                    songLabelsA[id].BackColor = Color.FromArgb(90, 90, 90);
                    songLabelsB[id].BackColor = Color.FromArgb(90, 90, 90);
                    songLabelsC[id].BackColor = Color.FromArgb(90, 90, 90);
                    songLabelsD[id].BackColor = Color.FromArgb(90, 90, 90);
                }
            }

        }

        #endregion

        private void tmrOptionsDelay_Tick(object sender, EventArgs e)
        {

            if (!pnlPlaylists.Bounds.Contains(PointToClient(Control.MousePosition)) && !pnlOptions.Bounds.Contains(PointToClient(Control.MousePosition)))
            {
                pnlOptions.Visible = false;

                pnlPlaylists.Visible = false;
            }
            tmrOptionsDelay.Stop();
        }

        private void clickEventSongs(object sender, System.EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            selectedSong = id;

            pnlOptions.Top = songLabelsA[id].Top;
            pnlPlaylists.Top = songLabelsA[id].Top;

            pnlOptions.Visible = true;
        }

        /// <summary>
        /// timer to control when the playlist panel disappears
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrPlaylistDelay_Tick(object sender, EventArgs e)
        {
            if (!pnlPlaylists.Bounds.Contains(PointToClient(Control.MousePosition)))
            {
                pnlPlaylists.Visible = false;
            }
            tmrPlaylistDelay.Stop();
        }

        /// <summary>
        /// when the mouse enters the add to playlist label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAddToPLaylist_Enter(object sender, EventArgs e)
        {
            lblAddToPlaylist.BackColor = Color.DodgerBlue;
            pnlPlaylists.Visible = true;
        }

        /// <summary>
        /// when the mouse leaves the add to playist label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAddToPLaylist_Leave(object sender, EventArgs e)
        {
            tmrOptionsDelay.Start();
            lblAddToPlaylist.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void lblPlay_Enter(object sender, EventArgs e)
        {
            lblPlay.BackColor = Color.DodgerBlue;
            pnlPlaylists.Visible = false;
        }

        private void lblPlay_Leave(object sender, EventArgs e)
        {
            tmrOptionsDelay.Start();
            lblPlay.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void addSongToPlaylist(object sender, EventArgs e)
        {
            int playListIndex;

            Label theLabel = (Label)sender;
            playListIndex = int.Parse(theLabel.Tag.ToString());

            Playlist thePlaylist = usersPlaylists[playListIndex];
            Song toAdd = songList[selectedSong];

            PlaylistModel playlistModel = new PlaylistModel();

            playlistModel.addSongToPlaylist(thePlaylist, toAdd);

        }

        private void playlistHover(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            playlistLabels[id].BackColor = Color.DodgerBlue;

        }

        //Hover away from playlist
        private void playlistLeave(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            playlistLabels[id].BackColor = Color.FromArgb(40, 40, 40);

        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            if (selectedSong > -1)
            {
                songLabelsA[selectedSong].BackColor = Color.FromArgb(255, 50, 50);
                songLabelsB[selectedSong].BackColor = Color.FromArgb(255, 50, 50);
                songLabelsC[selectedSong].BackColor = Color.FromArgb(255, 50, 50);
                songLabelsD[selectedSong].BackColor = Color.FromArgb(255, 50, 50);

                String filePath = songList[selectedSong].getFileLocation();
                String imagePath = "../../tracks/" + songList[selectedSong].getArtist() + "/" + songList[selectedSong].getAlbum() + "/" + songList[selectedSong].getAlbum() + ".jpg";
                musicPlayer.stopSong();

                Playlist toPlay = new Playlist();
                toPlay.addSongs(songList[selectedSong]);

                musicPlayer.setPlaylist(toPlay, 0);
                musicPlayer.playCurrentSong();
            }
        }
    }
}
