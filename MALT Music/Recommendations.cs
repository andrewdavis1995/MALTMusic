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
    public partial class Recommendations : Form
    {

        List<PictureBox> albumCovers = new List<PictureBox>();
        List<Song> songList = new List<Song>();

        public Recommendations()
        {
            InitializeComponent();
        }

        public void setSongs(List<Song> songs) 
        {
            this.songList = songs;
        }

        public void createAlbums() 
        {
 
            for (int i = 0; i < this.songList.Count; i++) 
            {
                PictureBox picBox = new PictureBox();
                picBox.Size = new Size(150, 150);
                picBox.Location = new Point(40 + (i * 35), 50);
                picBox.BorderStyle = BorderStyle.FixedSingle;
                picBox.MouseEnter += hoverEnter;
                picBox.Tag = i.ToString();
                picBox.BackgroundImage = Image.FromFile(songList[i].getImagePath());
                picBox.BackgroundImageLayout = ImageLayout.Stretch;

                albumCovers.Add(picBox);
                this.Controls.Add(albumCovers[i]);
            }
        }

        private void hoverEnter(Object sender, EventArgs e) 
        {
            PictureBox pic = (PictureBox)sender;
            int index = int.Parse(pic.Tag.ToString());

            for (int i = songList.Count - 1; i > -1; i--) 
            {
                albumCovers[i].BringToFront();    
            }
            albumCovers[index].BringToFront();

        }

    }
}
