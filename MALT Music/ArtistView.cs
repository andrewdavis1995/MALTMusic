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
                Label topLabel = new Label();
                topLabel.Text = albums[i].getName();
                topLabel.Left = 12;
                topLabel.ForeColor = Color.White;
                topLabel.Top = 120 + (i * 145);
                topLabel.Width = 400;
                topLabel.Height = 20;

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
