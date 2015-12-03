namespace MALT_Music
{
    partial class Recommendations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recommendations));
            this.picSelectedArt = new System.Windows.Forms.PictureBox();
            this.lblSelectedSongName = new System.Windows.Forms.Label();
            this.lblSelectedSongArtist = new System.Windows.Forms.Label();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.lblAddditionalInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // picSelectedArt
            // 
            this.picSelectedArt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSelectedArt.BackgroundImage")));
            this.picSelectedArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSelectedArt.Location = new System.Drawing.Point(512, 50);
            this.picSelectedArt.Name = "picSelectedArt";
            this.picSelectedArt.Size = new System.Drawing.Size(50, 50);
            this.picSelectedArt.TabIndex = 0;
            this.picSelectedArt.TabStop = false;
            // 
            // lblSelectedSongName
            // 
            this.lblSelectedSongName.AutoSize = true;
            this.lblSelectedSongName.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedSongName.ForeColor = System.Drawing.Color.White;
            this.lblSelectedSongName.Location = new System.Drawing.Point(565, 50);
            this.lblSelectedSongName.Name = "lblSelectedSongName";
            this.lblSelectedSongName.Size = new System.Drawing.Size(116, 26);
            this.lblSelectedSongName.TabIndex = 1;
            this.lblSelectedSongName.Text = "Song Name";
            // 
            // lblSelectedSongArtist
            // 
            this.lblSelectedSongArtist.AutoSize = true;
            this.lblSelectedSongArtist.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedSongArtist.ForeColor = System.Drawing.Color.White;
            this.lblSelectedSongArtist.Location = new System.Drawing.Point(568, 76);
            this.lblSelectedSongArtist.Name = "lblSelectedSongArtist";
            this.lblSelectedSongArtist.Size = new System.Drawing.Size(73, 17);
            this.lblSelectedSongArtist.TabIndex = 2;
            this.lblSelectedSongArtist.Text = "Artist Name";
            // 
            // picPlay
            // 
            this.picPlay.BackgroundImage = global::MALT_Music.Properties.Resources.playtrack;
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPlay.Location = new System.Drawing.Point(518, 101);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(36, 35);
            this.picPlay.TabIndex = 3;
            this.picPlay.TabStop = false;
            // 
            // lblAddditionalInfo
            // 
            this.lblAddditionalInfo.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddditionalInfo.ForeColor = System.Drawing.Color.White;
            this.lblAddditionalInfo.Location = new System.Drawing.Point(568, 114);
            this.lblAddditionalInfo.Name = "lblAddditionalInfo";
            this.lblAddditionalInfo.Size = new System.Drawing.Size(229, 177);
            this.lblAddditionalInfo.TabIndex = 4;
            this.lblAddditionalInfo.Text = "Additional Info\r\nWIll go here\r\n\r\nI hope i remember to remove\r\nthis label \r\nbefore" +
    " demo-ing\r\n\r\nIf not, oops!\r\n\r\nhey datastax people";
            // 
            // Recommendations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(857, 290);
            this.Controls.Add(this.lblAddditionalInfo);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.lblSelectedSongArtist);
            this.Controls.Add(this.lblSelectedSongName);
            this.Controls.Add(this.picSelectedArt);
            this.Name = "Recommendations";
            this.Text = "Recommendations";
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSelectedArt;
        private System.Windows.Forms.Label lblSelectedSongName;
        private System.Windows.Forms.Label lblSelectedSongArtist;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.Label lblAddditionalInfo;

    }
}