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
    public partial class ViewPlaylist : Form
    {
        public String currentUser;

        public ViewPlaylist()
        {
            InitializeComponent();
            label1.Text = "Playlists for User: " + this.currentUser;
        }

        private void ViewPlaylist_Load(object sender, EventArgs e)
        {
            PlaylistModel playlistModel = new PlaylistModel();
            List<Playlist> playlists = playlistModel.getPlaylistsForUser(this.currentUser);

            //Playlist newPlaylist = new Playlist("bananana", new Guid(), "new user");
            //playlists.Add(newPlaylist);
            //newPlaylist = new Playlist("bananana", new Guid(), "andrewd95");
            //playlists.Add(newPlaylist);
            //newPlaylist = new Playlist("my playlist", new Guid(), "andrewd95");
            //playlists.Add(newPlaylist);
            //newPlaylist = new Playlist("my playlist2", new Guid(), "andrewd95");
            //playlists.Add(newPlaylist);

            int count = 0;

            for (int i = 0; i < playlists.Count; i++) {
                if (playlists[i].getOwner() == this.currentUser)
                {
                    Label newLabel = new Label();
                    newLabel.Text = playlists[i].getPlaylistName() + "---> " + playlists[i].getOwner();
                    newLabel.Size = new Size(400, 30);
                    newLabel.ForeColor = Color.White;
                    if (count % 2 == 0) { newLabel.BackColor = Color.Black; } else { newLabel.BackColor = Color.DarkGray; }
                    newLabel.Location = new Point(50, 40 + (i * 30)); 
                    newLabel.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.Controls.Add(newLabel);
                    count++;
                }
            }

        }

    }
}
