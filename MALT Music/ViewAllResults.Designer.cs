namespace MALT_Music
{
    partial class ViewAllResults
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
            this.lblSearchedFor = new System.Windows.Forms.Label();
            this.pnlPlaylists = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lblShare = new System.Windows.Forms.Label();
            this.lblAddToPlaylist = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.tmrOptionsDelay = new System.Windows.Forms.Timer(this.components);
            this.tmrPlaylistDelay = new System.Windows.Forms.Timer(this.components);
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchedFor
            // 
            this.lblSearchedFor.AutoSize = true;
            this.lblSearchedFor.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchedFor.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchedFor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearchedFor.Location = new System.Drawing.Point(28, 9);
            this.lblSearchedFor.Name = "lblSearchedFor";
            this.lblSearchedFor.Size = new System.Drawing.Size(235, 26);
            this.lblSearchedFor.TabIndex = 0;
            this.lblSearchedFor.Text = "ALL THE LABEL-Y THINGS";
            // 
            // pnlPlaylists
            // 
            this.pnlPlaylists.AutoScroll = true;
            this.pnlPlaylists.AutoSize = true;
            this.pnlPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlPlaylists.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPlaylists.Location = new System.Drawing.Point(491, 49);
            this.pnlPlaylists.MaximumSize = new System.Drawing.Size(170, 211);
            this.pnlPlaylists.Name = "pnlPlaylists";
            this.pnlPlaylists.Size = new System.Drawing.Size(144, 84);
            this.pnlPlaylists.TabIndex = 37;
            this.pnlPlaylists.Visible = false;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlOptions.Controls.Add(this.lblShare);
            this.pnlOptions.Controls.Add(this.lblAddToPlaylist);
            this.pnlOptions.Controls.Add(this.lblPlay);
            this.pnlOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlOptions.Location = new System.Drawing.Point(346, 49);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(139, 141);
            this.pnlOptions.TabIndex = 36;
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
            // tmrOptionsDelay
            // 
            this.tmrOptionsDelay.Interval = 700;
            this.tmrOptionsDelay.Tick += new System.EventHandler(this.tmrOptionsDelay_Tick);
            // 
            // tmrPlaylistDelay
            // 
            this.tmrPlaylistDelay.Interval = 700;
            this.tmrPlaylistDelay.Tick += new System.EventHandler(this.tmrPlaylistDelay_Tick);
            // 
            // ViewAllResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(862, 369);
            this.Controls.Add(this.pnlPlaylists);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.lblSearchedFor);
            this.Name = "ViewAllResults";
            this.Text = "ViewAllResults";
            this.pnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchedFor;
        private System.Windows.Forms.Panel pnlPlaylists;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.Label lblAddToPlaylist;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Timer tmrOptionsDelay;
        private System.Windows.Forms.Timer tmrPlaylistDelay;
    }
}