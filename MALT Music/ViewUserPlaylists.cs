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
        List<Label> labelList = new List<Label>();
        List<PictureBox> deleteLabels = new List<PictureBox>();

        public ViewUserPlaylists()
        {
            InitializeComponent();
            lblTitle.Text = "Playlists for User: " + this.currentUser;
        }

        
        public void resetLabels() 
        {
            for (int i = 0; i < labelList.Count; i++) 
            {
                this.Controls.Remove(labelList[i]);
                this.Controls.Remove(deleteLabels[i]);
            }

            labelList.Clear();
            deleteLabels.Clear();

        }

        public void createLabels(List<Playlist> p) {

            this.playlists = p;

            int count = 0;

            for (int i = 0; i < playlists.Count; i++)
            {
                Label newLabel = new Label();
                newLabel.Text = playlists[i].getPlaylistName();
                newLabel.Size = new Size(400, 30);
                newLabel.ForeColor = Color.White;
                newLabel.Tag = i.ToString();
                newLabel.Click += playlistSelected;

                if (!playlists[i].getPlaylistName().Contains("$temp$"))
                {
                    if (i % 2 == 0) { newLabel.BackColor = Color.FromArgb(60, 60, 60); } else { newLabel.BackColor = Color.FromArgb(90, 90, 90); }
                }
                else
                {
                    newLabel.BackColor = Color.MidnightBlue;
                    newLabel.Text = playlists[i].getPlaylistName().Substring(6);
                }

                newLabel.Location = new Point(290, 120 + (i * 30));
                newLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                labelList.Add(newLabel);

                this.Controls.Add(labelList[i]);


                PictureBox theDeleteLabel = new PictureBox();
                theDeleteLabel.Size = new Size(20, 20);
                theDeleteLabel.Tag = i.ToString();
                theDeleteLabel.Click += deletePlaylist;
                theDeleteLabel.Location = new Point(700, 125 + (i * 30));
                theDeleteLabel.BackgroundImage = Properties.Resources.removeFromPlaylist;
                theDeleteLabel.BackgroundImageLayout = ImageLayout.Stretch;

                deleteLabels.Add(theDeleteLabel);

                this.Controls.Add(deleteLabels[i]);

                count++;
            }
        }

        private void deletePlaylist(object sender, EventArgs e) 
        {
            PictureBox p = (PictureBox)sender;
            int index = int.Parse(p.Tag.ToString());

            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete playlist: " + labelList[index].Text + "?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // do, do delete
                PlaylistModel playlistModel = new PlaylistModel();
                playlistModel.deletePlaylist(this.playlists[index]);

                this.Controls.Remove(labelList[index]);
                labelList.RemoveAt(index);
                this.Controls.Remove(deleteLabels[index]);
                deleteLabels.RemoveAt(index);
                this.playlists.RemoveAt(index);

                int count = this.playlists.Count - 1;
                resetLabels();
                createLabels(this.playlists);

            }
            // do repositioning/resetting stuff
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
            playlists.Add(newPlaylist);

            #region createLabel
            int count = playlists.Count - 1;
            Label newLabel = new Label();
            newLabel.Text = newPlaylist.getPlaylistName();
            newLabel.Size = new Size(400, 30);
            newLabel.ForeColor = Color.White;
            newLabel.Tag = count.ToString();
            newLabel.Click += playlistSelected;
            if (count % 2 == 0) { newLabel.BackColor = Color.FromArgb(20, 20, 20); } else { newLabel.BackColor = Color.FromArgb(60, 60, 60); }
            newLabel.Location = new Point(290, 120 + (count * 30));
            newLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            labelList.Add(newLabel);

            this.Controls.Add(labelList[count]);

            #endregion
            
            #region createLabelRemove
            PictureBox deleteButton = new PictureBox();
            deleteButton.Size = new Size(20, 20);
            deleteButton.Tag = count.ToString();
            deleteButton.Click += deletePlaylist;
            deleteButton.BackgroundImage = Properties.Resources.removeFromPlaylist;
            deleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            deleteButton.Location = new Point(700, 125 + (count * 30));

            deleteLabels.Add(deleteButton);

            this.Controls.Add(deleteLabels[count]);

            #endregion 

        }

    }
}
