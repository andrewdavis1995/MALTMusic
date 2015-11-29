namespace MALT_Music
{
    partial class ArtistView
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
            this.lblArtistName = new System.Windows.Forms.Label();
            this.pnlTopInfo = new System.Windows.Forms.Panel();
            this.lblNumAlbums = new System.Windows.Forms.Label();
            this.lblPopularity = new System.Windows.Forms.Label();
            this.pnlPlaylists = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lblShare = new System.Windows.Forms.Label();
            this.lblAddToPlaylist = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.tmrPlaylistDelay = new System.Windows.Forms.Timer(this.components);
            this.tmrOptionsDelay = new System.Windows.Forms.Timer(this.components);
            this.pnlTopInfo.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.BackColor = System.Drawing.Color.Black;
            this.lblArtistName.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.ForeColor = System.Drawing.Color.White;
            this.lblArtistName.Location = new System.Drawing.Point(3, 0);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(132, 43);
            this.lblArtistName.TabIndex = 0;
            this.lblArtistName.Text = "ARTIST";
            this.lblArtistName.UseMnemonic = false;
            // 
            // pnlTopInfo
            // 
            this.pnlTopInfo.Controls.Add(this.lblNumAlbums);
            this.pnlTopInfo.Controls.Add(this.lblPopularity);
            this.pnlTopInfo.Controls.Add(this.lblArtistName);
            this.pnlTopInfo.Location = new System.Drawing.Point(242, 92);
            this.pnlTopInfo.Name = "pnlTopInfo";
            this.pnlTopInfo.Size = new System.Drawing.Size(858, 97);
            this.pnlTopInfo.TabIndex = 1;
            // 
            // lblNumAlbums
            // 
            this.lblNumAlbums.AutoSize = true;
            this.lblNumAlbums.BackColor = System.Drawing.Color.Black;
            this.lblNumAlbums.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAlbums.ForeColor = System.Drawing.Color.White;
            this.lblNumAlbums.Location = new System.Drawing.Point(7, 71);
            this.lblNumAlbums.Name = "lblNumAlbums";
            this.lblNumAlbums.Size = new System.Drawing.Size(145, 20);
            this.lblNumAlbums.TabIndex = 2;
            this.lblNumAlbums.Text = "Number of Albums: 0";
            // 
            // lblPopularity
            // 
            this.lblPopularity.AutoSize = true;
            this.lblPopularity.BackColor = System.Drawing.Color.Black;
            this.lblPopularity.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopularity.ForeColor = System.Drawing.Color.White;
            this.lblPopularity.Location = new System.Drawing.Point(7, 47);
            this.lblPopularity.Name = "lblPopularity";
            this.lblPopularity.Size = new System.Drawing.Size(103, 20);
            this.lblPopularity.TabIndex = 1;
            this.lblPopularity.Text = "Popularity: 0%";
            // 
            // pnlPlaylists
            // 
            this.pnlPlaylists.AutoScroll = true;
            this.pnlPlaylists.AutoSize = true;
            this.pnlPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlPlaylists.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPlaylists.Location = new System.Drawing.Point(956, 195);
            this.pnlPlaylists.MaximumSize = new System.Drawing.Size(170, 211);
            this.pnlPlaylists.Name = "pnlPlaylists";
            this.pnlPlaylists.Size = new System.Drawing.Size(144, 84);
            this.pnlPlaylists.TabIndex = 33;
            this.pnlPlaylists.Visible = false;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlOptions.Controls.Add(this.lblShare);
            this.pnlOptions.Controls.Add(this.lblAddToPlaylist);
            this.pnlOptions.Controls.Add(this.lblPlay);
            this.pnlOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlOptions.Location = new System.Drawing.Point(811, 195);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(139, 141);
            this.pnlOptions.TabIndex = 32;
            this.pnlOptions.Visible = false;
            // 
            // lblShare
            // 
            this.lblShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
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
            // tmrPlaylistDelay
            // 
            this.tmrPlaylistDelay.Interval = 700;
            // 
            // tmrOptionsDelay
            // 
            this.tmrOptionsDelay.Interval = 700;
            // 
            // ArtistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1330, 391);
            this.Controls.Add(this.pnlPlaylists);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlTopInfo);
            this.Name = "ArtistView";
            this.Text = "ArtistView";
            this.pnlTopInfo.ResumeLayout(false);
            this.pnlTopInfo.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Panel pnlTopInfo;
        private System.Windows.Forms.Label lblNumAlbums;
        private System.Windows.Forms.Label lblPopularity;
        private System.Windows.Forms.Panel pnlPlaylists;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.Label lblAddToPlaylist;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Timer tmrPlaylistDelay;
        private System.Windows.Forms.Timer tmrOptionsDelay;
    }
}