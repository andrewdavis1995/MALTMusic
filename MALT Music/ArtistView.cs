using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MALT_Music.DataObjects;
using System.Windows.Forms;

namespace MALT_Music
{
    public partial class ArtistView : Form
    {
        private String artistName;
        private List<Song> songs;

        List<List<Label>> songLabelsName = new List<List<Label>>();
        List<List<Label>> songLabelsLength = new List<List<Label>>();


        public ArtistView()
        {
            InitializeComponent();
        }

        public void setupVariables(String artist, List<Song> songs)
        {
            this.songs = songs;
            this.artistName = artist;
            lblArtistName.Text = artist;
        }

        public void createAlbums()
        {
            List<Album> albums = sortIntoAlbums();

            for (int i = 0; i < albums.Count; i++) {

                List<Label> songList = new List<Label>();
                songLabelsName.Add(songList);
                List<Label> lengthList = new List<Label>();
                songLabelsLength.Add(lengthList);

                lblNumAlbums.Text = "Number of Albums: " + albums.Count;

                Label topLabel = new Label();
                topLabel.Text = albums[i].getName();
                topLabel.Left = 12;
                topLabel.ForeColor = Color.White;
                topLabel.Top = 120 + (i * 145);
                topLabel.Width = 400;
                topLabel.Height = 20;
                topLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                

                Panel pnlOuter = new Panel();
                pnlOuter.Size = new Size(858, 100);
                pnlOuter.Location = new Point(12, 142+(i*145));
                pnlOuter.BackColor = Color.FromArgb(20, 20, 20);

                this.Controls.Add(pnlOuter);
                this.Controls.Add(topLabel);


                Panel pnlInner = new Panel();
                pnlInner.Size = new Size(693, 100);
                pnlInner.Location = new Point(110, 0);
                pnlInner.BackColor = Color.FromArgb(20, 20, 20);
                pnlInner.AutoScroll = true;

                PictureBox albumCover = new PictureBox();
                albumCover.Size = new Size(100, 100);
                albumCover.Location = new Point(0, 0);
                albumCover.BackColor = Color.Red;

                pnlOuter.Controls.Add(pnlInner);
                pnlOuter.Controls.Add(albumCover);

                // loop through each song in album -> add 2 labels for each - Song Title and Length (convert length to mm:ss)
                // store the labels as a global 2-D Array - e.g. trackLabel[i][j] where i is the album index and j is the track index
                // e.g. if i1 = i2 then the two tracks are in the same album
                List<Song> songs = albums[i].getSongs();

                for (int j = 0; j < songs.Count; j++) 
                {
                    String songName = songs[j].getTrackName();
                    int length = songs[j].getLength();

                    TimeSpan totalLength = TimeSpan.FromSeconds(length);
                    String lengthOutput = totalLength.ToString("mm':'ss");

                    #region songName Label

                    Label theSongLabel = new Label();

                    theSongLabel.Text = songName;
                    theSongLabel.Size = new Size(543, 30);
                    theSongLabel.Location = new Point(0, 0 + (33 * j));
                    theSongLabel.ForeColor = Color.FromArgb(205, 205, 205);
                    theSongLabel.TextAlign = ContentAlignment.MiddleLeft;
                    theSongLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    if (j % 2 == 0)
                    {
                        theSongLabel.BackColor = Color.FromArgb(60, 60, 60);
                    }
                    else
                    {
                        theSongLabel.BackColor = Color.FromArgb(20, 20, 20);
                    }
                    #endregion


                    #region songLength Label

                    Label theLengthLabel = new Label();
                    theLengthLabel.Text = lengthOutput;
                    theLengthLabel.Size = new Size(80, 30);
                    theLengthLabel.Location = new Point(549, 0 + (33 * j));
                    theLengthLabel.ForeColor = Color.FromArgb(205, 205, 205);
                    theLengthLabel.TextAlign = ContentAlignment.MiddleLeft;
                    theLengthLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    if (j % 2 == 0)
                    {
                        theLengthLabel.BackColor = Color.FromArgb(60, 60, 60);
                    }
                    else
                    {
                        theLengthLabel.BackColor = Color.FromArgb(20, 20, 20);
                    }
                    #endregion

                    songLabelsName[i].Add(theSongLabel);
                    songLabelsLength[i].Add(theLengthLabel);

                    pnlInner.Controls.Add(songLabelsName[i][j]);
                    pnlInner.Controls.Add(songLabelsLength[i][j]);

                }

            }

        }

        private List<Album> sortIntoAlbums() 
        {
            List<Album> albums = new List<Album>();

            for (int i = 0; i < songs.Count; i++)
            {

                bool add = true;

                for (int j = 0; j < albums.Count; j++)
                {
                    if (albums[j].compareName(songs[i].getAlbum()))
                    {
                        albums[j].addSong(songs[i]);
                        add = false;
                        break;
                    }
                }

                if (add)
                {
                    Album newAlbum = new Album(songs[i].getAlbum());
                    newAlbum.addSong(songs[i]);
                    albums.Add(newAlbum);
                }
            }

            return albums;

        }


    }
}
