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
        ViewUserPlaylists playlists;
        SearchResults searchResults;
        UserProfile profileScreen;
        ViewPlaylist viewPlaylist;
        ArtistView artistView = new ArtistView(new User(), null);

        public User currentUser;

        /// <summary>
        /// Intialiser for home page
        /// </summary>
        public HomePage()
        {
            InitializeComponent();

            // Sets up form components
            musicPlayer = new frmMusicPlayer(this);
            playlists = new ViewUserPlaylists();
            searchResults = new SearchResults(musicPlayer);
            profileScreen = new UserProfile();
            viewPlaylist = new ViewPlaylist();

        }

        public void updateCurrentSong(Song currentSong) {
            // send to Search, view playlist, view artist
        }


        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomePage_Load(object sender, EventArgs e)
        {
            //Display user's info on the panel
            lblFullName.Text = currentUser.getFirstName() + " " + currentUser.getLastName();
            loadProfilePicHome();

            //Set up tooltips
            setTooltips();

            //This form needs to contain all the sub-forms such as artist, playlist etc.
            IsMdiContainer = true;

            //Present so search box isn't automatically selected on startup
            this.ActiveControl = picBoxMagnifyingGlass;

            //Call loading/hiding methods
            hideForms();
            loadMusicPlayer();
        }

        //Method to set user
        public void setCurrentUser(User theUser)
        {
            this.currentUser = theUser;
        }

        //Method to add tooltips to home controls
        private void setTooltips()
        {
            new ToolTip().SetToolTip(lblFullName, "Click here to go to your profile");
            new ToolTip().SetToolTip(picBoxLogout, "Browse artists, songs and albums");
            new ToolTip().SetToolTip(picBoxPlaylist, "View your playlists");
            new ToolTip().SetToolTip(picBoxMALTLogo, "D3 is still a pass");
        }

        //Method to hide forms, thus avoiding issue of overlapping form displays
        private void hideForms()
        {
            //Music player is never hidden
            playlists.Hide();
            searchResults.Hide();
            profileScreen.Hide();
            artistView.Hide();
            playlists.Hide();
            viewPlaylist.Hide();

            //Show the loading placeholder
            picBoxBackground.Show();
        }

        //Method to open single playlist view
        public void showViewPlaylist(Playlist playlist)
        {

            hideForms();

            viewPlaylist = new ViewPlaylist(playlist, this.musicPlayer, this.currentUser);

            viewPlaylist.TopLevel = false;
            viewPlaylist.Parent = this;
            viewPlaylist.setupAlbumCovers(playlist.getSongs());
            viewPlaylist.setupLabels();

            viewPlaylist.FormBorderStyle = FormBorderStyle.None;
            viewPlaylist.Size = new Size(1130, 442);

            picBoxBackground.Hide();
            viewPlaylist.Show();
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

        //Method to load the search window
        private void btnSearch_Click(object sender, EventArgs e)
        {
            hideForms();

            //Get user search text
            String searchText = txtSearchBox.Text;

            //Create a new song model
            SongModel songModel = new SongModel();
            PlaylistModel playlistModel = new PlaylistModel();

            //Populate song list with songs that fit the criteria
            List<Song> songs = new List<Song>();
            Thread songThread = new Thread(() => { songs = songModel.searchSongs(searchText); });
            songThread.Start();

            //Populate artist list with artists that fir the criteria
            List<String> artists = new List<String>();
            Thread artistThread = new Thread(() => { artists = songModel.searchArtists(searchText.ToLower()); });
            artistThread.Start();

            //Populate artist list with artists that fir the criteria
            List<Playlist> playlists = new List<Playlist>();
            Thread playlistThread = new Thread(() => { playlists = playlistModel.searchPlaylists(searchText); });
            playlistThread.Start();

            //Join threads
            songThread.Join();
            artistThread.Join();
            playlistThread.Join();

            //Call method to load results window
            loadSearchResults(songs, artists, playlists, searchText);         

        }

        //Method to load search results window in child form
        private void loadSearchResults(List<Song> songs, List<String> artists, List<Playlist> playlists, String searchText)
        {
            //Clear previous search
            searchResults.resetSearch();

            //Set artist and song and playlists results from parameters
            searchResults.setSongList(songs);
            searchResults.setArtistList(artists);
            searchResults.setPlaylistList(playlists);

            //Set user's playlists
            searchResults.setCurrentUser(currentUser);

            PlaylistModel pm = new PlaylistModel();
            List<Playlist> lp = pm.getPlaylistsForUser(currentUser.getUsername());

            searchResults.setUsersPlaylists(lp);
            searchResults.createSongList(searchText);
            searchResults.createArtistList();
            searchResults.createPlaylistList();
            searchResults.addPlaylistLabels();

            picBoxBackground.Hide();

            searchResults.TopLevel = false;
            searchResults.Parent = this;
            searchResults.FormBorderStyle = FormBorderStyle.None;
            searchResults.Show();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Method to show playlist window
        private void picBoxPlaylist_Click(object sender, EventArgs e)
        {
            hideForms();


            PlaylistModel playlistModel = new PlaylistModel();
            List<Playlist> playlistList = playlistModel.getPlaylistsForUser(currentUser.getUsername());

            playlists.currentUser = currentUser.getUsername(); 
            playlists.TopLevel = false;
            playlists.Parent = this;
            playlists.resetLabels();
            playlists.createLabels(playlistList);
            playlists.FormBorderStyle = FormBorderStyle.None;
            
            picBoxBackground.Hide();

            playlists.Show();
        }

        //Method to go to user's profile page
        private void lblFullName_Click(object sender, EventArgs e)
        {
            hideForms();

            profileScreen.setUser(currentUser);
            profileScreen.TopLevel = false;
            profileScreen.Parent = this;
            profileScreen.setParent(this);
            profileScreen.FormBorderStyle = FormBorderStyle.None;

            picBoxBackground.Hide();

            profileScreen.Show();
        }

        //Method to show artist and their songs based on selection within SearchResults
        public void artistSelected(String name, List<Song> songs)
        {
            hideForms();

            artistView = new ArtistView(this.currentUser, this.musicPlayer);



            PlaylistModel pm = new PlaylistModel();
            List<Playlist> lp = pm.getPlaylistsForUser(currentUser.getUsername());
            artistView.setUsersPlaylists(lp);
            artistView.setupVariables(name, songs);
            artistView.createAlbums();

            artistView.TopLevel = false;
            artistView.Parent = this;
            artistView.FormBorderStyle = FormBorderStyle.None;

            picBoxBackground.Hide();

            artistView.Show();

        }

        //Method to load or change the user's profile picture on the home panel
        public void loadProfilePicHome()
        {
            //Get the image from the database
            PicModel getImg = new PicModel();
            Image target = getImg.getImage(currentUser.getUsername());

            //Set it to be the image inside picBoxProfPicThumb
            picBoxProfPicThumb.Image = target;

            if (target == null)
            {
                picBoxProfPicThumb.Image = Properties.Resources.iconprofile;
            }
        }

        //For when the user presses enter in the search box, call search method
        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }

        //Log out the user
        private void picBoxLogout_Click(object sender, EventArgs e)
        {
            musicPlayer.stopSong();
            Login newLogin = new Login();
            this.Hide();
            newLogin.ShowDialog();
            this.Dispose();
        }

    }
}
