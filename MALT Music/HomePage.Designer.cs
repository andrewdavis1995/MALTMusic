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
            this.lblBrowse = new System.Windows.Forms.Label();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.picBoxMALTLogo = new System.Windows.Forms.PictureBox();
            this.picBoxBrowse = new System.Windows.Forms.PictureBox();
            this.picBoxMagnifyingGlass = new System.Windows.Forms.PictureBox();
            this.picBoxPlaylist = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMALTLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMagnifyingGlass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlaylist)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFullName.Location = new System.Drawing.Point(71, 4);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(61, 24);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrowse
            // 
            this.lblBrowse.AutoSize = true;
            this.lblBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowse.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBrowse.Location = new System.Drawing.Point(82, 241);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(62, 20);
            this.lblBrowse.TabIndex = 4;
            this.lblBrowse.Text = "Browse";
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPlaylist.Location = new System.Drawing.Point(82, 118);
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
            this.txtSearchBox.Leave += new System.EventHandler(this.txtSearchBox_Leave);
            // 
            // picBoxMALTLogo
            // 
            this.picBoxMALTLogo.Image = global::MALT_Music.Properties.Resources.logo;
            this.picBoxMALTLogo.Location = new System.Drawing.Point(44, 8);
            this.picBoxMALTLogo.Name = "picBoxMALTLogo";
            this.picBoxMALTLogo.Size = new System.Drawing.Size(167, 72);
            this.picBoxMALTLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMALTLogo.TabIndex = 2;
            this.picBoxMALTLogo.TabStop = false;
            // 
            // picBoxBrowse
            // 
            this.picBoxBrowse.Image = global::MALT_Music.Properties.Resources.Music_icon_white;
            this.picBoxBrowse.Location = new System.Drawing.Point(74, 167);
            this.picBoxBrowse.Name = "picBoxBrowse";
            this.picBoxBrowse.Size = new System.Drawing.Size(81, 72);
            this.picBoxBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBrowse.TabIndex = 3;
            this.picBoxBrowse.TabStop = false;
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
            // picBoxPlaylist
            // 
            this.picBoxPlaylist.Image = global::MALT_Music.Properties.Resources.List_white;
            this.picBoxPlaylist.Location = new System.Drawing.Point(74, 43);
            this.picBoxPlaylist.Name = "picBoxPlaylist";
            this.picBoxPlaylist.Size = new System.Drawing.Size(81, 72);
            this.picBoxPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlaylist.TabIndex = 1;
            this.picBoxPlaylist.TabStop = false;
            this.picBoxPlaylist.Click += new System.EventHandler(this.picBoxPlaylist_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.lblFullName);
            this.panel2.Controls.Add(this.picBoxPlaylist);
            this.panel2.Controls.Add(this.lblBrowse);
            this.panel2.Controls.Add(this.lblPlaylist);
            this.panel2.Controls.Add(this.picBoxBrowse);
            this.panel2.Location = new System.Drawing.Point(-3, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 323);
            this.panel2.TabIndex = 7;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.Text = "MALT Music";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMALTLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMagnifyingGlass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlaylist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.PictureBox picBoxMagnifyingGlass;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.PictureBox picBoxMALTLogo;
        private System.Windows.Forms.PictureBox picBoxPlaylist;
        private System.Windows.Forms.PictureBox picBoxBrowse;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label lblBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;

    }
}

