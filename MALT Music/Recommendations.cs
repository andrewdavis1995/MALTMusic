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
using MALT_Music.Models;
using System.Threading;

namespace MALT_Music
{
    public partial class Recommendations : Form
    {

        List<PictureBox> albumCovers = new List<PictureBox>();
        List<Song> songList = new List<Song>();
        frmMusicPlayer musicPlayer = new frmMusicPlayer(new HomePage());
        int selectedSong = 0;
        Playlist thePlaylist;
        ViewPlaylist parent;

        public Recommendations(ViewPlaylist VP)
        {
            InitializeComponent();
            this.parent = VP;
        }

        public void setSongs(List<Song> songs, Playlist playlist) 
        {
            this.songList = songs;
            this.thePlaylist = playlist;
            createLabels(0);
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
                picBox.Click += picBox_Click;
                picBox.BackgroundImage = Image.FromFile(songList[i].getImagePath());
                picBox.BackgroundImageLayout = ImageLayout.Stretch;

                albumCovers.Add(picBox);
                this.Controls.Add(albumCovers[i]);
            }
        }

        private void picBox_Click(Object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int index = int.Parse(pic.Tag.ToString());

            createLabels(index);
        }

        public void createLabels(int index) 
        {
            String songName = songList[index].getTrackName();
            String artist = songList[index].getArtist();
            String file_loc = songList[index].getImagePath();

            lblSelectedSongName.Text = songName;
            lblSelectedSongArtist.Text = artist;
            picSelectedArt.BackgroundImage = Image.FromFile(file_loc);
            selectedSong = index;
        }

        private void hoverEnter(Object sender, EventArgs e) 
        {
            PictureBox pic = (PictureBox)sender;
            int index = int.Parse(pic.Tag.ToString());

            moveToTop(index);

        }

        private void moveToTop(int index) 
        {
            for (int i = songList.Count - 1; i > -1; i--)
            {
                albumCovers[i].BringToFront();
            }
            albumCovers[index].BringToFront();
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            tmrPreview.Start();

            Playlist playlist = new Playlist();
            playlist.addSongs(songList[selectedSong]);

            musicPlayer.setPlaylist(playlist, 0);
            musicPlayer.playCurrentSong();
        }

        private void Recommendations_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicPlayer.stopSong();
        }

        private void tmrPreview_Tick(object sender, EventArgs e)
        {
            tmrPreview.Stop();
            musicPlayer.stopSong();
        }

        private void lblDiscard_Click(object sender, EventArgs e)
        {
            removeAlbum(selectedSong);
        }
        private void rearrangeAlbums(int index) 
        {
            for (int i = index; i < albumCovers.Count; i++) {
                albumCovers[i].Left -= 35;
                albumCovers[i].Tag = i.ToString();
            }
        }

        private void lblAddToPlaylist_Click(object sender, EventArgs e)
        {
            PlaylistModel playlistModel = new PlaylistModel();
            playlistModel.addSongToPlaylist(thePlaylist, songList[selectedSong]);

            parent.songAdded(songList[selectedSong]);

            removeAlbum(selectedSong);
        }

        private void removeAlbum(int index) 
        {
            this.Controls.Remove(albumCovers[selectedSong]);
            albumCovers.RemoveAt(selectedSong);

            songList.RemoveAt(selectedSong);

            if (songList.Count > 0)
            {
                createLabels(0);
                moveToTop(0);
                rearrangeAlbums(selectedSong);
                selectedSong = 0;
            }
            else
            {
                this.Close();
            }
        }

    }
}
