namespace MALT_Music
{
    partial class ViewPlaylist
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
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblNumSongs = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlPlaylists = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lblShare = new System.Windows.Forms.Label();
            this.lblAddToPlaylist = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.txtPlaylistNameEdit = new System.Windows.Forms.TextBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.picRecommend = new System.Windows.Forms.PictureBox();
            this.coverImage4 = new System.Windows.Forms.PictureBox();
            this.coverImage3 = new System.Windows.Forms.PictureBox();
            this.coverImage2 = new System.Windows.Forms.PictureBox();
            this.coverImage1 = new System.Windows.Forms.PictureBox();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecommend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.ForeColor = System.Drawing.Color.White;
            this.lblPlaylistName.Location = new System.Drawing.Point(257, 96);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(237, 37);
            this.lblPlaylistName.TabIndex = 4;
            this.lblPlaylistName.Text = "PLAYLIST NAME";
            this.lblPlaylistName.Click += new System.EventHandler(this.lblPlaylistName_Click);
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.ForeColor = System.Drawing.Color.White;
            this.lblOwner.Location = new System.Drawing.Point(261, 132);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(50, 20);
            this.lblOwner.TabIndex = 5;
            this.lblOwner.Text = "Owner";
            // 
            // lblNumSongs
            // 
            this.lblNumSongs.AutoSize = true;
            this.lblNumSongs.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSongs.ForeColor = System.Drawing.Color.White;
            this.lblNumSongs.Location = new System.Drawing.Point(265, 247);
            this.lblNumSongs.Name = "lblNumSongs";
            this.lblNumSongs.Size = new System.Drawing.Size(53, 17);
            this.lblNumSongs.TabIndex = 6;
            this.lblNumSongs.Text = "0 Songs";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(265, 264);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(88, 51);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "0 seconds";
            // 
            // pnlPlaylists
            // 
            this.pnlPlaylists.AutoScroll = true;
            this.pnlPlaylists.AutoSize = true;
            this.pnlPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlPlaylists.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPlaylists.Location = new System.Drawing.Point(750, 189);
            this.pnlPlaylists.MaximumSize = new System.Drawing.Size(170, 211);
            this.pnlPlaylists.Name = "pnlPlaylists";
            this.pnlPlaylists.Size = new System.Drawing.Size(144, 84);
            this.pnlPlaylists.TabIndex = 35;
            this.pnlPlaylists.Visible = false;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlOptions.Controls.Add(this.lblShare);
            this.pnlOptions.Controls.Add(this.lblAddToPlaylist);
            this.pnlOptions.Controls.Add(this.lblPlay);
            this.pnlOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlOptions.Location = new System.Drawing.Point(605, 189);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(139, 141);
            this.pnlOptions.TabIndex = 34;
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
            this.lblAddToPlaylist.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddToPlaylist.Location = new System.Drawing.Point(0, 48);
            this.lblAddToPlaylist.Name = "lblAddToPlaylist";
            this.lblAddToPlaylist.Size = new System.Drawing.Size(139, 43);
            this.lblAddToPlaylist.TabIndex = 1;
            this.lblAddToPlaylist.Text = "Add To Playlist >";
            this.lblAddToPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // txtPlaylistNameEdit
            // 
            this.txtPlaylistNameEdit.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistNameEdit.Location = new System.Drawing.Point(265, 85);
            this.txtPlaylistNameEdit.Name = "txtPlaylistNameEdit";
            this.txtPlaylistNameEdit.Size = new System.Drawing.Size(291, 44);
            this.txtPlaylistNameEdit.TabIndex = 37;
            this.txtPlaylistNameEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlaylistNameEdit_KeyDown);
            this.txtPlaylistNameEdit.MouseLeave += new System.EventHandler(this.txtPlaylistNameEdit_MouseLeave);
            // 
            // picSave
            // 
            this.picSave.BackgroundImage = global::MALT_Music.Properties.Resources.save_playlist;
            this.picSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSave.Location = new System.Drawing.Point(562, 104);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(65, 22);
            this.picSave.TabIndex = 38;
            this.picSave.TabStop = false;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
            // 
            // picRecommend
            // 
            this.picRecommend.BackgroundImage = global::MALT_Music.Properties.Resources.recommendIcon;
            this.picRecommend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRecommend.Location = new System.Drawing.Point(264, 318);
            this.picRecommend.Name = "picRecommend";
            this.picRecommend.Size = new System.Drawing.Size(78, 81);
            this.picRecommend.TabIndex = 36;
            this.picRecommend.TabStop = false;
            this.picRecommend.Click += new System.EventHandler(this.picRecommend_Click);
            // 
            // coverImage4
            // 
            this.coverImage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverImage4.Location = new System.Drawing.Point(309, 200);
            this.coverImage4.Name = "coverImage4";
            this.coverImage4.Size = new System.Drawing.Size(44, 44);
            this.coverImage4.TabIndex = 3;
            this.coverImage4.TabStop = false;
            // 
            // coverImage3
            // 
            this.coverImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverImage3.Location = new System.Drawing.Point(265, 200);
            this.coverImage3.Name = "coverImage3";
            this.coverImage3.Size = new System.Drawing.Size(44, 44);
            this.coverImage3.TabIndex = 2;
            this.coverImage3.TabStop = false;
            // 
            // coverImage2
            // 
            this.coverImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverImage2.Location = new System.Drawing.Point(309, 156);
            this.coverImage2.Name = "coverImage2";
            this.coverImage2.Size = new System.Drawing.Size(44, 44);
            this.coverImage2.TabIndex = 1;
            this.coverImage2.TabStop = false;
            // 
            // coverImage1
            // 
            this.coverImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverImage1.Location = new System.Drawing.Point(265, 156);
            this.coverImage1.Name = "coverImage1";
            this.coverImage1.Size = new System.Drawing.Size(44, 44);
            this.coverImage1.TabIndex = 0;
            this.coverImage1.TabStop = false;
            // 
            // ViewPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1094, 442);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.txtPlaylistNameEdit);
            this.Controls.Add(this.picRecommend);
            this.Controls.Add(this.pnlPlaylists);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNumSongs);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.coverImage4);
            this.Controls.Add(this.coverImage3);
            this.Controls.Add(this.coverImage2);
            this.Controls.Add(this.coverImage1);
            this.Name = "ViewPlaylist";
            this.Text = "ViewPlaylist";
            this.pnlOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecommend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverImage1;
        private System.Windows.Forms.PictureBox coverImage2;
        private System.Windows.Forms.PictureBox coverImage4;
        private System.Windows.Forms.PictureBox coverImage3;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblNumSongs;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlPlaylists;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.Label lblAddToPlaylist;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.PictureBox picRecommend;
        private System.Windows.Forms.TextBox txtPlaylistNameEdit;
        private System.Windows.Forms.PictureBox picSave;
    }
}