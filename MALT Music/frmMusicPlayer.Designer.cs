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
            this.lblFileName = new System.Windows.Forms.Label();
            this.picBoxAlbumArt = new System.Windows.Forms.PictureBox();
            this.tmrTracker = new System.Windows.Forms.Timer(this.components);
            this.grpRepeat = new System.Windows.Forms.GroupBox();
            this.rbnPlaylist = new System.Windows.Forms.RadioButton();
            this.rbnOnce = new System.Windows.Forms.RadioButton();
            this.rbnCurrent = new System.Windows.Forms.RadioButton();
            this.rbnNone = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTimeOne = new System.Windows.Forms.Label();
            this.lblTimeTwo = new System.Windows.Forms.Label();
            this.pcbSliderBar = new System.Windows.Forms.PictureBox();
            this.ttpSliderIndicator = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlbumArt)).BeginInit();
            this.grpRepeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSliderBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.Location = new System.Drawing.Point(147, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(108, 26);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStop.Location = new System.Drawing.Point(261, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 26);
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
            this.btnTest.Location = new System.Drawing.Point(621, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(108, 26);
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
            this.lblFileName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFileName.Location = new System.Drawing.Point(250, 51);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(479, 15);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "No file selected";
            // 
            // picBoxAlbumArt
            // 
            this.picBoxAlbumArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxAlbumArt.ErrorImage = global::MALT_Music.Properties.Resources.logo;
            this.picBoxAlbumArt.Image = global::MALT_Music.Properties.Resources.logo;
            this.picBoxAlbumArt.InitialImage = global::MALT_Music.Properties.Resources.logo;
            this.picBoxAlbumArt.Location = new System.Drawing.Point(12, 12);
            this.picBoxAlbumArt.Name = "picBoxAlbumArt";
            this.picBoxAlbumArt.Size = new System.Drawing.Size(129, 113);
            this.picBoxAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAlbumArt.TabIndex = 5;
            this.picBoxAlbumArt.TabStop = false;
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
            this.grpRepeat.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRepeat.ForeColor = System.Drawing.Color.White;
            this.grpRepeat.Location = new System.Drawing.Point(735, 22);
            this.grpRepeat.Name = "grpRepeat";
            this.grpRepeat.Size = new System.Drawing.Size(334, 44);
            this.grpRepeat.TabIndex = 8;
            this.grpRepeat.TabStop = false;
            this.grpRepeat.Text = "Repeat Options";
            // 
            // rbnPlaylist
            // 
            this.rbnPlaylist.AutoSize = true;
            this.rbnPlaylist.Location = new System.Drawing.Point(238, 18);
            this.rbnPlaylist.Name = "rbnPlaylist";
            this.rbnPlaylist.Size = new System.Drawing.Size(81, 18);
            this.rbnPlaylist.TabIndex = 3;
            this.rbnPlaylist.TabStop = true;
            this.rbnPlaylist.Text = "Playlist";
            this.rbnPlaylist.UseVisualStyleBackColor = true;
            // 
            // rbnOnce
            // 
            this.rbnOnce.AutoSize = true;
            this.rbnOnce.Location = new System.Drawing.Point(76, 18);
            this.rbnOnce.Name = "rbnOnce";
            this.rbnOnce.Size = new System.Drawing.Size(53, 18);
            this.rbnOnce.TabIndex = 2;
            this.rbnOnce.TabStop = true;
            this.rbnOnce.Text = "Once";
            this.rbnOnce.UseVisualStyleBackColor = true;
            // 
            // rbnCurrent
            // 
            this.rbnCurrent.AutoSize = true;
            this.rbnCurrent.Location = new System.Drawing.Point(145, 18);
            this.rbnCurrent.Name = "rbnCurrent";
            this.rbnCurrent.Size = new System.Drawing.Size(74, 18);
            this.rbnCurrent.TabIndex = 1;
            this.rbnCurrent.TabStop = true;
            this.rbnCurrent.Text = "Current";
            this.rbnCurrent.UseVisualStyleBackColor = true;
            // 
            // rbnNone
            // 
            this.rbnNone.AutoSize = true;
            this.rbnNone.Checked = true;
            this.rbnNone.Location = new System.Drawing.Point(7, 20);
            this.rbnNone.Name = "rbnNone";
            this.rbnNone.Size = new System.Drawing.Size(53, 18);
            this.rbnNone.TabIndex = 0;
            this.rbnNone.TabStop = true;
            this.rbnNone.Text = "None";
            this.rbnNone.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(148, 52);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(105, 14);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Player Status:";
            // 
            // lblTimeOne
            // 
            this.lblTimeOne.AutoSize = true;
            this.lblTimeOne.Location = new System.Drawing.Point(148, 67);
            this.lblTimeOne.Name = "lblTimeOne";
            this.lblTimeOne.Size = new System.Drawing.Size(49, 14);
            this.lblTimeOne.TabIndex = 10;
            this.lblTimeOne.Text = "label1";
            // 
            // lblTimeTwo
            // 
            this.lblTimeTwo.AutoSize = true;
            this.lblTimeTwo.Location = new System.Drawing.Point(1020, 67);
            this.lblTimeTwo.Name = "lblTimeTwo";
            this.lblTimeTwo.Size = new System.Drawing.Size(49, 14);
            this.lblTimeTwo.TabIndex = 11;
            this.lblTimeTwo.Text = "label2";
            // 
            // pcbSliderBar
            // 
            this.pcbSliderBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.pcbSliderBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbSliderBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pcbSliderBar.Location = new System.Drawing.Point(147, 84);
            this.pcbSliderBar.Name = "pcbSliderBar";
            this.pcbSliderBar.Size = new System.Drawing.Size(914, 41);
            this.pcbSliderBar.TabIndex = 12;
            this.pcbSliderBar.TabStop = false;
            this.pcbSliderBar.Paint += new System.Windows.Forms.PaintEventHandler(this.picSliderBar_Paint);
            this.pcbSliderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbSliderBar_MouseDown);
            this.pcbSliderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbSliderBar_MouseMove);
            this.pcbSliderBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picSliderBar_MouseUp);
            // 
            // frmMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1114, 137);
            this.ControlBox = false;
            this.Controls.Add(this.pcbSliderBar);
            this.Controls.Add(this.lblTimeTwo);
            this.Controls.Add(this.lblTimeOne);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpRepeat);
            this.Controls.Add(this.picBoxAlbumArt);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(1130, 176);
            this.MinimumSize = new System.Drawing.Size(1130, 176);
            this.Name = "frmMusicPlayer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.frmMusicPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlbumArt)).EndInit();
            this.grpRepeat.ResumeLayout(false);
            this.grpRepeat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSliderBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox picBoxAlbumArt;
        private System.Windows.Forms.Timer tmrTracker;
        private System.Windows.Forms.GroupBox grpRepeat;
        private System.Windows.Forms.RadioButton rbnPlaylist;
        private System.Windows.Forms.RadioButton rbnOnce;
        private System.Windows.Forms.RadioButton rbnCurrent;
        private System.Windows.Forms.RadioButton rbnNone;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTimeOne;
        private System.Windows.Forms.Label lblTimeTwo;
        private System.Windows.Forms.PictureBox pcbSliderBar;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ToolTip ttpSliderIndicator;
    }
}