namespace MALT_Music
{
    partial class SearchResults
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
            this.components = new System.ComponentModel.Container();
            this.pnlSongs = new System.Windows.Forms.Panel();
            this.lblSongsHeading = new System.Windows.Forms.Label();
            this.lblSearchedFor = new System.Windows.Forms.Label();
            this.tmrSlideSongs = new System.Windows.Forms.Timer(this.components);
            this.pnlArtists = new System.Windows.Forms.Panel();
            this.lblArtists = new System.Windows.Forms.Label();
            this.tmrSlideArtists = new System.Windows.Forms.Timer(this.components);
            this.glassIcon = new System.Windows.Forms.PictureBox();
            this.pnlPlaylists = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lblShare = new System.Windows.Forms.Label();
            this.lblAddToPlaylist = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.tmrOptionsDelay = new System.Windows.Forms.Timer(this.components);
            this.pnlSearchPlaylists = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrPlaylistDelay = new System.Windows.Forms.Timer(this.components);
            this.pnlSongs.SuspendLayout();
            this.pnlArtists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glassIcon)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.pnlSearchPlaylists.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSongs
            // 
            this.pnlSongs.AutoScroll = true;
            this.pnlSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlSongs.Controls.Add(this.lblSongsHeading);
            this.pnlSongs.Location = new System.Drawing.Point(242, 127);
            this.pnlSongs.Name = "pnlSongs";
            this.pnlSongs.Size = new System.Drawing.Size(800, 101);
            this.pnlSongs.TabIndex = 0;
            // 
            // lblSongsHeading
            // 
            this.lblSongsHeading.AutoSize = true;
            this.lblSongsHeading.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongsHeading.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSongsHeading.Location = new System.Drawing.Point(0, 0);
            this.lblSongsHeading.Name = "lblSongsHeading";
            this.lblSongsHeading.Size = new System.Drawing.Size(62, 20);
            this.lblSongsHeading.TabIndex = 2;
            this.lblSongsHeading.Text = " Songs>";
            this.lblSongsHeading.Click += new System.EventHandler(this.lblSongsHeading_Click);
            // 
            // lblSearchedFor
            // 
            this.lblSearchedFor.AutoSize = true;
            this.lblSearchedFor.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchedFor.ForeColor = System.Drawing.Color.White;
            this.lblSearchedFor.Location = new System.Drawing.Point(272, 95);
            this.lblSearchedFor.Name = "lblSearchedFor";
            this.lblSearchedFor.Size = new System.Drawing.Size(234, 26);
            this.lblSearchedFor.TabIndex = 1;
            this.lblSearchedFor.Text = "Search Results for: \'XYZ\':";
            // 
            // tmrSlideSongs
            // 
            this.tmrSlideSongs.Interval = 7;
            this.tmrSlideSongs.Tick += new System.EventHandler(this.tmrSlideSongs_Tick);
            // 
            // pnlArtists
            // 
            this.pnlArtists.AutoScroll = true;
            this.pnlArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlArtists.Controls.Add(this.lblArtists);
            this.pnlArtists.Location = new System.Drawing.Point(242, 257);
            this.pnlArtists.Name = "pnlArtists";
            this.pnlArtists.Size = new System.Drawing.Size(800, 115);
            this.pnlArtists.TabIndex = 28;
            // 
            // lblArtists
            // 
            this.lblArtists.AutoSize = true;
            this.lblArtists.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtists.ForeColor = System.Drawing.Color.DarkGray;
            this.lblArtists.Location = new System.Drawing.Point(0, 0);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(64, 20);
            this.lblArtists.TabIndex = 2;
            this.lblArtists.Text = " Artists>";
            this.lblArtists.Click += new System.EventHandler(this.lblArtists_Click);
            // 
            // tmrSlideArtists
            // 
            this.tmrSlideArtists.Interval = 7;
            this.tmrSlideArtists.Tick += new System.EventHandler(this.tmrSlideArtists_Tick);
            // 
            // glassIcon
            // 
            this.glassIcon.BackgroundImage = global::MALT_Music.Properties.Resources.Magnifying_glass_icon_white;
            this.glassIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.glassIcon.Location = new System.Drawing.Point(242, 92);
            this.glassIcon.Name = "glassIcon";
            this.glassIcon.Size = new System.Drawing.Size(33, 34);
            this.glassIcon.TabIndex = 29;
            this.glassIcon.TabStop = false;
            // 
            // pnlPlaylists
            // 
            this.pnlPlaylists.AutoScroll = true;
            this.pnlPlaylists.AutoSize = true;
            this.pnlPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlPlaylists.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPlaylists.Location = new System.Drawing.Point(897, 110);
            this.pnlPlaylists.MaximumSize = new System.Drawing.Size(170, 211);
            this.pnlPlaylists.Name = "pnlPlaylists";
            this.pnlPlaylists.Size = new System.Drawing.Size(144, 84);
            this.pnlPlaylists.TabIndex = 31;
            this.pnlPlaylists.Visible = false;
            this.pnlPlaylists.MouseEnter += new System.EventHandler(this.pnlPlaylists_MouseEnter);
            this.pnlPlaylists.MouseLeave += new System.EventHandler(this.pnlPlaylists_MouseLeave);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlOptions.Controls.Add(this.lblShare);
            this.pnlOptions.Controls.Add(this.lblAddToPlaylist);
            this.pnlOptions.Controls.Add(this.lblPlay);
            this.pnlOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlOptions.Location = new System.Drawing.Point(752, 110);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(139, 141);
            this.pnlOptions.TabIndex = 30;
            this.pnlOptions.Visible = false;
            this.pnlOptions.MouseLeave += new System.EventHandler(this.pnlOptions_MouseLeave);
            // 
            // lblShare
            // 
            this.lblShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblShare.Enabled = false;
            this.lblShare.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShare.ForeColor = System.Drawing.Color.DimGray;
            this.lblShare.Location = new System.Drawing.Point(0, 96);
            this.lblShare.Name = "lblShare";
            this.lblShare.Size = new System.Drawing.Size(139, 43);
            this.lblShare.TabIndex = 2;
            this.lblShare.Text = "Share...";
            this.lblShare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddToPlaylist
            // 
            this.lblAddToPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblAddToPlaylist.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddToPlaylist.ForeColor = System.Drawing.Color.White;
            this.lblAddToPlaylist.Location = new System.Drawing.Point(0, 48);
            this.lblAddToPlaylist.Name = "lblAddToPlaylist";
            this.lblAddToPlaylist.Size = new System.Drawing.Size(139, 43);
            this.lblAddToPlaylist.TabIndex = 1;
            this.lblAddToPlaylist.Text = "Add To Playlist >";
            this.lblAddToPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddToPlaylist.MouseEnter += new System.EventHandler(this.lblAddToPLaylist_Enter);
            this.lblAddToPlaylist.MouseLeave += new System.EventHandler(this.lblAddToPLaylist_Leave);
            // 
            // lblPlay
            // 
            this.lblPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblPlay.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.White;
            this.lblPlay.Location = new System.Drawing.Point(0, 0);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(139, 43);
            this.lblPlay.TabIndex = 0;
            this.lblPlay.Text = "Play";
            this.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            this.lblPlay.MouseEnter += new System.EventHandler(this.lblPlay_Enter);
            this.lblPlay.MouseLeave += new System.EventHandler(this.lblPlay_Leave);
            // 
            // tmrOptionsDelay
            // 
            this.tmrOptionsDelay.Interval = 700;
            this.tmrOptionsDelay.Tick += new System.EventHandler(this.tmrOptionsDelay_Tick);
            // 
            // pnlSearchPlaylists
            // 
            this.pnlSearchPlaylists.AutoScroll = true;
            this.pnlSearchPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlSearchPlaylists.Controls.Add(this.label1);
            this.pnlSearchPlaylists.Location = new System.Drawing.Point(242, 399);
            this.pnlSearchPlaylists.Name = "pnlSearchPlaylists";
            this.pnlSearchPlaylists.Size = new System.Drawing.Size(800, 115);
            this.pnlSearchPlaylists.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Playlists>";
            // 
            // tmrPlaylistDelay
            // 
            this.tmrPlaylistDelay.Interval = 700;
            this.tmrPlaylistDelay.Tick += new System.EventHandler(this.tmrPlaylistDelay_Tick);
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1095, 411);
            this.Controls.Add(this.pnlSearchPlaylists);
            this.Controls.Add(this.pnlPlaylists);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.glassIcon);
            this.Controls.Add(this.pnlArtists);
            this.Controls.Add(this.lblSearchedFor);
            this.Controls.Add(this.pnlSongs);
            this.Name = "SearchResults";
            this.Text = "SearchResults";
            this.pnlSongs.ResumeLayout(false);
            this.pnlSongs.PerformLayout();
            this.pnlArtists.ResumeLayout(false);
            this.pnlArtists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glassIcon)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnlSearchPlaylists.ResumeLayout(false);
            this.pnlSearchPlaylists.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSongs;
        private System.Windows.Forms.Label lblSongsHeading;
        private System.Windows.Forms.Label lblSearchedFor;
        private System.Windows.Forms.Timer tmrSlideSongs;
        private System.Windows.Forms.Panel pnlArtists;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Timer tmrSlideArtists;
        private System.Windows.Forms.PictureBox glassIcon;
        private System.Windows.Forms.Panel pnlPlaylists;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.Label lblAddToPlaylist;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Timer tmrOptionsDelay;
        private System.Windows.Forms.Panel pnlSearchPlaylists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrPlaylistDelay;
    }
}