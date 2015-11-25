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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.picBoxMALTLogo = new System.Windows.Forms.PictureBox();
            this.picBoxMagnifyingGlass = new System.Windows.Forms.PictureBox();
            this.picBoxBrowse = new System.Windows.Forms.PictureBox();
            this.picBoxPlaylist = new System.Windows.Forms.PictureBox();
            this.lblBrowse = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMALTLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMagnifyingGlass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(55, 16);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(61, 24);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBrowse);
            this.groupBox1.Controls.Add(this.picBoxBrowse);
            this.groupBox1.Controls.Add(this.lblPlaylist);
            this.groupBox1.Controls.Add(this.picBoxPlaylist);
            this.groupBox1.Controls.Add(this.lblFullName);
            this.groupBox1.Location = new System.Drawing.Point(-1, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 296);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // grpBoxSearch
            // 
            this.grpBoxSearch.Controls.Add(this.picBoxMALTLogo);
            this.grpBoxSearch.Controls.Add(this.picBoxMagnifyingGlass);
            this.grpBoxSearch.Controls.Add(this.txtSearchBox);
            this.grpBoxSearch.Location = new System.Drawing.Point(0, -6);
            this.grpBoxSearch.Name = "grpBoxSearch";
            this.grpBoxSearch.Size = new System.Drawing.Size(1056, 71);
            this.grpBoxSearch.TabIndex = 4;
            this.grpBoxSearch.TabStop = false;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(285, 21);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(539, 40);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.Text = "Search for songs, artists and albums...";
            this.txtSearchBox.Enter += new System.EventHandler(this.txtSearchBox_Enter);
            this.txtSearchBox.Leave += new System.EventHandler(this.txtSearchBox_Leave);
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.Location = new System.Drawing.Point(59, 121);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(65, 20);
            this.lblPlaylist.TabIndex = 2;
            this.lblPlaylist.Text = "Playlists";
            // 
            // picBoxMALTLogo
            // 
            this.picBoxMALTLogo.Image = global::MALT_Music.Properties.Resources.logo;
            this.picBoxMALTLogo.Location = new System.Drawing.Point(32, 7);
            this.picBoxMALTLogo.Name = "picBoxMALTLogo";
            this.picBoxMALTLogo.Size = new System.Drawing.Size(125, 62);
            this.picBoxMALTLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMALTLogo.TabIndex = 2;
            this.picBoxMALTLogo.TabStop = false;
            // 
            // picBoxMagnifyingGlass
            // 
            this.picBoxMagnifyingGlass.Image = global::MALT_Music.Properties.Resources.Magnifying_glass_icon;
            this.picBoxMagnifyingGlass.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxMagnifyingGlass.InitialImage")));
            this.picBoxMagnifyingGlass.Location = new System.Drawing.Point(217, 18);
            this.picBoxMagnifyingGlass.Name = "picBoxMagnifyingGlass";
            this.picBoxMagnifyingGlass.Size = new System.Drawing.Size(50, 47);
            this.picBoxMagnifyingGlass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMagnifyingGlass.TabIndex = 1;
            this.picBoxMagnifyingGlass.TabStop = false;
            // 
            // picBoxBrowse
            // 
            this.picBoxBrowse.Image = global::MALT_Music.Properties.Resources.Music_Treble_Clef_icon;
            this.picBoxBrowse.Location = new System.Drawing.Point(52, 153);
            this.picBoxBrowse.Name = "picBoxBrowse";
            this.picBoxBrowse.Size = new System.Drawing.Size(81, 72);
            this.picBoxBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBrowse.TabIndex = 3;
            this.picBoxBrowse.TabStop = false;
            // 
            // picBoxPlaylist
            // 
            this.picBoxPlaylist.Image = global::MALT_Music.Properties.Resources.List;
            this.picBoxPlaylist.Location = new System.Drawing.Point(52, 43);
            this.picBoxPlaylist.Name = "picBoxPlaylist";
            this.picBoxPlaylist.Size = new System.Drawing.Size(81, 72);
            this.picBoxPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlaylist.TabIndex = 1;
            this.picBoxPlaylist.TabStop = false;
            // 
            // lblBrowse
            // 
            this.lblBrowse.AutoSize = true;
            this.lblBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowse.Location = new System.Drawing.Point(62, 228);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(62, 20);
            this.lblBrowse.TabIndex = 4;
            this.lblBrowse.Text = "Browse";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 586);
            this.Controls.Add(this.grpBoxSearch);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Name = "HomePage";
            this.Text = "MALT Music";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxSearch.ResumeLayout(false);
            this.grpBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMALTLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMagnifyingGlass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlaylist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxSearch;
        private System.Windows.Forms.PictureBox picBoxMagnifyingGlass;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.PictureBox picBoxMALTLogo;
        private System.Windows.Forms.PictureBox picBoxPlaylist;
        private System.Windows.Forms.PictureBox picBoxBrowse;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label lblBrowse;

    }
}

