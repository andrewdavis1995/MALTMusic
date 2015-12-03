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
    public partial class Recommendations : Form
    {

        List<PictureBox> albumCovers = new List<PictureBox>();

        public Recommendations()
        {
            InitializeComponent();
            createAlbums();
        }

        public void createAlbums() 
        {
            for (int i = 0; i < 5; i++) 
            {
                PictureBox picBox = new PictureBox();
                picBox.Size = new Size(150, 150);
                picBox.Location = new Point(40 + (i * 35), 50);
                picBox.BorderStyle = BorderStyle.FixedSingle;
                picBox.BackgroundImage = Image.FromFile("../../tracks/Crowded House/Woodface/Woodface.jpg");
                picBox.BackgroundImageLayout = ImageLayout.Stretch;

                albumCovers.Add(picBox);
                this.Controls.Add(albumCovers[i]);
            }
        }

    }
}
