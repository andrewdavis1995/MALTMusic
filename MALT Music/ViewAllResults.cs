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

namespace MALT_Music
{
    public partial class ViewAllResults : Form
    {
        public ViewAllResults()
        {
            InitializeComponent();
        }


        private List<Song> songList = new List<Song>();
        private List<Playlist> playlistList = new List<Playlist>();
        private List<String> artistList = new List<String>();

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
                //newLabelSongName.Click += clickEvent;
                //newLabelSongName.MouseEnter += hoverEvent;
                //newLabelSongName.MouseLeave += leaveEvent;


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

                //newLabelSongArtist.Click += clickEvent;
                //newLabelSongArtist.MouseEnter += hoverEvent;
                //newLabelSongArtist.MouseLeave += leaveEvent;
                //newLabelSongArtist.LinkClicked += goToArtist;


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

//                newLabelSongAlbum.Click += clickEvent;
 //               newLabelSongAlbum.MouseEnter += hoverEvent;
  //              newLabelSongAlbum.MouseLeave += leaveEvent;


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

                //newLabelSongYear.Click += clickEvent;
                //newLabelSongYear.MouseEnter += hoverEvent;
                //newLabelSongYear.MouseLeave += leaveEvent;

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
                //newArtist.Click += artistClick;
                //newArtist.MouseLeave += artistLeave;
                //newArtist.MouseEnter += artistHover;


                artistLabel.Add(newArtist);
                this.Controls.Add(artistLabel[i]);

                i++;
            }
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
                // newPlaylist.DoubleClick += playPlaylist;
                
                if (i % 2 == 0) { newPlaylist.BackColor = Color.FromArgb(60, 60, 60); } else { newPlaylist.BackColor = Color.FromArgb(90, 90, 90); }
                newPlaylist.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                
                //newPlaylist.Tag = i.ToString();
                //newPlaylist.Click += goToPlaylist;
                /*newPlaylist.MouseLeave += artistLeave;
                newPlaylist.MouseEnter += artistHover;*/

                playlistLabelName.Add(newPlaylist);
                this.Controls.Add(playlistLabelName[i]);

                Label newPlaylistOwner = new Label();
                newPlaylistOwner.Text = playlistList[i].getOwner();
                newPlaylistOwner.Size = new Size(370, 30);
                newPlaylistOwner.Location = new Point(410, (20 + (i * 32)));
                newPlaylistOwner.TextAlign = ContentAlignment.MiddleLeft;
                newPlaylistOwner.ForeColor = Color.White;
                newPlaylistOwner.UseMnemonic = false;
                //newPlaylistOwner.DoubleClick += playPlaylist;
                if (i % 2 == 0) { newPlaylistOwner.BackColor = Color.FromArgb(60, 60, 60); } else { newPlaylistOwner.BackColor = Color.FromArgb(90, 90, 90); }
                newPlaylistOwner.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                
                //newPlaylistOwner.Tag = i.ToString();
                //newPlaylistOwner.Click += goToPlaylist;
                /*newPlayistOwner.MouseLeave += artistLeave;
                newPlayistOwner.MouseEnter += artistHover;*/

                playlistLabelOwner.Add(newPlaylistOwner);
                this.Controls.Add(playlistLabelOwner[i]);

                i++;
            }
        }

    }
}
