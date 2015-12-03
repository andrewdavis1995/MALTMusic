namespace MALT_Music
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.btnMusicPlayer = new System.Windows.Forms.Button();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblLoginLabel = new System.Windows.Forms.Label();
            this.cmdSkipLogin = new System.Windows.Forms.Button();
            this.cmdAddSong = new System.Windows.Forms.Button();
            this.cmdGetPlaylists = new System.Windows.Forms.Button();
            this.cmdCreatePlaylist = new System.Windows.Forms.Button();
            this.cmdAddSongToPlaylist = new System.Windows.Forms.Button();
            this.cmdSearchResults = new System.Windows.Forms.Button();
            this.cmdArtistSongs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(400, 247);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username...";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(400, 284);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password...";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(625, 320);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(75, 23);
            this.cmdLogin.TabIndex = 2;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // btnMusicPlayer
            // 
            this.btnMusicPlayer.Location = new System.Drawing.Point(12, 424);
            this.btnMusicPlayer.Name = "btnMusicPlayer";
            this.btnMusicPlayer.Size = new System.Drawing.Size(111, 48);
            this.btnMusicPlayer.TabIndex = 4;
            this.btnMusicPlayer.Text = "Music Player";
            this.btnMusicPlayer.UseVisualStyleBackColor = true;
            this.btnMusicPlayer.Click += new System.EventHandler(this.btnMusicPlayer_Click);
            // 
            // cmdRegister
            // 
            this.cmdRegister.Location = new System.Drawing.Point(400, 320);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(75, 23);
            this.cmdRegister.TabIndex = 5;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = true;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::MALT_Music.Properties.Resources.logo;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(227, 144);
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // lblLoginLabel
            // 
            this.lblLoginLabel.AutoSize = true;
            this.lblLoginLabel.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginLabel.ForeColor = System.Drawing.Color.White;
            this.lblLoginLabel.Location = new System.Drawing.Point(493, 162);
            this.lblLoginLabel.Name = "lblLoginLabel";
            this.lblLoginLabel.Size = new System.Drawing.Size(98, 43);
            this.lblLoginLabel.TabIndex = 12;
            this.lblLoginLabel.Text = "LOGIN";
            // 
            // cmdSkipLogin
            // 
            this.cmdSkipLogin.Location = new System.Drawing.Point(138, 424);
            this.cmdSkipLogin.Name = "cmdSkipLogin";
            this.cmdSkipLogin.Size = new System.Drawing.Size(111, 48);
            this.cmdSkipLogin.TabIndex = 13;
            this.cmdSkipLogin.Text = "Go to Home Page - without Logging in";
            this.cmdSkipLogin.UseVisualStyleBackColor = true;
            this.cmdSkipLogin.Click += new System.EventHandler(this.cmdSkipLogin_Click);
            // 
            // cmdAddSong
            // 
            this.cmdAddSong.Location = new System.Drawing.Point(12, 357);
            this.cmdAddSong.Name = "cmdAddSong";
            this.cmdAddSong.Size = new System.Drawing.Size(111, 48);
            this.cmdAddSong.TabIndex = 14;
            this.cmdAddSong.Text = "Add a Song";
            this.cmdAddSong.UseVisualStyleBackColor = true;
            this.cmdAddSong.Click += new System.EventHandler(this.cmdAddSong_Click);
            // 
            // cmdGetPlaylists
            // 
            this.cmdGetPlaylists.Location = new System.Drawing.Point(138, 357);
            this.cmdGetPlaylists.Name = "cmdGetPlaylists";
            this.cmdGetPlaylists.Size = new System.Drawing.Size(111, 48);
            this.cmdGetPlaylists.TabIndex = 15;
            this.cmdGetPlaylists.Text = "Get Playlists for user";
            this.cmdGetPlaylists.UseVisualStyleBackColor = true;
            this.cmdGetPlaylists.Click += new System.EventHandler(this.cmdGetPlaylists_Click);
            // 
            // cmdCreatePlaylist
            // 
            this.cmdCreatePlaylist.Location = new System.Drawing.Point(263, 424);
            this.cmdCreatePlaylist.Name = "cmdCreatePlaylist";
            this.cmdCreatePlaylist.Size = new System.Drawing.Size(111, 48);
            this.cmdCreatePlaylist.TabIndex = 16;
            this.cmdCreatePlaylist.Text = "Create Playlist";
            this.cmdCreatePlaylist.UseVisualStyleBackColor = true;
            this.cmdCreatePlaylist.Click += new System.EventHandler(this.cmdCreatePlaylist_Click);
            // 
            // cmdAddSongToPlaylist
            // 
            this.cmdAddSongToPlaylist.Location = new System.Drawing.Point(263, 357);
            this.cmdAddSongToPlaylist.Name = "cmdAddSongToPlaylist";
            this.cmdAddSongToPlaylist.Size = new System.Drawing.Size(111, 48);
            this.cmdAddSongToPlaylist.TabIndex = 17;
            this.cmdAddSongToPlaylist.Text = "Add Song to Playlist";
            this.cmdAddSongToPlaylist.UseVisualStyleBackColor = true;
            this.cmdAddSongToPlaylist.Click += new System.EventHandler(this.cmdAddSongToPlaylist_Click);
            // 
            // cmdSearchResults
            // 
            this.cmdSearchResults.Location = new System.Drawing.Point(12, 295);
            this.cmdSearchResults.Name = "cmdSearchResults";
            this.cmdSearchResults.Size = new System.Drawing.Size(111, 48);
            this.cmdSearchResults.TabIndex = 18;
            this.cmdSearchResults.Text = "Search Results ";
            this.cmdSearchResults.UseVisualStyleBackColor = true;
            this.cmdSearchResults.Click += new System.EventHandler(this.cmdSearchResults_Click);
            // 
            // cmdArtistSongs
            // 
            this.cmdArtistSongs.Location = new System.Drawing.Point(138, 295);
            this.cmdArtistSongs.Name = "cmdArtistSongs";
            this.cmdArtistSongs.Size = new System.Drawing.Size(111, 48);
            this.cmdArtistSongs.TabIndex = 19;
            this.cmdArtistSongs.Text = "Artist Thing";
            this.cmdArtistSongs.UseVisualStyleBackColor = true;
            this.cmdArtistSongs.Click += new System.EventHandler(this.cmdArtistSongs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 48);
            this.button1.TabIndex = 20;
            this.button1.Text = "Recommendations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1006, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdArtistSongs);
            this.Controls.Add(this.cmdSearchResults);
            this.Controls.Add(this.cmdAddSongToPlaylist);
            this.Controls.Add(this.cmdCreatePlaylist);
            this.Controls.Add(this.cmdGetPlaylists);
            this.Controls.Add(this.cmdAddSong);
            this.Controls.Add(this.cmdSkipLogin);
            this.Controls.Add(this.lblLoginLabel);
            this.Controls.Add(this.cmdRegister);
            this.Controls.Add(this.btnMusicPlayer);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnMusicPlayer;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.Label lblLoginLabel;
        private System.Windows.Forms.Button cmdSkipLogin;
        private System.Windows.Forms.Button cmdAddSong;
        private System.Windows.Forms.Button cmdGetPlaylists;
        private System.Windows.Forms.Button cmdCreatePlaylist;
        private System.Windows.Forms.Button cmdAddSongToPlaylist;
        private System.Windows.Forms.Button cmdSearchResults;
        private System.Windows.Forms.Button cmdArtistSongs;
        private System.Windows.Forms.Button button1;
    }
}