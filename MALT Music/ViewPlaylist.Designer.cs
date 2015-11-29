namespace MALT_Music
{
    partial class ViewPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPlaylist));
            this.coverImage1 = new System.Windows.Forms.PictureBox();
            this.coverImage2 = new System.Windows.Forms.PictureBox();
            this.coverImage4 = new System.Windows.Forms.PictureBox();
            this.coverImage3 = new System.Windows.Forms.PictureBox();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage3)).BeginInit();
            this.SuspendLayout();
            // 
            // coverImage1
            // 
            this.coverImage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coverImage1.BackgroundImage")));
            this.coverImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverImage1.Location = new System.Drawing.Point(265, 156);
            this.coverImage1.Name = "coverImage1";
            this.coverImage1.Size = new System.Drawing.Size(44, 44);
            this.coverImage1.TabIndex = 0;
            this.coverImage1.TabStop = false;
            // 
            // coverImage2
            // 
            this.coverImage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coverImage2.BackgroundImage")));
            this.coverImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverImage2.Location = new System.Drawing.Point(309, 156);
            this.coverImage2.Name = "coverImage2";
            this.coverImage2.Size = new System.Drawing.Size(44, 44);
            this.coverImage2.TabIndex = 1;
            this.coverImage2.TabStop = false;
            // 
            // coverImage4
            // 
            this.coverImage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coverImage4.BackgroundImage")));
            this.coverImage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverImage4.Location = new System.Drawing.Point(309, 196);
            this.coverImage4.Name = "coverImage4";
            this.coverImage4.Size = new System.Drawing.Size(44, 44);
            this.coverImage4.TabIndex = 3;
            this.coverImage4.TabStop = false;
            // 
            // coverImage3
            // 
            this.coverImage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coverImage3.BackgroundImage")));
            this.coverImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coverImage3.Location = new System.Drawing.Point(265, 196);
            this.coverImage3.Name = "coverImage3";
            this.coverImage3.Size = new System.Drawing.Size(44, 44);
            this.coverImage3.TabIndex = 2;
            this.coverImage3.TabStop = false;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.ForeColor = System.Drawing.Color.White;
            this.lblPlaylistName.Location = new System.Drawing.Point(257, 96);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(237, 37);
            this.lblPlaylistName.TabIndex = 4;
            this.lblPlaylistName.Text = "PLAYLIST NAME";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.ForeColor = System.Drawing.Color.White;
            this.lblOwner.Location = new System.Drawing.Point(261, 132);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(50, 20);
            this.lblOwner.TabIndex = 5;
            this.lblOwner.Text = "Owner";
            // 
            // ViewPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1129, 442);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.coverImage4);
            this.Controls.Add(this.coverImage3);
            this.Controls.Add(this.coverImage2);
            this.Controls.Add(this.coverImage1);
            this.Name = "ViewPlaylist";
            this.Text = "ViewPlaylist";
            ((System.ComponentModel.ISupportInitialize)(this.coverImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverImage1;
        private System.Windows.Forms.PictureBox coverImage2;
        private System.Windows.Forms.PictureBox coverImage4;
        private System.Windows.Forms.PictureBox coverImage3;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.Label lblOwner;
    }
}