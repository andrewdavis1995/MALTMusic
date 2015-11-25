using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Cassandra;
using MALT_Music.DataObjects;
using MALT_Music.Models;

namespace MALT_Music
{
    public partial class HomePage : Form
    {
        //Initialise other forms here
        frmMusicPlayer musicPlayer = new frmMusicPlayer();

        public User currentUser;


        public void setCurrentUser(User theUser) 
        {
            this.currentUser = theUser;
        }


        public HomePage()
        {
            InitializeComponent();
        }


        private void HomePage_Load(object sender, EventArgs e)
        {
            lblFullName.Text = currentUser.getFirstName() + " " + currentUser.getLastName();
            IsMdiContainer = true;

            hideForms();

            loadMusicPlayer();
        }

        private void hideForms()
        {
            musicPlayer.Hide();
        }

        private void loadMusicPlayer()
        {
            musicPlayer.TopLevel = false;
            musicPlayer.Parent = this;
            musicPlayer.Dock = DockStyle.Bottom;
            musicPlayer.FormBorderStyle = FormBorderStyle.None;
            musicPlayer.Show();
        }

        //When the user clicks on the search box, clear the placeholder text
        private void txtSearchBox_Enter(object sender, EventArgs e)
        {
            if (txtSearchBox.Text == "Search for songs, artists and albums...")
            {
                txtSearchBox.Text = "";
            }
        }

        //When the user clicks away from the search box
        private void txtSearchBox_Leave(object sender, EventArgs e)
        {
            if (txtSearchBox.Text == "")
            {
                txtSearchBox.Text = "Search for songs, artists and albums...";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String searchText = txtSearchBox.Text;
            SongModel songModel = new SongModel();

            List<Song> songs = new List<Song>();
            Thread songThread = new Thread(() => { songs = songModel.searchSongs(searchText); });
            songThread.Start();


            bool artists = false;
            Thread artistThread = new Thread(() => { artists = songModel.populateDB(); });
            artistThread.Start();
            MessageBox.Show(artists.ToString());


            songThread.Join();
            MessageBox.Show(songs.Count.ToString());
            artistThread.Join();



        }

    }
}
