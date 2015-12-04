namespace MALT_Music
{
    partial class frmMusicPlayer
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
            this.lblPlayerStatus = new System.Windows.Forms.Label();
            this.tmrTracker = new System.Windows.Forms.Timer(this.components);
            this.grpRepeat = new System.Windows.Forms.GroupBox();
            this.rbnPlaylist = new System.Windows.Forms.RadioButton();
            this.rbnOnce = new System.Windows.Forms.RadioButton();
            this.rbnCurrent = new System.Windows.Forms.RadioButton();
            this.rbnNone = new System.Windows.Forms.RadioButton();
            this.ttpSliderIndicator = new System.Windows.Forms.ToolTip(this.components);
            this.lblTimeOne = new System.Windows.Forms.Label();
            this.lblTimeTwo = new System.Windows.Forms.Label();
            this.pcbSliderBar = new System.Windows.Forms.PictureBox();
            this.picBoxAlbumArt = new System.Windows.Forms.PictureBox();
            this.pcbPlay = new System.Windows.Forms.PictureBox();
            this.pcbVolume = new System.Windows.Forms.PictureBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.ttpVolumeIndicator = new System.Windows.Forms.ToolTip(this.components);
            this.lblVolumeLevel = new System.Windows.Forms.Label();
            this.pcbForwardSkip = new System.Windows.Forms.PictureBox();
            this.pcbBackSkip = new System.Windows.Forms.PictureBox();
            this.ttpGeneralTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpRepeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSliderBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlbumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbForwardSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackSkip)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerStatus
            // 
            this.lblPlayerStatus.AutoEllipsis = true;
            this.lblPlayerStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayerStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerStatus.Location = new System.Drawing.Point(147, 65);
            this.lblPlayerStatus.Name = "lblPlayerStatus";
            this.lblPlayerStatus.Size = new System.Drawing.Size(577, 18);
            this.lblPlayerStatus.TabIndex = 4;
            this.lblPlayerStatus.Text = "No file selected";
            this.ttpGeneralTip.SetToolTip(this.lblPlayerStatus, "Song Title");
            this.lblPlayerStatus.UseMnemonic = false;
            // 
            // tmrTracker
            // 
            this.tmrTracker.Interval = 1000;
            this.tmrTracker.Tick += new System.EventHandler(this.tmrTracker_Tick);
            // 
            // grpRepeat
            // 
            this.grpRepeat.Controls.Add(this.rbnPlaylist);
            this.grpRepeat.Controls.Add(this.rbnOnce);
            this.grpRepeat.Controls.Add(this.rbnCurrent);
            this.grpRepeat.Controls.Add(this.rbnNone);
            this.grpRepeat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRepeat.ForeColor = System.Drawing.Color.White;
            this.grpRepeat.Location = new System.Drawing.Point(730, 35);
            this.grpRepeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRepeat.Name = "grpRepeat";
            this.grpRepeat.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRepeat.Size = new System.Drawing.Size(143, 108);
            this.grpRepeat.TabIndex = 8;
            this.grpRepeat.TabStop = false;
            this.grpRepeat.Text = "Repeat Options";
            // 
            // rbnPlaylist
            // 
            this.rbnPlaylist.AutoSize = true;
            this.rbnPlaylist.Location = new System.Drawing.Point(7, 84);
            this.rbnPlaylist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbnPlaylist.Name = "rbnPlaylist";
            this.rbnPlaylist.Size = new System.Drawing.Size(61, 20);
            this.rbnPlaylist.TabIndex = 3;
            this.rbnPlaylist.TabStop = true;
            this.rbnPlaylist.Text = "Playlist";
            this.ttpGeneralTip.SetToolTip(this.rbnPlaylist, "Repeat the playlist");
            this.rbnPlaylist.UseVisualStyleBackColor = true;
            // 
            // rbnOnce
            // 
            this.rbnOnce.AutoSize = true;
            this.rbnOnce.Location = new System.Drawing.Point(7, 44);
            this.rbnOnce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbnOnce.Name = "rbnOnce";
            this.rbnOnce.Size = new System.Drawing.Size(57, 20);
            this.rbnOnce.TabIndex = 2;
            this.rbnOnce.TabStop = true;
            this.rbnOnce.Text = "Once";
            this.ttpGeneralTip.SetToolTip(this.rbnOnce, "Repeat current song once, then continue as normal");
            this.rbnOnce.UseVisualStyleBackColor = true;
            // 
            // rbnCurrent
            // 
            this.rbnCurrent.AutoSize = true;
            this.rbnCurrent.Location = new System.Drawing.Point(7, 64);
            this.rbnCurrent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbnCurrent.Name = "rbnCurrent";
            this.rbnCurrent.Size = new System.Drawing.Size(66, 20);
            this.rbnCurrent.TabIndex = 1;
            this.rbnCurrent.TabStop = true;
            this.rbnCurrent.Text = "Current";
            this.ttpGeneralTip.SetToolTip(this.rbnCurrent, "Repeat the current song continuously");
            this.rbnCurrent.UseVisualStyleBackColor = true;
            // 
            // rbnNone
            // 
            this.rbnNone.AutoSize = true;
            this.rbnNone.Checked = true;
            this.rbnNone.Location = new System.Drawing.Point(7, 22);
            this.rbnNone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbnNone.Name = "rbnNone";
            this.rbnNone.Size = new System.Drawing.Size(55, 20);
            this.rbnNone.TabIndex = 0;
            this.rbnNone.TabStop = true;
            this.rbnNone.Text = "None";
            this.ttpGeneralTip.SetToolTip(this.rbnNone, "Play to the end of the playlist");
            this.rbnNone.UseVisualStyleBackColor = true;
            // 
            // ttpSliderIndicator
            // 
            this.ttpSliderIndicator.UseAnimation = false;
            this.ttpSliderIndicator.UseFading = false;
            // 
            // lblTimeOne
            // 
            this.lblTimeOne.AutoSize = true;
            this.lblTimeOne.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOne.Location = new System.Drawing.Point(150, 91);
            this.lblTimeOne.Name = "lblTimeOne";
            this.lblTimeOne.Size = new System.Drawing.Size(72, 16);
            this.lblTimeOne.TabIndex = 10;
            this.lblTimeOne.Text = "CurrentTime";
            this.ttpGeneralTip.SetToolTip(this.lblTimeOne, "Click to change between current / remaining time");
            this.lblTimeOne.Click += new System.EventHandler(this.lblTimeOne_Click);
            // 
            // lblTimeTwo
            // 
            this.lblTimeTwo.AutoSize = true;
            this.lblTimeTwo.Location = new System.Drawing.Point(647, 92);
            this.lblTimeTwo.Name = "lblTimeTwo";
            this.lblTimeTwo.Size = new System.Drawing.Size(58, 16);
            this.lblTimeTwo.TabIndex = 11;
            this.lblTimeTwo.Text = "TotalTime";
            // 
            // pcbSliderBar
            // 
            this.pcbSliderBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.pcbSliderBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbSliderBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pcbSliderBar.Location = new System.Drawing.Point(147, 113);
            this.pcbSliderBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcbSliderBar.Name = "pcbSliderBar";
            this.pcbSliderBar.Size = new System.Drawing.Size(577, 30);
            this.pcbSliderBar.TabIndex = 12;
            this.pcbSliderBar.TabStop = false;
            this.ttpGeneralTip.SetToolTip(this.pcbSliderBar, "Tracker bar");
            this.pcbSliderBar.Paint += new System.Windows.Forms.PaintEventHandler(this.picSliderBar_Paint);
            this.pcbSliderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbSliderBar_MouseDown);
            this.pcbSliderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbSliderBar_MouseMove);
            this.pcbSliderBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picSliderBar_MouseUp);
            // 
            // picBoxAlbumArt
            // 
            this.picBoxAlbumArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxAlbumArt.Image = global::MALT_Music.Properties.Resources.logo;
            this.picBoxAlbumArt.Location = new System.Drawing.Point(12, 14);
            this.picBoxAlbumArt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxAlbumArt.Name = "picBoxAlbumArt";
            this.picBoxAlbumArt.Size = new System.Drawing.Size(129, 128);
            this.picBoxAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAlbumArt.TabIndex = 5;
            this.picBoxAlbumArt.TabStop = false;
            this.ttpGeneralTip.SetToolTip(this.picBoxAlbumArt, "Album art");
            // 
            // pcbPlay
            // 
            this.pcbPlay.Enabled = false;
            this.pcbPlay.Image = global::MALT_Music.Properties.Resources.playtrack;
            this.pcbPlay.Location = new System.Drawing.Point(434, 11);
            this.pcbPlay.Name = "pcbPlay";
            this.pcbPlay.Size = new System.Drawing.Size(50, 50);
            this.pcbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPlay.TabIndex = 13;
            this.pcbPlay.TabStop = false;
            this.ttpGeneralTip.SetToolTip(this.pcbPlay, "Play / Pause current track");
            this.pcbPlay.Click += new System.EventHandler(this.pcbPlay_Click);
            // 
            // pcbVolume
            // 
            this.pcbVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pcbVolume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbVolume.Location = new System.Drawing.Point(290, 88);
            this.pcbVolume.Name = "pcbVolume";
            this.pcbVolume.Size = new System.Drawing.Size(194, 19);
            this.pcbVolume.TabIndex = 14;
            this.pcbVolume.TabStop = false;
            this.ttpGeneralTip.SetToolTip(this.pcbVolume, "Volume control");
            this.pcbVolume.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbVolume_Paint);
            this.pcbVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbVolume_MouseDown);
            this.pcbVolume.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbVolume_MouseMove);
            this.pcbVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbVolume_MouseUp);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(233, 88);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(51, 16);
            this.lblVolume.TabIndex = 15;
            this.lblVolume.Text = "Volume:";
            // 
            // lblVolumeLevel
            // 
            this.lblVolumeLevel.AutoSize = true;
            this.lblVolumeLevel.Location = new System.Drawing.Point(490, 88);
            this.lblVolumeLevel.Name = "lblVolumeLevel";
            this.lblVolumeLevel.Size = new System.Drawing.Size(24, 16);
            this.lblVolumeLevel.TabIndex = 16;
            this.lblVolumeLevel.Text = "Vol";
            this.ttpGeneralTip.SetToolTip(this.lblVolumeLevel, "Volume level");
            // 
            // pcbForwardSkip
            // 
            this.pcbForwardSkip.Image = global::MALT_Music.Properties.Resources.NextTrackwhite;
            this.pcbForwardSkip.Location = new System.Drawing.Point(490, 12);
            this.pcbForwardSkip.Name = "pcbForwardSkip";
            this.pcbForwardSkip.Size = new System.Drawing.Size(50, 50);
            this.pcbForwardSkip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbForwardSkip.TabIndex = 17;
            this.pcbForwardSkip.TabStop = false;
            this.ttpGeneralTip.SetToolTip(this.pcbForwardSkip, "Skip to next track in the playlist");
            this.pcbForwardSkip.Click += new System.EventHandler(this.pcbForwardSkip_Click);
            // 
            // pcbBackSkip
            // 
            this.pcbBackSkip.Image = global::MALT_Music.Properties.Resources.prevtrackwhite;
            this.pcbBackSkip.Location = new System.Drawing.Point(378, 12);
            this.pcbBackSkip.Name = "pcbBackSkip";
            this.pcbBackSkip.Size = new System.Drawing.Size(50, 50);
            this.pcbBackSkip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBackSkip.TabIndex = 18;
            this.pcbBackSkip.TabStop = false;
            this.ttpGeneralTip.SetToolTip(this.pcbBackSkip, "Skip to previous track in the playlist");
            this.pcbBackSkip.Click += new System.EventHandler(this.pcbBackSkip_Click);
            // 
            // ttpGeneralTip
            // 
            this.ttpGeneralTip.AutoPopDelay = 5000;
            this.ttpGeneralTip.InitialDelay = 250;
            this.ttpGeneralTip.ReshowDelay = 0;
            // 
            // frmMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1114, 156);
            this.ControlBox = false;
            this.Controls.Add(this.pcbBackSkip);
            this.Controls.Add(this.pcbForwardSkip);
            this.Controls.Add(this.lblVolumeLevel);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.pcbVolume);
            this.Controls.Add(this.pcbPlay);
            this.Controls.Add(this.pcbSliderBar);
            this.Controls.Add(this.lblTimeTwo);
            this.Controls.Add(this.lblTimeOne);
            this.Controls.Add(this.grpRepeat);
            this.Controls.Add(this.picBoxAlbumArt);
            this.Controls.Add(this.lblPlayerStatus);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1130, 195);
            this.MinimumSize = new System.Drawing.Size(1130, 195);
            this.Name = "frmMusicPlayer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.frmMusicPlayer_Load);
            this.grpRepeat.ResumeLayout(false);
            this.grpRepeat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSliderBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlbumArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbForwardSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackSkip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAlbumArt;
        private System.Windows.Forms.Timer tmrTracker;
        private System.Windows.Forms.GroupBox grpRepeat;
        private System.Windows.Forms.RadioButton rbnPlaylist;
        private System.Windows.Forms.RadioButton rbnOnce;
        private System.Windows.Forms.RadioButton rbnCurrent;
        private System.Windows.Forms.RadioButton rbnNone;
        private System.Windows.Forms.PictureBox pcbSliderBar;
        private System.Windows.Forms.Label lblPlayerStatus;
        private System.Windows.Forms.ToolTip ttpSliderIndicator;
        private System.Windows.Forms.Label lblTimeOne;
        private System.Windows.Forms.Label lblTimeTwo;
        private System.Windows.Forms.PictureBox pcbPlay;
        private System.Windows.Forms.PictureBox pcbVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.ToolTip ttpVolumeIndicator;
        private System.Windows.Forms.Label lblVolumeLevel;
        private System.Windows.Forms.PictureBox pcbForwardSkip;
        private System.Windows.Forms.PictureBox pcbBackSkip;
        private System.Windows.Forms.ToolTip ttpGeneralTip;
    }
}