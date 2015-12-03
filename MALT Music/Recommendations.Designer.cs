namespace MALT_Music
{
    partial class Recommendations
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
            this.picSelectedArt = new System.Windows.Forms.PictureBox();
            this.lblSelectedSongName = new System.Windows.Forms.Label();
            this.lblSelectedSongArtist = new System.Windows.Forms.Label();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.tmrPreview = new System.Windows.Forms.Timer(this.components);
            this.lblAddToPlaylist = new System.Windows.Forms.Label();
            this.lblDiscard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // picSelectedArt
            // 
            this.picSelectedArt.BackgroundImage = global::MALT_Music.Properties.Resources.loadingplaceholder;
            this.picSelectedArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSelectedArt.Location = new System.Drawing.Point(512, 50);
            this.picSelectedArt.Name = "picSelectedArt";
            this.picSelectedArt.Size = new System.Drawing.Size(50, 50);
            this.picSelectedArt.TabIndex = 0;
            this.picSelectedArt.TabStop = false;
            // 
            // lblSelectedSongName
            // 
            this.lblSelectedSongName.AutoSize = true;
            this.lblSelectedSongName.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedSongName.ForeColor = System.Drawing.Color.White;
            this.lblSelectedSongName.Location = new System.Drawing.Point(565, 50);
            this.lblSelectedSongName.Name = "lblSelectedSongName";
            this.lblSelectedSongName.Size = new System.Drawing.Size(116, 26);
            this.lblSelectedSongName.TabIndex = 1;
            this.lblSelectedSongName.Text = "Song Name";
            // 
            // lblSelectedSongArtist
            // 
            this.lblSelectedSongArtist.AutoSize = true;
            this.lblSelectedSongArtist.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedSongArtist.ForeColor = System.Drawing.Color.White;
            this.lblSelectedSongArtist.Location = new System.Drawing.Point(568, 76);
            this.lblSelectedSongArtist.Name = "lblSelectedSongArtist";
            this.lblSelectedSongArtist.Size = new System.Drawing.Size(73, 17);
            this.lblSelectedSongArtist.TabIndex = 2;
            this.lblSelectedSongArtist.Text = "Artist Name";
            // 
            // picPlay
            // 
            this.picPlay.BackgroundImage = global::MALT_Music.Properties.Resources.playtrack;
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPlay.Location = new System.Drawing.Point(518, 101);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(36, 35);
            this.picPlay.TabIndex = 3;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // tmrPreview
            // 
            this.tmrPreview.Interval = 30000;
            this.tmrPreview.Tick += new System.EventHandler(this.tmrPreview_Tick);
            // 
            // lblAddToPlaylist
            // 
            this.lblAddToPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAddToPlaylist.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddToPlaylist.ForeColor = System.Drawing.Color.White;
            this.lblAddToPlaylist.Location = new System.Drawing.Point(514, 174);
            this.lblAddToPlaylist.Name = "lblAddToPlaylist";
            this.lblAddToPlaylist.Size = new System.Drawing.Size(139, 43);
            this.lblAddToPlaylist.TabIndex = 4;
            this.lblAddToPlaylist.Text = "Add To Playlist";
            this.lblAddToPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddToPlaylist.Click += new System.EventHandler(this.lblAddToPlaylist_Click);
            // 
            // lblDiscard
            // 
            this.lblDiscard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDiscard.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscard.ForeColor = System.Drawing.Color.White;
            this.lblDiscard.Location = new System.Drawing.Point(514, 222);
            this.lblDiscard.Name = "lblDiscard";
            this.lblDiscard.Size = new System.Drawing.Size(139, 43);
            this.lblDiscard.TabIndex = 5;
            this.lblDiscard.Text = "Discard";
            this.lblDiscard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDiscard.Click += new System.EventHandler(this.lblDiscard_Click);
            // 
            // Recommendations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(827, 318);
            this.Controls.Add(this.lblDiscard);
            this.Controls.Add(this.lblAddToPlaylist);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.lblSelectedSongArtist);
            this.Controls.Add(this.lblSelectedSongName);
            this.Controls.Add(this.picSelectedArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Recommendations";
            this.Text = "Recommendations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Recommendations_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSelectedArt;
        private System.Windows.Forms.Label lblSelectedSongName;
        private System.Windows.Forms.Label lblSelectedSongArtist;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.Timer tmrPreview;
        private System.Windows.Forms.Label lblAddToPlaylist;
        private System.Windows.Forms.Label lblDiscard;

    }
}