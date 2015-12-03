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
        frmMusicPlayer musicPlayer = new frmMusicPlayer(new HomePage());
        List<Song> songList = new List<Song>();
        int selectedSong = -1;

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

            for (int i = songList.Count - 1; i > -1; i--) 
            {
                albumCovers[i].BringToFront();    
            }
            albumCovers[index].BringToFront();

        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            Playlist playlist = new Playlist();
            playlist.addSongs(songList[selectedSong]);

            musicPlayer.setPlaylist(playlist, 0);
            musicPlayer.playCurrentSong();
        }

        private void Recommendations_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicPlayer.stopSong();
        }

    }
}
