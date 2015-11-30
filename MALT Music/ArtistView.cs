using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MALT_Music.DataObjects;
using System.Windows.Forms;
using MALT_Music.Models;

namespace MALT_Music
{
    public partial class ArtistView : Form
    {

        private User currentUser;

        private String artistName;
        private List<Song> songs;

        String selectedSong;

        List<List<Label>> songLabelsName = new List<List<Label>>();
        List<List<Label>> songLabelsLength = new List<List<Label>>();
        List<List<PictureBox>> upvoteButtons = new List<List<PictureBox>>();
        List<List<PictureBox>> downvoteButtons = new List<List<PictureBox>>();
        List<List<PictureBox>> voteDisplay = new List<List<PictureBox>>();

        frmMusicPlayer musicPlayer;

        List<Label> playlistLabels = new List<Label>();
        List<Playlist> usersPlaylists = new List<Playlist>();

        VoteModel voteModel = new VoteModel();
        List<UserVote> votes;


        public ArtistView(User currentUser, frmMusicPlayer mscPl)
        {
            this.currentUser = currentUser;
            this.musicPlayer = mscPl;
            InitializeComponent();
        }

        public void setupVariables(String artist, List<Song> songs)
        {
            this.songs = songs;
            this.artistName = artist;
            lblArtistName.Text = artist;
            votes = voteModel.getVotesByUser(this.currentUser.getUsername());

            addPlaylistLabels();
        }

        public void setUsersPlaylists(List<Playlist> lp)
        {
            this.usersPlaylists = lp;
        }

        public void addPlaylistLabels()
        {
            if (usersPlaylists.Count > 0)
            {
                for (int i = 0; i < usersPlaylists.Count; i++)
                {
                    Label newLabel = new Label();

                    newLabel.Location = new Point(1, 1 + (i * 29));
                    newLabel.ForeColor = Color.White;
                    newLabel.BackColor = Color.FromArgb(40, 40, 40);
                    newLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newLabel.Tag = i.ToString();
                    newLabel.Size = new Size(140, 26);
                    newLabel.Text = usersPlaylists[i].getPlaylistName();
                    newLabel.TextAlign = ContentAlignment.MiddleCenter;
                    newLabel.Click += addSongToPlaylist;
                    newLabel.MouseEnter += playlistHover;
                    newLabel.MouseLeave += playlistLeave;

                    playlistLabels.Add(newLabel);
                    pnlPlaylists.Controls.Add(playlistLabels[i]);
                }
            }
            else
            {
                Label newLabel = new Label();

                newLabel.Location = new Point(1, 1);
                newLabel.ForeColor = Color.Gray;
                newLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLabel.Size = new Size(140, 50);
                newLabel.Text = "You currently have no playlists";
                newLabel.TextAlign = ContentAlignment.MiddleCenter;

                pnlPlaylists.Controls.Add(newLabel);
            }
        }

        public void createAlbums()
        {
            List<Album> albums = sortIntoAlbums();

            for (int i = 0; i < albums.Count; i++) {

                List<Label> songList = new List<Label>();
                songLabelsName.Add(songList);
                List<Label> lengthList = new List<Label>();
                songLabelsLength.Add(lengthList);
                List<PictureBox> upList = new List<PictureBox>();
                upvoteButtons.Add(upList);
                List<PictureBox> downList = new List<PictureBox>();
                downvoteButtons.Add(downList);
                List<PictureBox> voteList = new List<PictureBox>();
                voteDisplay.Add(voteList);

                lblNumAlbums.Text = "Number of Albums: " + albums.Count;

                Label topLabel = new Label();
                topLabel.Text = albums[i].getName();
                topLabel.Left = 242;
                topLabel.ForeColor = Color.White;
                topLabel.Top = 205 + (i * 145);
                topLabel.Width = 400;
                topLabel.Height = 20;
                topLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                

                Panel pnlOuter = new Panel();
                pnlOuter.Size = new Size(858, 100);
                pnlOuter.Location = new Point(242, 230+(i*145));
                pnlOuter.BackColor = Color.FromArgb(20, 20, 20);

                this.Controls.Add(pnlOuter);
                this.Controls.Add(topLabel);


                Panel pnlInner = new Panel();
                pnlInner.Size = new Size(693, 100);
                pnlInner.Location = new Point(100, 0);
                pnlInner.BackColor = Color.FromArgb(20, 20, 20);
                pnlInner.AutoScroll = true;

                PictureBox albumCover = new PictureBox();
                albumCover.Size = new Size(100, 100);
                albumCover.Location = new Point(0, 0);
                albumCover.BackColor = Color.FromArgb(20, 20, 20);
                albumCover.BackgroundImageLayout = ImageLayout.Stretch;
                try
                {
                    albumCover.BackgroundImage = Image.FromFile("../../tracks/" + albums[i].getSongs()[0].getArtist() + "/" + albums[i].getSongs()[0].getAlbum() + "/" + albums[i].getSongs()[0].getAlbum() + ".jpg");
                }
                catch(Exception){
                    albumCover.BackgroundImage = Properties.Resources.logo;
                }
                pnlOuter.Controls.Add(pnlInner);
                pnlOuter.Controls.Add(albumCover);

                // loop through each song in album -> add 2 labels for each - Song Title and Length (convert length to mm:ss)
                // store the labels as a global 2-D Array - e.g. trackLabel[i][j] where i is the album index and j is the track index
                // e.g. if i1 = i2 then the two tracks are in the same album
                List<Song> songs = albums[i].getSongs();

                for (int j = 0; j < songs.Count; j++) 
                {
                    String songName = songs[j].getTrackName();
                    int length = songs[j].getLength();

                    TimeSpan totalLength = TimeSpan.FromSeconds(length);
                    String lengthOutput = totalLength.ToString("mm':'ss");

                    #region songName Label

                    Label theSongLabel = new Label();

                    theSongLabel.Text = songName;
                    theSongLabel.Size = new Size(483, 30);
                    theSongLabel.Location = new Point(0, 0 + (33 * j));
                    theSongLabel.Tag = i + "," + j;
                    theSongLabel.Click += clickEvent;
                    theSongLabel.ForeColor = Color.FromArgb(205, 205, 205);
                    theSongLabel.TextAlign = ContentAlignment.MiddleLeft;
                    theSongLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    if (j % 2 == 0)
                    {
                        theSongLabel.BackColor = Color.FromArgb(60, 60, 60);
                    }
                    else
                    {
                        theSongLabel.BackColor = Color.FromArgb(40, 40, 40);
                    }
                    #endregion
                    
                    #region songLength Label

                    Label theLengthLabel = new Label();
                    theLengthLabel.Text = lengthOutput;
                    theLengthLabel.Size = new Size(60, 30);
                    theLengthLabel.Location = new Point(486, 0 + (33 * j));
                    theLengthLabel.Tag = i + "," + j;
                    theLengthLabel.Click += clickEvent;
                    theLengthLabel.ForeColor = Color.FromArgb(205, 205, 205);
                    theLengthLabel.TextAlign = ContentAlignment.MiddleLeft;
                    theLengthLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    if (j % 2 == 0)
                    {
                        theLengthLabel.BackColor = Color.FromArgb(60, 60, 60);
                    }
                    else
                    {
                        theLengthLabel.BackColor = Color.FromArgb(40, 40, 40);
                    }
                    #endregion

                    #region vote stuff

                    PictureBox upvote = new PictureBox();
                    upvote.Size = new Size(22, 15);
                    upvote.Location = new Point(557, 0 + (33 * j));

                  
                    upvote.BackgroundImageLayout = ImageLayout.Stretch;
                    upvote.Tag = i + "," + j;
                    upvote.Click += doUpvote;

                    PictureBox downvote = new PictureBox();
                    downvote.Size = new Size(22, 15);
                    downvote.Location = new Point(557, 15 + (33 * j));
                    downvote.BackgroundImage = Properties.Resources.downvote;
                    downvote.BackgroundImageLayout = ImageLayout.Stretch;
                    downvote.Tag = i + "," + j;
                    downvote.Click += doDownvote;


                    for (int k = 0; k < votes.Count; k++)
                    {
                        if (songs[j].getSongID() == votes[k].getID())
                        {
                            if (votes[j].getHowVoted() == 1)
                            {
                                upvote.BackgroundImage = Properties.Resources.upvoted;
                                downvote.BackgroundImage = Properties.Resources.downvote;
                            }
                            else
                            {
                                upvote.BackgroundImage = Properties.Resources.upvote;
                                downvote.BackgroundImage = Properties.Resources.downvoted;
                            }
                            break;
                        }
                        upvote.BackgroundImage = Properties.Resources.upvote;
                        downvote.BackgroundImage = Properties.Resources.downvote;
                    }


                    PictureBox voteDisplayBox = new PictureBox();
                    voteDisplayBox.Size = new Size(100, 8);
                    voteDisplayBox.BackColor = Color.Gray;
                    voteDisplayBox.Location = new Point(586, 11 + (33 * j));
                    voteDisplayBox.Tag = i + "," + j;

                    voteDisplayBox = createVotePercentage(voteDisplayBox, j);
                    
                    #endregion

                    songLabelsName[i].Add(theSongLabel);
                    songLabelsLength[i].Add(theLengthLabel);
                    upvoteButtons[i].Add(upvote);
                    downvoteButtons[i].Add(downvote);
                    voteDisplay[i].Add(voteDisplayBox);

                    pnlInner.Controls.Add(songLabelsName[i][j]);
                    pnlInner.Controls.Add(songLabelsLength[i][j]);
                    pnlInner.Controls.Add(upvoteButtons[i][j]);
                    pnlInner.Controls.Add(downvoteButtons[i][j]);
                    pnlInner.Controls.Add(voteDisplay[i][j]);
                }

            }

        }

        private PictureBox createVotePercentage(PictureBox voteDisplayBox, int j) 
        {
            VoteModel vm = new VoteModel();
            Vote vote = vm.getVotesForTrack(songs[j].getSongID());

            int ups = vote.getUpVotes();
            int downs = vote.getDownVotes();
            float percent = (float)downs / ((float)ups + (float)downs) * 100;

            if (!float.IsNaN(percent))
            {
                // Do the popularity label thing here
                // **********************************
                

                int pbUnit = voteDisplayBox.Width / 100;

                Bitmap bmp = new Bitmap(voteDisplayBox.Width, voteDisplayBox.Height);
                Graphics g;
                g = Graphics.FromImage(bmp);
                g.Clear(Color.Green);
                g.FillRectangle(Brushes.Red, new Rectangle(0, 0, (int)(percent * pbUnit), (int)voteDisplayBox.Height));

                voteDisplayBox.Image = bmp;
                g.Dispose();
            }
            else 
            {
                voteDisplayBox.BackColor = Color.Gray;
            }

            return voteDisplayBox;

        }

        private List<Album> sortIntoAlbums() 
        {
            List<Album> albums = new List<Album>();

            for (int i = 0; i < songs.Count; i++)
            {

                bool add = true;

                for (int j = 0; j < albums.Count; j++)
                {
                    if (albums[j].compareName(songs[i].getAlbum()))
                    {
                        albums[j].addSong(songs[i]);
                        add = false;
                        break;
                    }
                }

                if (add)
                {
                    Album newAlbum = new Album(songs[i].getAlbum());
                    newAlbum.addSong(songs[i]);
                    albums.Add(newAlbum);
                }
            }

            return albums;

        }

        private void playlistHover(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            playlistLabels[id].BackColor = Color.DodgerBlue;

        }
        private void doUpvote(object sender, EventArgs e)
        {
            PictureBox theLabel = (PictureBox)sender;
            String[] tag = theLabel.Tag.ToString().Split(',');

            int x = int.Parse(tag[0]);
            int y = int.Parse(tag[1]);

            String songName = songLabelsName[x][y].Text;

            upvoteButtons[x][y].BackgroundImage = Properties.Resources.upvoted;

            Guid songId = new Guid();
            int index = -1;

            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i].getTrackName().Equals(songName))
                {
                    songId = songs[i].getSongID();
                    index = i;
                    break;
                }
            }

            if (index > -1) 
            {
                VoteModel vm = new VoteModel();
                if (upvoteButtons[x][y].BackgroundImage.Equals(Properties.Resources.upvoted))
                {
                    vm.removeAVote(this.currentUser.getUsername(), songs[index].getSongID(), 1);
                }
                else
                {
                    vm.doUpVote(songId, currentUser.getUsername());
                }

                createVotePercentage(voteDisplay[x][y], index);
            }
        }

        private void doDownvote(object sender, EventArgs e)
        {
            // Get the tag for which button was clicked
            PictureBox theLabel = (PictureBox)sender;
            String[] tag = theLabel.Tag.ToString().Split(',');

            // Convert to coordinates
            int x = int.Parse(tag[0]);
            int y = int.Parse(tag[1]);

            // Get the song name
            String songName = songLabelsName[x][y].Text;

            // Set image background
            downvoteButtons[x][y].BackgroundImage = Properties.Resources.downvoted;

            Guid songId = new Guid();
            int index = -1;

            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i].getTrackName().Equals(songName))
                {
                    songId = songs[i].getSongID();
                    index = i;
                    break;
                }
            }

            if (index > -1)
            {
                VoteModel vm = new VoteModel();
                if (downvoteButtons[x][y].BackgroundImage.Equals(Properties.Resources.downvoted))
                {
                    vm.removeAVote(this.currentUser.getUsername(), songs[index].getID(), -1);
                }
                else
                {
                    vm.doDownVote(songId, currentUser.getUsername());
                }

                createVotePercentage(voteDisplay[x][y], index);

                vm.doDownVote(songId, currentUser.getUsername());
                createVotePercentage(voteDisplay[x][y], index);
            }

        }

        private void playlistLeave(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            int id = int.Parse(theLabel.Tag.ToString());

            playlistLabels[id].BackColor = Color.FromArgb(40, 40, 40);

        }


        private void addSongToPlaylist(object sender, EventArgs e)
        {
            int playListIndex;

            Label theLabel = (Label)sender;
            playListIndex = int.Parse(theLabel.Tag.ToString());

            Playlist thePlaylist = usersPlaylists[playListIndex];

            String[] tmp = selectedSong.Split(',');
            int x = int.Parse(tmp[0]);
            int y = int.Parse(tmp[1]);

            String songName = songLabelsName[x][y].Text;

            Song toAdd = new Song();

            for (int i = 0; i < songs.Count; i++) 
            {
                if (songs[i].getTrackName().Equals(songName)) 
                {
                    toAdd = songs[i];
                    break;
                }
            }

            if (toAdd.getTrackName() != null && toAdd.getTrackName() != "")
            {
                PlaylistModel playlistModel = new PlaylistModel();

                playlistModel.addSongToPlaylist(thePlaylist, toAdd);
            }

            pnlOptions.Visible = false;
            pnlPlaylists.Visible = false;

        }

        private void clickEvent(object sender, System.EventArgs e)
        {
            Label theLabel = (Label)sender;

            selectedSong = theLabel.Tag.ToString();
            
            pnlOptions.Visible = true;

        }

        /// <summary>
        /// when the mouse enters the add to playlist label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAddToPLaylist_Enter(object sender, EventArgs e)
        {
            lblAddToPlaylist.BackColor = Color.DodgerBlue;
            pnlPlaylists.Visible = true;
        }

        /// <summary>
        /// when the mouse leaves the add to playist label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAddToPLaylist_Leave(object sender, EventArgs e)
        {
            tmrPlaylistDelay.Start();
            lblAddToPlaylist.BackColor = Color.FromArgb(40, 40, 40);
        }
        

        private void lblPlay_Click(object sender, EventArgs e)
        {
            Song toAdd = new Song();

            String[] tmp = selectedSong.Split(',');
            int x = int.Parse(tmp[0]);
            int y = int.Parse(tmp[1]);

            String songName = songLabelsName[x][y].Text;

            for (int i = 0; i < songs.Count; i++) 
            {
                if (songs[i].getTrackName().Equals(songName)) 
                {
                    toAdd = songs[i];
                    break;
                }
            }

            if (toAdd.getTrackName() != null && toAdd.getTrackName() != "")
            {


                String filePath = toAdd.getFileLocation();
                musicPlayer.stopSong();
                musicPlayer.setSongPath(@"" + filePath);
                musicPlayer.playCurrentSong();

            }
            pnlOptions.Visible = false;

        }


        private void lblPlay_Enter(object sender, EventArgs e)
        {
            lblPlay.BackColor = Color.DodgerBlue;
            pnlPlaylists.Visible = false;
        }

        private void lblPlay_Leave(object sender, EventArgs e)
        {
            tmrOptionsDelay.Start();
            lblPlay.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void tmrOptionsDelay_Tick(object sender, EventArgs e)
        {
            pnlOptions.Visible = false;
        }

    }
}
