using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MALT_Music.Models;
using MALT_Music.DataObjects;

namespace MALT_Music
{
    public partial class ViewUserPlaylists : Form
    {
        public String currentUser;

        public ViewUserPlaylists()
        {
            InitializeComponent();
            lblTitle.Text = "Playlists for User: " + this.currentUser;
        }

        private void ViewPlaylist_Load(object sender, EventArgs e)
        {
            PlaylistModel playlistModel = new PlaylistModel();
            List<Playlist> playlists = playlistModel.getPlaylistsForUser(this.currentUser);


            int count = 0;

            for (int i = 0; i < playlists.Count; i++) {
                Label newLabel = new Label();
                newLabel.Text = playlists[i].getPlaylistName();
                newLabel.Size = new Size(400, 30);
                newLabel.ForeColor = Color.White;
                if (count % 2 == 0) { newLabel.BackColor = Color.FromArgb(20, 20, 20); } else { newLabel.BackColor = Color.FromArgb(60, 60, 60); }
                newLabel.Location = new Point(290, 102 + (i * 30)); 
                newLabel.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Controls.Add(newLabel);
                count++;
            }

        }

    }
}
