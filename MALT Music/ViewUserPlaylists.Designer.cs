namespace MALT_Music
{
    partial class ViewUserPlaylists
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdCreatePlaylist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(290, 92);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Playlists by User: ";
            // 
            // cmdCreatePlaylist
            // 
            this.cmdCreatePlaylist.BackColor = System.Drawing.Color.Transparent;
            this.cmdCreatePlaylist.BackgroundImage = global::MALT_Music.Properties.Resources.new_playlist;
            this.cmdCreatePlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCreatePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCreatePlaylist.Location = new System.Drawing.Point(504, 92);
            this.cmdCreatePlaylist.Name = "cmdCreatePlaylist";
            this.cmdCreatePlaylist.Size = new System.Drawing.Size(71, 24);
            this.cmdCreatePlaylist.TabIndex = 17;
            this.cmdCreatePlaylist.UseVisualStyleBackColor = false;
            this.cmdCreatePlaylist.Click += new System.EventHandler(this.cmdCreatePlaylist_Click);
            // 
            // ViewUserPlaylists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1167, 451);
            this.Controls.Add(this.cmdCreatePlaylist);
            this.Controls.Add(this.lblTitle);
            this.Name = "ViewUserPlaylists";
            this.Text = "ViewPlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button cmdCreatePlaylist;

    }
}