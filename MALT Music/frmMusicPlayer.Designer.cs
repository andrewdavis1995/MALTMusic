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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.ofdMusicOpener = new System.Windows.Forms.OpenFileDialog();
            this.picBoxAlbumArt = new System.Windows.Forms.PictureBox();
            this.prbTrackBar = new System.Windows.Forms.ProgressBar();
            this.tmrTracker = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.grpRepeat = new System.Windows.Forms.GroupBox();
            this.rbnNone = new System.Windows.Forms.RadioButton();
            this.rbnCurrent = new System.Windows.Forms.RadioButton();
            this.rbnOnce = new System.Windows.Forms.RadioButton();
            this.rbnPlaylist = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlbumArt)).BeginInit();
            this.grpRepeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.Location = new System.Drawing.Point(225, 93);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(93, 24);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStop.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStop.Location = new System.Drawing.Point(423, 93);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(93, 24);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTest.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTest.Location = new System.Drawing.Point(324, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(93, 24);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Load Test File";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.openTest);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOpen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpen.Location = new System.Drawing.Point(225, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(93, 24);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFileName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFileName.Location = new System.Drawing.Point(222, 77);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 14);
            this.lblFileName.TabIndex = 4;
            // 
            // ofdMusicOpener
            // 
            this.ofdMusicOpener.FileName = "Test.mp3";
            this.ofdMusicOpener.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdMusicOpener_FileOk);
            // 
            // picBoxAlbumArt
            // 
            this.picBoxAlbumArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxAlbumArt.ErrorImage = global::MALT_Music.Properties.Resources.logo;
            this.picBoxAlbumArt.Image = global::MALT_Music.Properties.Resources.logo;
            this.picBoxAlbumArt.InitialImage = global::MALT_Music.Properties.Resources.logo;
            this.picBoxAlbumArt.Location = new System.Drawing.Point(108, 12);
            this.picBoxAlbumArt.Name = "picBoxAlbumArt";
            this.picBoxAlbumArt.Size = new System.Drawing.Size(111, 105);
            this.picBoxAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAlbumArt.TabIndex = 5;
            this.picBoxAlbumArt.TabStop = false;
            // 
            // prbTrackBar
            // 
            this.prbTrackBar.Location = new System.Drawing.Point(225, 64);
            this.prbTrackBar.Name = "prbTrackBar";
            this.prbTrackBar.Size = new System.Drawing.Size(390, 10);
            this.prbTrackBar.Step = 1;
            this.prbTrackBar.TabIndex = 6;
            // 
            // tmrTracker
            // 
            this.tmrTracker.Interval = 1000;
            this.tmrTracker.Tick += new System.EventHandler(this.tmrTracker_Tick);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPause.Location = new System.Drawing.Point(324, 94);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(93, 23);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // grpRepeat
            // 
            this.grpRepeat.Controls.Add(this.rbnPlaylist);
            this.grpRepeat.Controls.Add(this.rbnOnce);
            this.grpRepeat.Controls.Add(this.rbnCurrent);
            this.grpRepeat.Controls.Add(this.rbnNone);
            this.grpRepeat.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRepeat.ForeColor = System.Drawing.Color.White;
            this.grpRepeat.Location = new System.Drawing.Point(526, 76);
            this.grpRepeat.Name = "grpRepeat";
            this.grpRepeat.Size = new System.Drawing.Size(286, 41);
            this.grpRepeat.TabIndex = 8;
            this.grpRepeat.TabStop = false;
            this.grpRepeat.Text = "Repeat Options";
            // 
            // rbnNone
            // 
            this.rbnNone.AutoSize = true;
            this.rbnNone.Checked = true;
            this.rbnNone.Location = new System.Drawing.Point(6, 19);
            this.rbnNone.Name = "rbnNone";
            this.rbnNone.Size = new System.Drawing.Size(53, 18);
            this.rbnNone.TabIndex = 0;
            this.rbnNone.TabStop = true;
            this.rbnNone.Text = "None";
            this.rbnNone.UseVisualStyleBackColor = true;
            // 
            // rbnCurrent
            // 
            this.rbnCurrent.AutoSize = true;
            this.rbnCurrent.Location = new System.Drawing.Point(124, 17);
            this.rbnCurrent.Name = "rbnCurrent";
            this.rbnCurrent.Size = new System.Drawing.Size(74, 18);
            this.rbnCurrent.TabIndex = 1;
            this.rbnCurrent.TabStop = true;
            this.rbnCurrent.Text = "Current";
            this.rbnCurrent.UseVisualStyleBackColor = true;
            // 
            // rbnOnce
            // 
            this.rbnOnce.AutoSize = true;
            this.rbnOnce.Location = new System.Drawing.Point(65, 17);
            this.rbnOnce.Name = "rbnOnce";
            this.rbnOnce.Size = new System.Drawing.Size(53, 18);
            this.rbnOnce.TabIndex = 2;
            this.rbnOnce.TabStop = true;
            this.rbnOnce.Text = "Once";
            this.rbnOnce.UseVisualStyleBackColor = true;
            // 
            // rbnPlaylist
            // 
            this.rbnPlaylist.AutoSize = true;
            this.rbnPlaylist.Location = new System.Drawing.Point(204, 17);
            this.rbnPlaylist.Name = "rbnPlaylist";
            this.rbnPlaylist.Size = new System.Drawing.Size(81, 18);
            this.rbnPlaylist.TabIndex = 3;
            this.rbnPlaylist.TabStop = true;
            this.rbnPlaylist.Text = "Playlist";
            this.rbnPlaylist.UseVisualStyleBackColor = true;
            // 
            // frmMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(927, 127);
            this.ControlBox = false;
            this.Controls.Add(this.grpRepeat);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.prbTrackBar);
            this.Controls.Add(this.picBoxAlbumArt);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.MaximumSize = new System.Drawing.Size(943, 166);
            this.MinimumSize = new System.Drawing.Size(943, 166);
            this.Name = "frmMusicPlayer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlbumArt)).EndInit();
            this.grpRepeat.ResumeLayout(false);
            this.grpRepeat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.OpenFileDialog ofdMusicOpener;
        private System.Windows.Forms.PictureBox picBoxAlbumArt;
        private System.Windows.Forms.ProgressBar prbTrackBar;
        private System.Windows.Forms.Timer tmrTracker;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox grpRepeat;
        private System.Windows.Forms.RadioButton rbnPlaylist;
        private System.Windows.Forms.RadioButton rbnOnce;
        private System.Windows.Forms.RadioButton rbnCurrent;
        private System.Windows.Forms.RadioButton rbnNone;
    }
}