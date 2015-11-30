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
        List<Playlist> playlists;

        public ViewUserPlaylists()
        {
            InitializeComponent();
            lblTitle.Text = "Playlists for User: " + this.currentUser;
        }

        public void createLabels() {
            PlaylistModel playlistModel = new PlaylistModel();
            playlists = playlistModel.getPlaylistsForUser(this.currentUser);

            int count = 0;

            for (int i = 0; i < playlists.Count; i++)
            {
                Label newLabel = new Label();
                newLabel.Text = playlists[i].getPlaylistName();
                newLabel.Size = new Size(400, 30);
                newLabel.ForeColor = Color.White;
                newLabel.Tag = i.ToString();
                newLabel.Click += playlistSelected;
                if (count % 2 == 0) { newLabel.BackColor = Color.FromArgb(20, 20, 20); } else { newLabel.BackColor = Color.FromArgb(60, 60, 60); }
                newLabel.Location = new Point(290, 120 + (i * 30));
                newLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Controls.Add(newLabel);
                count++;
            }
        }

        private void playlistSelected(Object sender, EventArgs e) 
        {

            Label theLabel = (Label)sender;
            int index = int.Parse(theLabel.Tag.ToString());

            //Set the parent to be the home page
            HomePage parent = (HomePage)this.Parent;
            parent.showViewPlaylist(playlists[index]);

            //ViewPlaylist viewPlaylist = new ViewPlaylist(playlists[index]);
            //viewPlaylist.Show();
        }

        private void cmdCreatePlaylist_Click(object sender, EventArgs e)
        {
            String playlist = Microsoft.VisualBasic.Interaction.InputBox("Playlist Name: ", "Playlist Name");
            Guid id = Guid.NewGuid();
            List<Song> songs = new List<Song>();

            Playlist newPlaylist = new Playlist(playlist, id, this.currentUser, songs);

            PlaylistModel playlistModel = new PlaylistModel();
            playlistModel.createPlaylist(newPlaylist);
        }

    }
}
