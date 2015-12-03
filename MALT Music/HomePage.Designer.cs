namespace MALT_Music
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.picBoxMagnifyingGlass = new System.Windows.Forms.PictureBox();
            this.picBoxMALTLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxProfPicThumb = new MALT_Music.OvalPictureBox();
            this.picBoxPlaylist = new System.Windows.Forms.PictureBox();
            this.picBoxLogout = new System.Windows.Forms.PictureBox();
            this.picBoxBackground = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMagnifyingGlass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMALTLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfPicThumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFullName.Location = new System.Drawing.Point(66, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(164, 54);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLogout.Location = new System.Drawing.Point(82, 273);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(66, 20);
            this.lblLogout.TabIndex = 4;
            this.lblLogout.Text = "Log Out";
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPlaylist.Location = new System.Drawing.Point(82, 151);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(65, 20);
            this.lblPlaylist.TabIndex = 2;
            this.lblPlaylist.Text = "Playlists";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearchBox.Location = new System.Drawing.Point(384, 18);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(539, 33);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.Text = "Search for songs, artists and albums...";
            this.txtSearchBox.Enter += new System.EventHandler(this.txtSearchBox_Enter);
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyDown);
            this.txtSearchBox.Leave += new System.EventHandler(this.txtSearchBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.picBoxMagnifyingGlass);
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Controls.Add(this.picBoxMALTLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 89);
            this.panel1.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(930, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 33);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "GO";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // picBoxMagnifyingGlass
            // 
            this.picBoxMagnifyingGlass.Image = global::MALT_Music.Properties.Resources.Magnifying_glass_icon_white;
            this.picBoxMagnifyingGlass.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxMagnifyingGlass.InitialImage")));
            this.picBoxMagnifyingGlass.Location = new System.Drawing.Point(324, 12);
            this.picBoxMagnifyingGlass.Name = "picBoxMagnifyingGlass";
            this.picBoxMagnifyingGlass.Size = new System.Drawing.Size(50, 47);
            this.picBoxMagnifyingGlass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMagnifyingGlass.TabIndex = 1;
            this.picBoxMagnifyingGlass.TabStop = false;
            // 
            // picBoxMALTLogo
            // 
            this.picBoxMALTLogo.Image = global::MALT_Music.Properties.Resources.logo;
            this.picBoxMALTLogo.Location = new System.Drawing.Point(48, 8);
            this.picBoxMALTLogo.Name = "picBoxMALTLogo";
            this.picBoxMALTLogo.Size = new System.Drawing.Size(135, 73);
            this.picBoxMALTLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMALTLogo.TabIndex = 2;
            this.picBoxMALTLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.picBoxProfPicThumb);
            this.panel2.Controls.Add(this.lblFullName);
            this.panel2.Controls.Add(this.picBoxPlaylist);
            this.panel2.Controls.Add(this.lblLogout);
            this.panel2.Controls.Add(this.lblPlaylist);
            this.panel2.Controls.Add(this.picBoxLogout);
            this.panel2.Location = new System.Drawing.Point(-3, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 313);
            this.panel2.TabIndex = 7;
            // 
            // picBoxProfPicThumb
            // 
            this.picBoxProfPicThumb.BackColor = System.Drawing.Color.LightGray;
            this.picBoxProfPicThumb.Image = global::MALT_Music.Properties.Resources.iconprofile;
            this.picBoxProfPicThumb.Location = new System.Drawing.Point(11, 9);
            this.picBoxProfPicThumb.Name = "picBoxProfPicThumb";
            this.picBoxProfPicThumb.Size = new System.Drawing.Size(50, 50);
            this.picBoxProfPicThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProfPicThumb.TabIndex = 5;
            this.picBoxProfPicThumb.TabStop = false;
            this.picBoxProfPicThumb.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // picBoxPlaylist
            // 
            this.picBoxPlaylist.Image = global::MALT_Music.Properties.Resources.List_white;
            this.picBoxPlaylist.Location = new System.Drawing.Point(74, 76);
            this.picBoxPlaylist.Name = "picBoxPlaylist";
            this.picBoxPlaylist.Size = new System.Drawing.Size(81, 72);
            this.picBoxPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlaylist.TabIndex = 1;
            this.picBoxPlaylist.TabStop = false;
            this.picBoxPlaylist.Click += new System.EventHandler(this.picBoxPlaylist_Click);
            // 
            // picBoxLogout
            // 
            this.picBoxLogout.Image = global::MALT_Music.Properties.Resources.logout;
            this.picBoxLogout.Location = new System.Drawing.Point(74, 196);
            this.picBoxLogout.Name = "picBoxLogout";
            this.picBoxLogout.Size = new System.Drawing.Size(81, 72);
            this.picBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogout.TabIndex = 3;
            this.picBoxLogout.TabStop = false;
            this.picBoxLogout.Click += new System.EventHandler(this.picBoxLogout_Click);
            // 
            // picBoxBackground
            // 
            this.picBoxBackground.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBoxBackground.Image = global::MALT_Music.Properties.Resources.loadingplaceholder;
            this.picBoxBackground.Location = new System.Drawing.Point(227, 87);
            this.picBoxBackground.Name = "picBoxBackground";
            this.picBoxBackground.Size = new System.Drawing.Size(886, 313);
            this.picBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBackground.TabIndex = 9;
            this.picBoxBackground.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 586);
            this.Controls.Add(this.picBoxBackground);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.Text = "MALT Music";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMagnifyingGlass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMALTLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfPicThumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.PictureBox picBoxMagnifyingGlass;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.PictureBox picBoxMALTLogo;
        private System.Windows.Forms.PictureBox picBoxPlaylist;
        private System.Windows.Forms.PictureBox picBoxLogout;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private OvalPictureBox picBoxProfPicThumb;
        private System.Windows.Forms.PictureBox picBoxBackground;

    }
}

