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
            this.rbnAndrewIsA = new System.Windows.Forms.RadioButton();
            this.rbnPlaylist = new System.Windows.Forms.RadioButton();
            this.rbnOnce = new System.Windows.Forms.RadioButton();
            this.rbnCurrent = new System.Windows.Forms.RadioButton();
            this.rbnNone = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTimeOne = new System.Windows.Forms.Label();
            this.lblTimeTwo = new System.Windows.Forms.Label();
            this.pcbSliderBar = new System.Windows.Forms.PictureBox();
            this.ttpSliderIndicator = new System.Windows.Forms.ToolTip(this.components);
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnTemp = new System.Windows.Forms.Button();
            this.lblTimerChecker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlbumArt)).BeginInit();
            this.grpRepeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSliderBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.Location = new System.Drawing.Point(149, 12);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(108, 30);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStop.Location = new System.Drawing.Point(263, 12);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 30);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
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
            // tmrTracker
            // 
            this.tmrTracker.Interval = 1000;
            this.tmrTracker.Tick += new System.EventHandler(this.tmrTracker_Tick);
            // 
            // grpRepeat
            // 
            this.grpRepeat.Controls.Add(this.rbnAndrewIsA);
            this.grpRepeat.Controls.Add(this.rbnPlaylist);
            this.grpRepeat.Controls.Add(this.rbnOnce);
            this.grpRepeat.Controls.Add(this.rbnCurrent);
            this.grpRepeat.Controls.Add(this.rbnNone);
            this.grpRepeat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRepeat.ForeColor = System.Drawing.Color.White;
            this.grpRepeat.Location = new System.Drawing.Point(727, 12);
            this.grpRepeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRepeat.Name = "grpRepeat";
            this.grpRepeat.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRepeat.Size = new System.Drawing.Size(143, 130);
            this.grpRepeat.TabIndex = 8;
            this.grpRepeat.TabStop = false;
            this.grpRepeat.Text = "Repeat Options";
            // 
            // rbnAndrewIsA
            // 
            this.rbnAndrewIsA.AutoSize = true;
            this.rbnAndrewIsA.Location = new System.Drawing.Point(7, 103);
            this.rbnAndrewIsA.Name = "rbnAndrewIsA";
            this.rbnAndrewIsA.Size = new System.Drawing.Size(98, 20);
            this.rbnAndrewIsA.TabIndex = 4;
            this.rbnAndrewIsA.TabStop = true;
            this.rbnAndrewIsA.Text = "Andrew Is a...";
            this.rbnAndrewIsA.UseVisualStyleBackColor = true;
            this.rbnAndrewIsA.Click += new System.EventHandler(this.rbnAndrewIsA_CheckedChanged);
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
            // lblTimeOne
            // 
            this.lblTimeOne.AutoSize = true;
            this.lblTimeOne.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOne.Location = new System.Drawing.Point(150, 76);
            this.lblTimeOne.Name = "lblTimeOne";
            this.lblTimeOne.Size = new System.Drawing.Size(72, 16);
            this.lblTimeOne.TabIndex = 10;
            this.lblTimeOne.Text = "CurrentTime";
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
            this.pcbSliderBar.Location = new System.Drawing.Point(147, 96);
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
            // ttpSliderIndicator
            // 
            this.ttpSliderIndicator.UseAnimation = false;
            this.ttpSliderIndicator.UseFading = false;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(374, 35);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(109, 16);
            this.lblPosition.TabIndex = 13;
            this.lblPosition.Text = "Diret Position Value";
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(507, 12);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(75, 23);
            this.btnTemp.TabIndex = 0;
            // 
            // lblTimerChecker
            // 
            this.lblTimerChecker.AutoSize = true;
            this.lblTimerChecker.Location = new System.Drawing.Point(374, 19);
            this.lblTimerChecker.Name = "lblTimerChecker";
            this.lblTimerChecker.Size = new System.Drawing.Size(41, 16);
            this.lblTimerChecker.TabIndex = 14;
            this.lblTimerChecker.Text = "label1";
            // 
            // frmMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1114, 156);
            this.ControlBox = false;
            this.Controls.Add(this.lblTimerChecker);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.lblPosition);
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
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1130, 195);
            this.MinimumSize = new System.Drawing.Size(1130, 195);
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
        private System.Windows.Forms.RadioButton rbnAndrewIsA;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Label lblTimerChecker;
    }
}