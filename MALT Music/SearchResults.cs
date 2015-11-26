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

namespace MALT_Music
{
    public partial class SearchResults : Form
    {
        public SearchResults()
        {
            InitializeComponent();
        }
        public SearchResults(frmMusicPlayer musicPlayer)
        {
            InitializeComponent();
            this.musicPlayer = musicPlayer;
        }

        frmMusicPlayer musicPlayer;
        int selectedSong;

        private List<Song> songList = new List<Song>();
        List<Label> songLabelsA = new List<Label>();
        List<Label> songLabelsB = new List<Label>();
        List<Label> songLabelsC = new List<Label>();
        List<Label> songLabelsD = new List<Label>();

        List<Label> playlistLabels = new List<Label>();

        User currentUser = new User();
        List <Playlist> usersPlaylists = new List<Playlist>();

        bool songsState = false;
        bool artistState = false;

        public void setSongList(List<Song> songs){
            this.songList = songs;
        }


        public void setCurrentUser(User u){
            this.currentUser = u;
        }

        public User getCurrentUser() {
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

            songLabelsA[id].BackColor = Color.DodgerBlue;
            songLabelsB[id].BackColor = Color.DodgerBlue;
            songLabelsC[id].BackColor = Color.DodgerBlue;
            songLabelsD[id].BackColor = Color.DodgerBlue;
        }

        private void leaveEvent(object sender, System.EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

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

        private void clickEvent(object sender, System.EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            selectedSong = id;
           
            songLabelsA[id].BackColor = Color.FromArgb(50, 255, 50);
            songLabelsB[id].BackColor = Color.FromArgb(50, 255, 50);
            songLabelsC[id].BackColor = Color.FromArgb(50, 255, 50);
            songLabelsD[id].BackColor = Color.FromArgb(50, 255, 50);

            pnlOptions.Visible = true;
            pnlOptions.Top = 200 + (id * 32);
            pnlPlaylists.Top = 200 + (id * 32);
            

        }


        public void createSongList(String searchText) {

            this.lblSearchedFor.Text = "Search Results for: '" + searchText + "':";

            int i = 0;
            while (i < 9 && i < this.songList.Count) {

                Label newLabelSongName = new Label();
                newLabelSongName.Text = songList[i].getTrackName();
                newLabelSongName.Size = new Size(306, 30);
                newLabelSongName.Location = new Point(0, (20 + (i*32)));
                newLabelSongName.TextAlign = ContentAlignment.MiddleLeft;
                newLabelSongName.ForeColor = Color.White;
                if (i % 2 == 0) { newLabelSongName.BackColor = Color.FromArgb(60, 60, 60); } else { newLabelSongName.BackColor = Color.FromArgb(90, 90, 90); }
                newLabelSongName.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabelSongName.Tag = i.ToString();
                newLabelSongName.Click += clickEvent;
                newLabelSongName.MouseEnter += hoverEvent;
                newLabelSongName.MouseLeave += leaveEvent;


                Label newLabelSongArtist = new Label();
                newLabelSongArtist.Text = songList[i].getArtist();
                newLabelSongArtist.Size = new Size(196, 30);
                newLabelSongArtist.Location = new Point(309, (20 + (i * 32)));
                newLabelSongArtist.TextAlign = ContentAlignment.MiddleLeft;
                newLabelSongArtist.ForeColor = Color.White;
                if (i % 2 == 0) { newLabelSongArtist.BackColor = Color.FromArgb(60, 60, 60); } else { newLabelSongArtist.BackColor = Color.FromArgb(90, 90, 90); }
                newLabelSongArtist.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabelSongArtist.Tag = i.ToString();

                newLabelSongArtist.Click += clickEvent;
                newLabelSongArtist.MouseEnter += hoverEvent;
                newLabelSongArtist.MouseLeave += leaveEvent;


                Label newLabelSongAlbum = new Label();
                newLabelSongAlbum.Text = songList[i].getAlbum();
                newLabelSongAlbum.Size = new Size(196, 30);
                newLabelSongAlbum.Location = new Point(508, (20 + (i * 32)));
                newLabelSongAlbum.TextAlign = ContentAlignment.MiddleLeft;
                newLabelSongAlbum.ForeColor = Color.White;
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



            Label endLabel = new Label();
            if (i >= songList.Count)
            {
                endLabel.Text = "No More Results";
            }
            else {
                int remaining = songList.Count - i;
                endLabel.Text = "(" + remaining + " other results)";
            }

            endLabel.Size = new Size(780, 30);
            endLabel.Location = new Point(0, (20 + (i * 32)));
            endLabel.TextAlign = ContentAlignment.MiddleCenter;
            endLabel.ForeColor = Color.White;
            endLabel.BackColor = Color.FromArgb(20, 20, 20);
            endLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            pnlSongs.Controls.Add(endLabel);

            addPlaylistLabels();


        }

        public void addPlaylistLabels() 
        {

            for(int i = 0; i < usersPlaylists.Count; i++)
            {
                Label newLabel = new Label();

                newLabel.Location = new Point(1, 1);
                newLabel.ForeColor = Color.White;
                newLabel.BackColor = Color.FromArgb(40, 40, 40);
                newLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabel.Tag = i.ToString();
                newLabel.Size = new Size(140, 26);
                newLabel.Text = usersPlaylists[i].getPlaylistName();
                newLabel.TextAlign = ContentAlignment.MiddleCenter;

                playlistLabels.Add(newLabel);
                pnlPlaylists.Controls.Add(playlistLabels[i]);
            } 
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
                }else
                {
                    pnlSongs.Height += 3;
                    pnlArtists.Top += 3;
                }
            }
            else {

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
            lblPlay.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void lblAddToPLaylist_Enter(object sender, EventArgs e)
        {
            lblAddToPlaylist.BackColor = Color.DodgerBlue;
            pnlPlaylists.Visible = true;
        }

        private void lblAddToPLaylist_Leave(object sender, EventArgs e)
        {
            lblAddToPlaylist.BackColor = Color.FromArgb(40, 40, 40);
            tmrPlaylistDelay.Start();
        }

        private void pnlPlaylists_MouseEnter(object sender, EventArgs e)
        {
            pnlPlaylists.Visible = true;
        }

        private void tmrPlaylistDelay_Tick(object sender, EventArgs e)
        {
            if (!pnlPlaylists.Bounds.Contains(PointToClient(Control.MousePosition)))
            {
                pnlPlaylists.Visible = false;
            }
            tmrPlaylistDelay.Stop();
        }

        private void pnlPlaylists_MouseLeave(object sender, EventArgs e)
        {
            if (!pnlPlaylists.Bounds.Contains(PointToClient(Control.MousePosition)))
            {
                pnlPlaylists.Visible = false;
            }
        }

        private void pnlOptions_MouseLeave(object sender, EventArgs e)
        {
            tmrOptionsDelay.Start();
        }

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

        private void lblPlay_Click(object sender, EventArgs e)
        {
            if (selectedSong > -1)
            {
                String filePath = songList[selectedSong].getFileLocation();
                //musicPlayer.setSongPath(@"" + filePath);
                musicPlayer.setSongPath(@"" + "../../tracks/Powerglove/Kids Songs/Test.mp3");
                musicPlayer.playCurrentSong();
            }

        }

    }
}
