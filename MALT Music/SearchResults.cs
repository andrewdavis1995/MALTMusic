﻿using System;
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
    public partial class SearchResults : Form
    {
        public SearchResults()
        {
            InitializeComponent();
        }

        public SearchResults(frmMusicPlayer musicPlayer, HomePage parent)
        {
            InitializeComponent();
            this.musicPlayer = musicPlayer;
            this.parent = parent;
        }

        #region variables
        frmMusicPlayer musicPlayer;
        int selectedSong;

        List<Label> playlistLabels = new List<Label>();

        User currentUser = new User();
        List<Playlist> usersPlaylists = new List<Playlist>();


        private List<Song> songList = new List<Song>();
        private List<String> artists = new List<String>();
        private List<Playlist> playlists = new List<Playlist>();

        List<Label> songLabelsA = new List<Label>();
        List<Label> songLabelsB = new List<Label>();
        List<Label> songLabelsC = new List<Label>();
        List<Label> songLabelsD = new List<Label>();
        Label endLabel = new Label();

        List<Label> artistLabel = new List<Label>();
        Label endLabel2 = new Label();

        List<Label> playlistLabelName = new List<Label>();
        List<Label> playlistLabelOwner = new List<Label>();
        Label endLabel3 = new Label();

        HomePage parent;

        public String searchedFor;

        bool songsState = false;
        bool artistState = false;
        bool playlistState = false;
        #endregion

        public void createSongList(String searchText)
        {
            this.lblSearchedFor.Text = "Search Results for: '" + searchText + "':";
            searchedFor = searchText;

            int i = 0;
            while (i < 9 && i < this.songList.Count)
            {
                Label newLabelSongName = new Label();
                newLabelSongName.Text = songList[i].getTrackName();
                newLabelSongName.Size = new Size(306, 30);
                newLabelSongName.Location = new Point(0, (20 + (i * 32)));
                newLabelSongName.TextAlign = ContentAlignment.MiddleLeft;
                newLabelSongName.ForeColor = Color.White;
                newLabelSongName.UseMnemonic = false;   // & symbol thing
                if (i % 2 == 0) { newLabelSongName.BackColor = Color.FromArgb(60, 60, 60); } else { newLabelSongName.BackColor = Color.FromArgb(90, 90, 90); }
                newLabelSongName.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabelSongName.Tag = i.ToString();
                newLabelSongName.Click += clickEvent;
                newLabelSongName.MouseEnter += hoverEvent;
                newLabelSongName.MouseLeave += leaveEvent;


                LinkLabel newLabelSongArtist = new LinkLabel();
                newLabelSongArtist.Text = songList[i].getArtist();
                newLabelSongArtist.Size = new Size(196, 30);
                newLabelSongArtist.Location = new Point(309, (20 + (i * 32)));
                newLabelSongArtist.TextAlign = ContentAlignment.MiddleLeft;
                newLabelSongArtist.ForeColor = Color.White;
                newLabelSongArtist.LinkColor = Color.White;
                newLabelSongArtist.VisitedLinkColor = Color.White;
                newLabelSongArtist.LinkBehavior = LinkBehavior.HoverUnderline;
                newLabelSongArtist.UseMnemonic = false;   // & symbol thing
                if (i % 2 == 0) { newLabelSongArtist.BackColor = Color.FromArgb(60, 60, 60); } else { newLabelSongArtist.BackColor = Color.FromArgb(90, 90, 90); }
                newLabelSongArtist.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabelSongArtist.Tag = i.ToString();

                newLabelSongArtist.Click += clickEvent;
                newLabelSongArtist.MouseEnter += hoverEvent;
                newLabelSongArtist.MouseLeave += leaveEvent;
                newLabelSongArtist.LinkClicked += goToArtist;


                Label newLabelSongAlbum = new Label();
                newLabelSongAlbum.Text = songList[i].getAlbum();
                newLabelSongAlbum.Size = new Size(196, 30);
                newLabelSongAlbum.Location = new Point(508, (20 + (i * 32)));
                newLabelSongAlbum.TextAlign = ContentAlignment.MiddleLeft;
                newLabelSongAlbum.ForeColor = Color.White;
                newLabelSongAlbum.UseMnemonic = false;   // & symbol thing
                if (i % 2 == 0) { newLabelSongAlbum.BackColor = Color.FromArgb(60, 60, 60); } else { newLabelSongAlbum.BackColor = Color.FromArgb(90, 90, 90); }
                newLabelSongAlbum.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabelSongAlbum.Tag = i.ToString();

                newLabelSongAlbum.Click += clickEvent;
                newLabelSongAlbum.MouseEnter += hoverEvent;
                newLabelSongAlbum.MouseLeave += leaveEvent;


                Label newLabelSongYear = new Label();
                newLabelSongYear.Text = songList[i].getYear().ToString();
                newLabelSongYear.Size = new Size(73, 30);
                newLabelSongYear.Location = new Point(707, (20 + (i * 32)));
                newLabelSongYear.TextAlign = ContentAlignment.MiddleLeft;
                newLabelSongYear.ForeColor = Color.White;
                newLabelSongYear.UseMnemonic = false;   // & symbol thing
                if (i % 2 == 0) { newLabelSongYear.BackColor = Color.FromArgb(60, 60, 60); } else { newLabelSongYear.BackColor = Color.FromArgb(90, 90, 90); }
                newLabelSongYear.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabelSongYear.Tag = i.ToString();

                newLabelSongYear.Click += clickEvent;
                newLabelSongYear.MouseEnter += hoverEvent;
                newLabelSongYear.MouseLeave += leaveEvent;

                songLabelsA.Add(newLabelSongName);
                pnlSongs.Controls.Add(songLabelsA[i]);

                songLabelsB.Add(newLabelSongArtist);
                pnlSongs.Controls.Add(songLabelsB[i]);

                songLabelsC.Add(newLabelSongAlbum);
                pnlSongs.Controls.Add(songLabelsC[i]);

                songLabelsD.Add(newLabelSongYear);
                pnlSongs.Controls.Add(songLabelsD[i]);

                i++;

            }


            if (i >= songList.Count)
            {
                endLabel.Text = "No More Results";
            }
            else
            {
                int remaining = songList.Count - i;
                endLabel.Text = "(" + remaining + " other results)";
            }

            endLabel.Size = new Size(780, 30);
            endLabel.Location = new Point(0, (20 + (i * 32)));
            endLabel.TextAlign = ContentAlignment.MiddleCenter;
            endLabel.ForeColor = Color.White;
            endLabel.BackColor = Color.FromArgb(20, 20, 20);
            endLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            endLabel.Click += endLabel_Click;
            pnlSongs.Controls.Add(endLabel);


        }

        private void endLabel_Click(Object Sender, EventArgs e)
        {
            ViewAllResults viewAll = new ViewAllResults(this.musicPlayer, usersPlaylists, this.parent);
            viewAll.setSongs(songList);
            viewAll.createSongList(searchedFor);
            viewAll.Show();
        }

        public void createArtistList()
        {
            int i = 0;
            while (i < 9 && i < this.artists.Count)
            {
                Label newArtist = new Label();
                newArtist.Text = artists[i];
                newArtist.Size = new Size(780, 30);
                newArtist.Location = new Point(0, (20 + (i * 32)));
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
                pnlArtists.Controls.Add(artistLabel[i]);

                i++;
            }


            if (i >= songList.Count)
            {
                endLabel2.Text = "No More Results";
            }
            else
            {
                int remaining = artists.Count - i;
                endLabel2.Text = "(" + remaining + " other results)";
            }

            endLabel2.Size = new Size(780, 30);
            endLabel2.Location = new Point(0, (20 + (i * 32)));
            endLabel2.TextAlign = ContentAlignment.MiddleCenter;
            endLabel2.ForeColor = Color.White;
            endLabel2.BackColor = Color.FromArgb(20, 20, 20);
            endLabel2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            endLabel2.Click += endLabel2_Click;
            pnlArtists.Controls.Add(endLabel2);
        }

        private void endLabel2_Click(Object Sender, EventArgs e)
        {
            ViewAllResults viewAll = new ViewAllResults(this.musicPlayer, usersPlaylists, this.parent);
            viewAll.setArtists(artists);
            viewAll.createArtistList(searchedFor);
            viewAll.Show();
        }

        public void createPlaylistList()
        {
            int i = 0;
            while (i < 9 && i < this.playlists.Count)
            {
                Label newPlaylist = new Label();
                newPlaylist.Text = playlists[i].getPlaylistName();
                newPlaylist.Size = new Size(407, 30);
                newPlaylist.Location = new Point(0, (20 + (i * 32)));
                newPlaylist.TextAlign = ContentAlignment.MiddleLeft;
                newPlaylist.ForeColor = Color.White;
                newPlaylist.UseMnemonic = false;
                newPlaylist.DoubleClick += playPlaylist;

                if (i % 2 == 0) { newPlaylist.BackColor = Color.FromArgb(60, 60, 60); } else { newPlaylist.BackColor = Color.FromArgb(90, 90, 90); }

                newPlaylist.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newPlaylist.Tag = i.ToString();
                newPlaylist.Click += goToPlaylist;
                newPlaylist.MouseLeave += playlistSearchLeave;
                newPlaylist.MouseEnter += playlistSearchHover;

                playlistLabelName.Add(newPlaylist);
                pnlSearchPlaylists.Controls.Add(playlistLabelName[i]);

                Label newPlaylistOwner = new Label();
                newPlaylistOwner.Text = playlists[i].getOwner();
                newPlaylistOwner.Size = new Size(370, 30);
                newPlaylistOwner.Location = new Point(410, (20 + (i * 32)));
                newPlaylistOwner.TextAlign = ContentAlignment.MiddleLeft;
                newPlaylistOwner.ForeColor = Color.White;
                newPlaylistOwner.UseMnemonic = false;
                newPlaylistOwner.DoubleClick += playPlaylist;

                if (!playlists[i].getPlaylistName().Contains("$temp$"))
                {
                    if (i % 2 == 0) { newPlaylistOwner.BackColor = Color.FromArgb(60, 60, 60); } else { newPlaylistOwner.BackColor = Color.FromArgb(90, 90, 90); }
                }
                else
                {
                    newPlaylistOwner.BackColor = Color.MidnightBlue;
                }
                newPlaylistOwner.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newPlaylistOwner.Tag = i.ToString();
                newPlaylistOwner.Click += goToPlaylist;
                newPlaylistOwner.MouseLeave += playlistSearchLeave;
                newPlaylistOwner.MouseEnter += playlistHover;

                playlistLabelOwner.Add(newPlaylistOwner);
                pnlSearchPlaylists.Controls.Add(playlistLabelOwner[i]);



                i++;
            }


            if (i >= playlists.Count)
            {
                endLabel3.Text = "No More Results";
            }
            else
            {
                int remaining = playlists.Count - i;
                endLabel3.Text = "(" + remaining + " other results)";
            }

            endLabel3.Size = new Size(780, 30);
            endLabel3.Location = new Point(0, (20 + (i * 32)));
            endLabel3.TextAlign = ContentAlignment.MiddleCenter;
            endLabel3.ForeColor = Color.White;
            endLabel3.BackColor = Color.FromArgb(20, 20, 20);
            endLabel3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            endLabel3.Click += endLabel3_Click;
            pnlSearchPlaylists.Controls.Add(endLabel3);

        }

        private void endLabel3_Click(Object Sender, EventArgs e)
        {
            ViewAllResults viewAll = new ViewAllResults(this.musicPlayer, usersPlaylists, this.parent);
            viewAll.setPlaylists(playlists);
            viewAll.createPlaylistList(searchedFor);
            viewAll.Show();
        }

        private void goToArtist(object sender, EventArgs e)
        {
            LinkLabel theLabel = (LinkLabel)sender;
            String artist = theLabel.Text;

            pnlOptions.Visible = false;
            pnlPlaylists.Visible = false;

            SongModel songModel = new SongModel();
            List<Song> songsForArtist = songModel.getSongsByArtist(artist);

            //Set the parent to be the home page
            HomePage parent = (HomePage)this.Parent;

            //Call the method in parent to open artist window, passing data back
            parent.artistSelected(artist, songsForArtist);

        }

        public void resetSearch()
        {
            for (int i = 0; i < songLabelsA.Count; i++)
            {
                this.pnlSongs.Controls.Remove(songLabelsA[i]);
                this.pnlSongs.Controls.Remove(songLabelsB[i]);
                this.pnlSongs.Controls.Remove(songLabelsC[i]);
                this.pnlSongs.Controls.Remove(songLabelsD[i]);
            }

            for (int i = 0; i < artistLabel.Count; i++)
            {
                this.pnlArtists.Controls.Remove(artistLabel[i]);
            }

            for (int i = 0; i < playlistLabelName.Count; i++)
            {
                this.pnlSearchPlaylists.Controls.Remove(playlistLabelName[i]);
                this.pnlSearchPlaylists.Controls.Remove(playlistLabelOwner[i]);
            }

            songLabelsA.Clear();
            songLabelsB.Clear();
            songLabelsC.Clear();
            songLabelsD.Clear();

            artistLabel.Clear();

            playlistLabelName.Clear();
            playlistLabelOwner.Clear();

            this.pnlSongs.Controls.Remove(endLabel);
            this.pnlArtists.Controls.Remove(endLabel);
            this.pnlPlaylists.Controls.Remove(endLabel);

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

        public void setSongList(List<Song> songs)
        {
            this.songList = songs;
        }
        public void setArtistList(List<String> artists)
        {
            this.artists = artists;
        }

        public void setPlaylistList(List<Playlist> playlists)
        {
            this.playlists = playlists;
        }

        public void setCurrentUser(User u)
        {
            this.currentUser = u;
        }

        public User getCurrentUser()
        {
            return this.currentUser;
        }

        public void setUsersPlaylists(List<Playlist> lp)
        {
            this.usersPlaylists = lp;
        }

        public List<Playlist> getUsersPlaylists()
        {
            return this.usersPlaylists;
        }

        private void hoverEvent(object sender, System.EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            tmrOptionsDelay.Start();

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

        private void clickEvent(object sender, System.EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            selectedSong = id;

            pnlOptions.Visible = true;

        }

        private void lblSongsHeading_Click(object sender, EventArgs e)
        {
            tmrSlideSongs.Start();
        }

        private void tmrSlideSongs_Tick(object sender, EventArgs e)
        {
            if (!songsState)
            {
                if (pnlSongs.Height > 300)
                {
                    tmrSlideSongs.Stop();
                    songsState = true;
                }
                else
                {
                    pnlSongs.Height += 3;
                    pnlArtists.Top += 3;
                }
            }
            else
            {

                if (pnlSongs.Height < 142)
                {
                    tmrSlideSongs.Stop();
                    songsState = false;
                }
                else
                {
                    pnlSongs.Height -= 3;
                    pnlArtists.Top -= 3;
                }
            }
        }

        private void tmrSlideArtists_Tick(object sender, EventArgs e)
        {
            if (!artistState)
            {
                if (pnlArtists.Height > 300)
                {
                    tmrSlideArtists.Stop();
                    artistState = true;
                }
                else
                {
                    pnlArtists.Height += 3;
                }
            }
            else
            {

                if (pnlArtists.Height < 142)
                {
                    tmrSlideArtists.Stop();
                    artistState = false;
                }
                else
                {
                    pnlArtists.Height -= 3;
                }
            }
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

        //Method when clicking artist
        private void artistClick(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            String artist = artistLabel[id].Text;

            SongModel songModel = new SongModel();
            List<Song> songsForArtist = songModel.getSongsByArtist(artist);

            //Set the parent to be the home page
            HomePage parent = (HomePage)this.Parent;

            //Call the method in parent to open artist window, passing data back
            parent.artistSelected(artist, songsForArtist);

        }

        //Highlights blue over artist selection
        private void artistHover(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            artistLabel[id].BackColor = Color.DodgerBlue;
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

        //Double click event to play a playlist
        private void playPlaylist(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int index = int.Parse(theLabel.Tag.ToString());

            musicPlayer.setPlaylist(playlists[index], 0);
            musicPlayer.playCurrentSong();

        }

        #region Event Handlers for Making labels light up and stuff
        private void lblArtists_Click(object sender, EventArgs e)
        {
            tmrSlideArtists.Start();
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
            tmrPlaylistDelay.Start();
            lblAddToPlaylist.BackColor = Color.FromArgb(40, 40, 40);
        }

        /// <summary>
        /// when the mouse enters the playlist panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlPlaylists_MouseEnter(object sender, EventArgs e)
        {
            pnlPlaylists.Visible = true;
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
        /// when the mouse leaves the playlist panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlPlaylists_MouseLeave(object sender, EventArgs e)
        {
            if (!pnlPlaylists.Bounds.Contains(PointToClient(Control.MousePosition)))
            {
                pnlPlaylists.Visible = false;
            }
        }

        /// <summary>
        /// when the mouse leaves the option panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlOptions_MouseLeave(object sender, EventArgs e)
        {
            tmrOptionsDelay.Start();
        }

        /// <summary>
        /// controls when the options thing disappears
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrOptionsDelay_Tick(object sender, EventArgs e)
        {
            if (!pnlPlaylists.Bounds.Contains(PointToClient(Control.MousePosition)) && !pnlOptions.Bounds.Contains(PointToClient(Control.MousePosition)))
            {
                pnlOptions.Visible = false;

                selectedSong = -1;
                pnlPlaylists.Visible = false;
            }
            tmrOptionsDelay.Stop();
        }

        private void goToPlaylist(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int index = int.Parse(theLabel.Tag.ToString());
            String playlistName = playlistLabelName[index].Text;
            String owner = playlistLabelOwner[index].Text;

            PlaylistModel playlistModel = new PlaylistModel();
            Playlist thePlaylist = playlistModel.getPlaylist(playlistName, owner);

            //Set the parent to be the home page
            HomePage parent = (HomePage)this.Parent;
            parent.showViewPlaylist(thePlaylist);

        }

        /// <summary>
        /// When the user clicks the play button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            pnlOptions.Visible = false;

        }
        #endregion
    }
}
