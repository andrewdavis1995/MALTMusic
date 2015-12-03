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
            this.btnTest = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.tmrTracker = new System.Windows.Forms.Timer(this.components);
            this.grpRepeat = new System.Windows.Forms.GroupBox();
            this.rbnPlaylist = new System.Windows.Forms.RadioButton();
            this.rbnOnce = new System.Windows.Forms.RadioButton();
            this.rbnCurrent = new System.Windows.Forms.RadioButton();
            this.rbnNone = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
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
            this.grpRepeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSliderBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlbumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbForwardSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackSkip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTest.Location = new System.Drawing.Point(607, 12);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(108, 30);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Load Test File";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.openTest);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoEllipsis = true;
            this.lblFileName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFileName.Location = new System.Drawing.Point(236, 56);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(479, 18);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "No file selected";
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
            this.rbnNone.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(150, 57);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 16);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Player Status:";
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
            this.lblTimeOne.Location = new System.Drawing.Point(150, 76);
            this.lblTimeOne.Name = "lblTimeOne";
            this.lblTimeOne.Size = new System.Drawing.Size(72, 16);
            this.lblTimeOne.TabIndex = 10;
            this.lblTimeOne.Text = "CurrentTime";
            this.lblTimeOne.Click += new System.EventHandler(this.lblTimeOne_Click);
            // 
            // lblTimeTwo
            // 
            this.lblTimeTwo.AutoSize = true;
            this.lblTimeTwo.Location = new System.Drawing.Point(683, 74);
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
            this.pcbSliderBar.Location = new System.Drawing.Point(147, 97);
            this.pcbSliderBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcbSliderBar.Name = "pcbSliderBar";
            this.pcbSliderBar.Size = new System.Drawing.Size(577, 46);
            this.pcbSliderBar.TabIndex = 12;
            this.pcbSliderBar.TabStop = false;
            this.pcbSliderBar.Paint += new System.Windows.Forms.PaintEventHandler(this.picSliderBar_Paint);
            this.pcbSliderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbSliderBar_MouseDown);
            this.pcbSliderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbSliderBar_MouseMove);
            this.pcbSliderBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picSliderBar_MouseUp);
            // 
            // picBoxAlbumArt
            // 
            this.picBoxAlbumArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxAlbumArt.ErrorImage = global::MALT_Music.Properties.Resources.logo;
            this.picBoxAlbumArt.Image = global::MALT_Music.Properties.Resources.logo;
            this.picBoxAlbumArt.InitialImage = global::MALT_Music.Properties.Resources.logo;
            this.picBoxAlbumArt.Location = new System.Drawing.Point(12, 14);
            this.picBoxAlbumArt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxAlbumArt.Name = "picBoxAlbumArt";
            this.picBoxAlbumArt.Size = new System.Drawing.Size(129, 128);
            this.picBoxAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAlbumArt.TabIndex = 5;
            this.picBoxAlbumArt.TabStop = false;
            // 
            // pcbPlay
            // 
            this.pcbPlay.Enabled = false;
            this.pcbPlay.Image = global::MALT_Music.Properties.Resources.playtrack;
            this.pcbPlay.Location = new System.Drawing.Point(434, 3);
            this.pcbPlay.Name = "pcbPlay";
            this.pcbPlay.Size = new System.Drawing.Size(50, 50);
            this.pcbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPlay.TabIndex = 13;
            this.pcbPlay.TabStop = false;
            this.pcbPlay.Click += new System.EventHandler(this.pcbPlay_Click);
            // 
            // pcbVolume
            // 
            this.pcbVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pcbVolume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbVolume.Location = new System.Drawing.Point(290, 76);
            this.pcbVolume.Name = "pcbVolume";
            this.pcbVolume.Size = new System.Drawing.Size(194, 20);
            this.pcbVolume.TabIndex = 14;
            this.pcbVolume.TabStop = false;
            this.pcbVolume.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbVolume_Paint);
            this.pcbVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbVolume_MouseDown);
            this.pcbVolume.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbVolume_MouseMove);
            this.pcbVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbVolume_MouseUp);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(233, 77);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(51, 16);
            this.lblVolume.TabIndex = 15;
            this.lblVolume.Text = "Volume:";
            // 
            // lblVolumeLevel
            // 
            this.lblVolumeLevel.AutoSize = true;
            this.lblVolumeLevel.Location = new System.Drawing.Point(490, 77);
            this.lblVolumeLevel.Name = "lblVolumeLevel";
            this.lblVolumeLevel.Size = new System.Drawing.Size(24, 16);
            this.lblVolumeLevel.TabIndex = 16;
            this.lblVolumeLevel.Text = "Vol";
            // 
            // pcbForwardSkip
            // 
            this.pcbForwardSkip.Enabled = false;
            this.pcbForwardSkip.Image = global::MALT_Music.Properties.Resources.NextTrackwhite;
            this.pcbForwardSkip.Location = new System.Drawing.Point(490, 4);
            this.pcbForwardSkip.Name = "pcbForwardSkip";
            this.pcbForwardSkip.Size = new System.Drawing.Size(50, 50);
            this.pcbForwardSkip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbForwardSkip.TabIndex = 17;
            this.pcbForwardSkip.TabStop = false;
            this.pcbForwardSkip.Click += new System.EventHandler(this.pcbForwardSkip_Click);
            // 
            // pcbBackSkip
            // 
            this.pcbBackSkip.Enabled = false;
            this.pcbBackSkip.Image = global::MALT_Music.Properties.Resources.prevtrackwhite;
            this.pcbBackSkip.Location = new System.Drawing.Point(378, 4);
            this.pcbBackSkip.Name = "pcbBackSkip";
            this.pcbBackSkip.Size = new System.Drawing.Size(50, 50);
            this.pcbBackSkip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBackSkip.TabIndex = 18;
            this.pcbBackSkip.TabStop = false;
            this.pcbBackSkip.Click += new System.EventHandler(this.pcbBackSkip_Click);
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
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpRepeat);
            this.Controls.Add(this.picBoxAlbumArt);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnTest);
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

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox picBoxAlbumArt;
        private System.Windows.Forms.Timer tmrTracker;
        private System.Windows.Forms.GroupBox grpRepeat;
        private System.Windows.Forms.RadioButton rbnPlaylist;
        private System.Windows.Forms.RadioButton rbnOnce;
        private System.Windows.Forms.RadioButton rbnCurrent;
        private System.Windows.Forms.RadioButton rbnNone;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pcbSliderBar;
        private System.Windows.Forms.Label lblFileName;
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
    }
}