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
            this.label25 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.lblArtists = new System.Windows.Forms.Label();
            this.tmrSlideArtists = new System.Windows.Forms.Timer(this.components);
            this.glassIcon = new System.Windows.Forms.PictureBox();
            this.pnlSongs.SuspendLayout();
            this.pnlArtists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glassIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSongs
            // 
            this.pnlSongs.AutoScroll = true;
            this.pnlSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlSongs.Controls.Add(this.lblSongsHeading);
            this.pnlSongs.Location = new System.Drawing.Point(46, 58);
            this.pnlSongs.Name = "pnlSongs";
            this.pnlSongs.Size = new System.Drawing.Size(800, 140);
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
            this.lblSearchedFor.Location = new System.Drawing.Point(76, 7);
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
            this.pnlArtists.Controls.Add(this.label25);
            this.pnlArtists.Controls.Add(this.label42);
            this.pnlArtists.Controls.Add(this.label45);
            this.pnlArtists.Controls.Add(this.label49);
            this.pnlArtists.Controls.Add(this.lblArtists);
            this.pnlArtists.Location = new System.Drawing.Point(46, 220);
            this.pnlArtists.Name = "pnlArtists";
            this.pnlArtists.Size = new System.Drawing.Size(800, 140);
            this.pnlArtists.TabIndex = 28;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(0, 121);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(780, 30);
            this.label25.TabIndex = 27;
            this.label25.Text = "No More Results";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.SystemColors.GrayText;
            this.label42.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(0, 84);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(780, 30);
            this.label42.TabIndex = 11;
            this.label42.Text = "Machineheart";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.SystemColors.Desktop;
            this.label45.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(0, 52);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(780, 30);
            this.label45.TabIndex = 7;
            this.label45.Text = "Men Without Hats";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.SystemColors.GrayText;
            this.label49.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(0, 20);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(780, 30);
            this.label49.TabIndex = 3;
            this.label49.Text = "Lewis Davie";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.glassIcon.Location = new System.Drawing.Point(46, 4);
            this.glassIcon.Name = "glassIcon";
            this.glassIcon.Size = new System.Drawing.Size(27, 34);
            this.glassIcon.TabIndex = 29;
            this.glassIcon.TabStop = false;
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(901, 457);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSongs;
        private System.Windows.Forms.Label lblSongsHeading;
        private System.Windows.Forms.Label lblSearchedFor;
        private System.Windows.Forms.Timer tmrSlideSongs;
        private System.Windows.Forms.Panel pnlArtists;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Timer tmrSlideArtists;
        private System.Windows.Forms.PictureBox glassIcon;
    }
}