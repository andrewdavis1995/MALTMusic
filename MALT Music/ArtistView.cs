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
        List<List<PictureBox>> upvoteButtons = new List<List<PictureBox>>();
        List<List<PictureBox>> downvoteButtons = new List<List<PictureBox>>();
        List<List<PictureBox>> voteDisplay = new List<List<PictureBox>>();


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
                List<PictureBox> upList = new List<PictureBox>();
                upvoteButtons.Add(upList);
                List<PictureBox> downList = new List<PictureBox>();
                downvoteButtons.Add(downList);
                List<PictureBox> voteList = new List<PictureBox>();
                voteDisplay.Add(voteList);

                lblNumAlbums.Text = "Number of Albums: " + albums.Count;

                Label topLabel = new Label();
                topLabel.Text = albums[i].getName();
                topLabel.Left = 242;
                topLabel.ForeColor = Color.White;
                topLabel.Top = 205 + (i * 145);
                topLabel.Width = 400;
                topLabel.Height = 20;
                topLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                

                Panel pnlOuter = new Panel();
                pnlOuter.Size = new Size(858, 100);
                pnlOuter.Location = new Point(242, 230+(i*145));
                pnlOuter.BackColor = Color.FromArgb(20, 20, 20);

                this.Controls.Add(pnlOuter);
                this.Controls.Add(topLabel);


                Panel pnlInner = new Panel();
                pnlInner.Size = new Size(693, 100);
                pnlInner.Location = new Point(100, 0);
                pnlInner.BackColor = Color.FromArgb(20, 20, 20);
                pnlInner.AutoScroll = true;

                PictureBox albumCover = new PictureBox();
                albumCover.Size = new Size(100, 100);
                albumCover.Location = new Point(0, 0);
                albumCover.BackColor = Color.FromArgb(20, 20, 20);
                albumCover.BackgroundImageLayout = ImageLayout.Stretch;
                try
                {
                    albumCover.BackgroundImage = Image.FromFile("../../tracks/" + albums[i].getSongs()[0].getArtist() + "/" + albums[i].getSongs()[0].getAlbum() + "/" + albums[i].getSongs()[0].getAlbum() + ".jpg");
                }
                catch(Exception){
                    albumCover.BackgroundImage = Properties.Resources.logo;
                }
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
                    theSongLabel.Size = new Size(483, 30);
                    theSongLabel.Location = new Point(0, 0 + (33 * j));
                    theSongLabel.Tag = i + "," + j;
                    theSongLabel.ForeColor = Color.FromArgb(205, 205, 205);
                    theSongLabel.TextAlign = ContentAlignment.MiddleLeft;
                    theSongLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    if (j % 2 == 0)
                    {
                        theSongLabel.BackColor = Color.FromArgb(60, 60, 60);
                    }
                    else
                    {
                        theSongLabel.BackColor = Color.FromArgb(40, 40, 40);
                    }
                    #endregion


                    #region songLength Label

                    Label theLengthLabel = new Label();
                    theLengthLabel.Text = lengthOutput;
                    theLengthLabel.Size = new Size(60, 30);
                    theLengthLabel.Location = new Point(486, 0 + (33 * j));
                    theLengthLabel.Tag = i + "," + j;
                    theLengthLabel.ForeColor = Color.FromArgb(205, 205, 205);
                    theLengthLabel.TextAlign = ContentAlignment.MiddleLeft;
                    theLengthLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    if (j % 2 == 0)
                    {
                        theLengthLabel.BackColor = Color.FromArgb(60, 60, 60);
                    }
                    else
                    {
                        theLengthLabel.BackColor = Color.FromArgb(40, 40, 40);
                    }
                    #endregion


                    PictureBox upvote = new PictureBox();
                    upvote.Size = new Size(22, 15);
                    upvote.Location = new Point(557, 0 + (33 * j));
                    upvote.BackgroundImage = Properties.Resources.upvote;
                    upvote.BackgroundImageLayout = ImageLayout.Stretch;
                    upvote.Tag = i + "," + j;

                    PictureBox downvote = new PictureBox();
                    downvote.Size = new Size(22, 15);
                    downvote.Location = new Point(557, 15 + (33 * j));
                    downvote.BackgroundImage = Properties.Resources.downvote;
                    downvote.BackgroundImageLayout = ImageLayout.Stretch;
                    downvote.Tag = i + "," + j;

                    PictureBox voteDisplayBox = new PictureBox();
                    voteDisplayBox.Size = new Size(100, 8);
                    voteDisplayBox.BackColor = Color.Gray;
                    voteDisplayBox.Location = new Point(586, 11 + (33 * j));
                    voteDisplayBox.Tag = i + "," + j;


                    int ups = 5;
                    int downs = 2;
                    float percent = (float)downs / ((float)ups + (float)downs) * 100;

                    int pbUnit = voteDisplayBox.Width / 100;

                    Bitmap bmp = new Bitmap(voteDisplayBox.Width, voteDisplayBox.Height);
                    Graphics g;
                    g = Graphics.FromImage(bmp);
                    g.Clear(Color.Green);
                    g.FillRectangle(Brushes.Red, new Rectangle(0, 0, (int)(percent * pbUnit), (int)voteDisplayBox.Height));

                    voteDisplayBox.Image = bmp;
                    g.Dispose();


                    songLabelsName[i].Add(theSongLabel);
                    songLabelsLength[i].Add(theLengthLabel);
                    upvoteButtons[i].Add(upvote);
                    downvoteButtons[i].Add(downvote);
                    voteDisplay[i].Add(voteDisplayBox);

                    pnlInner.Controls.Add(songLabelsName[i][j]);
                    pnlInner.Controls.Add(songLabelsLength[i][j]);
                    pnlInner.Controls.Add(upvoteButtons[i][j]);
                    pnlInner.Controls.Add(downvoteButtons[i][j]);
                    pnlInner.Controls.Add(voteDisplay[i][j]);
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
