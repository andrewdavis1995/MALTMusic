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
        UserProfile profileScreen;

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
            profileScreen = new UserProfile();

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

            //Present so search box isn't automatically selected on startup
            this.ActiveControl = picBoxMagnifyingGlass;

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
            profileScreen.Hide();
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
            musicPlayer.Size = new Size(1130, 195);
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


            List<String> artists = new List<String>();
            Thread artistThread = new Thread(() => { artists = songModel.searchArtists(searchText.ToLower()); });
            artistThread.Start();


            songThread.Join();
            artistThread.Join();


            loadSearchResults(songs, artists, searchText);         

        }

        //Method to load search results window in child form
        private void loadSearchResults(List<Song> songs, List<String> artists, String searchText)
        {

            searchResults.resetSearch();
            searchResults.setSongList(songs);
            searchResults.setArtistList(artists);

            searchResults.setCurrentUser(currentUser);
            List<Playlist> lp = new List<Playlist>();

            PlaylistModel pm = new PlaylistModel();

            lp = pm.getPlaylistsForUser(currentUser.getUsername());
            searchResults.setUsersPlaylists(lp);
            searchResults.createSongList(searchText);
            searchResults.createArtistList();
            searchResults.addPlaylistLabels();

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

        private void lblFullName_Click(object sender, EventArgs e)
        {
            hideForms();

            profileScreen.setUser(currentUser);
            profileScreen.TopLevel = false;
            profileScreen.Parent = this;
            profileScreen.FormBorderStyle = FormBorderStyle.None;
            profileScreen.Show();
        }

        public void artistSelected(String name, List<Song> songs)
        {
            hideForms();

            ArtistView artistView = new ArtistView();

            artistView.setupVariables(name, songs);
            artistView.createAlbums();

            artistView.TopLevel = false;
            artistView.Parent = this;
            artistView.FormBorderStyle = FormBorderStyle.None;
            artistView.Show();

            artistView.Show();
        }

    }
}
