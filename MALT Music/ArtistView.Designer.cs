namespace MALT_Music
{
    partial class ArtistView
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
            this.lblArtistName = new System.Windows.Forms.Label();
            this.pnlTopInfo = new System.Windows.Forms.Panel();
            this.lblNumAlbums = new System.Windows.Forms.Label();
            this.lblPopularity = new System.Windows.Forms.Label();
            this.picUp = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTopInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.BackColor = System.Drawing.Color.Black;
            this.lblArtistName.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.ForeColor = System.Drawing.Color.White;
            this.lblArtistName.Location = new System.Drawing.Point(3, 0);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(132, 43);
            this.lblArtistName.TabIndex = 0;
            this.lblArtistName.Text = "ARTIST";
            // 
            // pnlTopInfo
            // 
            this.pnlTopInfo.Controls.Add(this.lblNumAlbums);
            this.pnlTopInfo.Controls.Add(this.lblPopularity);
            this.pnlTopInfo.Controls.Add(this.lblArtistName);
            this.pnlTopInfo.Location = new System.Drawing.Point(12, 3);
            this.pnlTopInfo.Name = "pnlTopInfo";
            this.pnlTopInfo.Size = new System.Drawing.Size(858, 97);
            this.pnlTopInfo.TabIndex = 1;
            // 
            // lblNumAlbums
            // 
            this.lblNumAlbums.AutoSize = true;
            this.lblNumAlbums.BackColor = System.Drawing.Color.Black;
            this.lblNumAlbums.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAlbums.ForeColor = System.Drawing.Color.White;
            this.lblNumAlbums.Location = new System.Drawing.Point(7, 71);
            this.lblNumAlbums.Name = "lblNumAlbums";
            this.lblNumAlbums.Size = new System.Drawing.Size(145, 20);
            this.lblNumAlbums.TabIndex = 2;
            this.lblNumAlbums.Text = "Number of Albums: 0";
            // 
            // lblPopularity
            // 
            this.lblPopularity.AutoSize = true;
            this.lblPopularity.BackColor = System.Drawing.Color.Black;
            this.lblPopularity.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopularity.ForeColor = System.Drawing.Color.White;
            this.lblPopularity.Location = new System.Drawing.Point(7, 47);
            this.lblPopularity.Name = "lblPopularity";
            this.lblPopularity.Size = new System.Drawing.Size(103, 20);
            this.lblPopularity.TabIndex = 1;
            this.lblPopularity.Text = "Popularity: 0%";
            // 
            // picUp
            // 
            this.picUp.BackgroundImage = global::MALT_Music.Properties.Resources.upvote;
            this.picUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUp.Location = new System.Drawing.Point(823, 121);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(30, 22);
            this.picUp.TabIndex = 2;
            this.picUp.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MALT_Music.Properties.Resources.downvote;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(823, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 22);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ArtistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picUp);
            this.Controls.Add(this.pnlTopInfo);
            this.Name = "ArtistView";
            this.Text = "ArtistView";
            this.pnlTopInfo.ResumeLayout(false);
            this.pnlTopInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Panel pnlTopInfo;
        private System.Windows.Forms.Label lblNumAlbums;
        private System.Windows.Forms.Label lblPopularity;
        private System.Windows.Forms.PictureBox picUp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}