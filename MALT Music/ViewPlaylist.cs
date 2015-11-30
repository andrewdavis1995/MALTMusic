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

namespace MALT_Music
{
    public partial class ViewPlaylist : Form
    {

        List<Label> positionLabels = new List<Label>();
        List<Label> songLabels = new List<Label>();
        List<Label> artistLabels = new List<Label>();
        Playlist thePlaylist;
        int selectedSong = 0;

        List<Song> songs;

        frmMusicPlayer musicPlayer;


        public ViewPlaylist(Playlist playlist, frmMusicPlayer music)
        {
            InitializeComponent();
            this.musicPlayer = music;
            this.thePlaylist = playlist;
            lblPlaylistName.Text = thePlaylist.getPlaylistName();
            lblOwner.Text = thePlaylist.getOwner();

            List<Song> songs = thePlaylist.getSongs();
            int numSongs = thePlaylist.getSongs().Count;

            lblNumSongs.Text = numSongs.ToString();

            if (numSongs == 1) { lblNumSongs.Text += " song"; } else { lblNumSongs.Text += " songs"; }

            int totalLength = 0;
            for (int i = 0; i < songs.Count; i++) 
            {
                totalLength += songs[i].getLength();
            }

            int hours = totalLength / 3600;
            int minutes = (totalLength - hours * 3600) / 60;
            int seconds = totalLength - (hours * 3600) - (minutes * 60);

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

            lblTime.Text = output;

        }
        public ViewPlaylist()
        {
            InitializeComponent();
        }


        private void setSelected(Object sender, EventArgs e) {
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

            }

        }

        public void setupAlbumCovers()
        {
            List<String> taken = new List<String>();

            List<Song> songs = thePlaylist.getSongs();

            int i = 0;

            while (i < songs.Count && taken.Count < 4) 
            {
                if (!taken.Contains(songs[i].getAlbum() + songs[i].getArtist()))
                {
                    if (taken.Count == 0)
                    {
                        coverImage1.BackgroundImage = Image.FromFile(@"../../tracks/" + songs[i].getArtist() + "/" + songs[i].getAlbum() + "/" + songs[i].getAlbum() + ".jpg");
                    }
                    else if (taken.Count == 1)
                    {
                        coverImage2.BackgroundImage = Image.FromFile(@"../../tracks/" + songs[i].getArtist() + "/" + songs[i].getAlbum() + "/" + songs[i].getAlbum() + ".jpg");
                    }
                    else if (taken.Count == 2)
                    {
                        coverImage3.BackgroundImage = Image.FromFile(@"../../tracks/" + songs[i].getArtist() + "/" + songs[i].getAlbum() + "/" + songs[i].getAlbum() + ".jpg");
                    }
                    else
                    {
                        coverImage4.BackgroundImage = Image.FromFile(@"../../tracks/" + songs[i].getArtist() + "/" + songs[i].getAlbum() + "/" + songs[i].getAlbum() + ".jpg");
                    }

                    taken.Add(songs[i].getAlbum() + songs[i].getArtist());
                }

                i++;

            }
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
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

            if (toAdd.getTrackName() != null && toAdd.getTrackName() != "")
            {
                String filePath = toAdd.getFileLocation();
                musicPlayer.stopSong();
                String imagePath = "../../tracks/" + toAdd.getArtist() + "/" + toAdd.getAlbum() + "/" + toAdd.getAlbum() + ".jpg";
                musicPlayer.setSongPath(@"" + filePath, imagePath);
                musicPlayer.playCurrentSong();
            }

            pnlOptions.Visible = false;
        }

    }
}
