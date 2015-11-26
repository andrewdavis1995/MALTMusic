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
        // Class variables
        frmMusicPlayer musicPlayer;
        ViewPlaylist playlists;
        SearchResults searchResults;

        public User currentUser;

        /// <summary>
        /// Intialiser for home page
        /// </summary>
        public HomePage()
        {
            InitializeComponent();

            // Sets up form components
            musicPlayer = new frmMusicPlayer();
            playlists = new ViewPlaylist();
            searchResults = new SearchResults(musicPlayer);
        }

        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomePage_Load(object sender, EventArgs e)
        {
            lblFullName.Text = currentUser.getFirstName() + " " + currentUser.getLastName();
            IsMdiContainer = true;

            hideForms();

            loadMusicPlayer();
        }

        public void setCurrentUser(User theUser)
        {
            this.currentUser = theUser;
        }

        private void hideForms()
        {
            //Music player is never hidden
            playlists.Hide();
            searchResults.Hide();
        }

        /// <summary>
        /// Loads the music player into the application
        /// </summary>
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
            hideForms();

            String searchText = txtSearchBox.Text;
            SongModel songModel = new SongModel();

            List<Song> songs = new List<Song>();
            Thread songThread = new Thread(() => { songs = songModel.searchSongs(searchText); });
            songThread.Start();


            bool artists;
            Thread artistThread = new Thread(() => { artists = songModel.getAllArtists(); });
            //Thread artistThread = new Thread(() => { artists = songModel.populateDB(); });
            artistThread.Start();


            songThread.Join();
            artistThread.Join();


            loadSearchResults(songs, searchText);         

        }

        //Method to load search results window in child form
        private void loadSearchResults(List<Song> songs, String searchText)
        {

            searchResults.resetSearch();
            searchResults.setSongList(songs);

            searchResults.setCurrentUser(currentUser);
            List<Playlist> lp = new List<Playlist>();

            PlaylistModel pm = new PlaylistModel();

            lp = pm.getPlaylistsForUser(currentUser.getUsername());
            searchResults.setUsersPlaylists(lp);
            searchResults.createSongList(searchText);

            searchResults.TopLevel = false;
            searchResults.Parent = this;
            searchResults.FormBorderStyle = FormBorderStyle.None;
            searchResults.Show();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void picBoxPlaylist_Click(object sender, EventArgs e)
        {
            hideForms();

            playlists.currentUser = currentUser.getUsername();

            playlists.TopLevel = false;
            playlists.Parent = this;
            playlists.FormBorderStyle = FormBorderStyle.None;
            playlists.Show();
        }

    }
}
