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
    public partial class SearchResults : Form
    {

        private List<Song> songList = new List<Song>();

        bool songsState = false;
        bool artistState = false;

        public void setSongList(List<Song> songs){
            this.songList = songs;
        }

        public SearchResults()
        {
            InitializeComponent();
        }


        private void hoverEvent(object sender, System.EventArgs e) 
        {
            Label theLabel = (Label)sender;
            String theTag = theLabel.Tag.ToString();
        }


        public void createSongList() {
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
                newLabelSongName.Tag = songList[i].getTrackName() + "|" + songList[i].getArtist();

                newLabelSongName.MouseHover += hoverEvent;

                pnlSongs.Controls.Add(newLabelSongName);

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
    }
}
