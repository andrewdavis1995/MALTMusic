﻿namespace MALT_Music
{
    partial class UserProfile
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
            this.picBoxProfilePic = new MALT_Music.OvalPictureBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnChangeProfilePic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxProfilePic
            // 
            this.picBoxProfilePic.BackColor = System.Drawing.Color.Silver;
            this.picBoxProfilePic.Image = global::MALT_Music.Properties.Resources.Music_Treble_Clef_icon;
            this.picBoxProfilePic.Location = new System.Drawing.Point(472, 71);
            this.picBoxProfilePic.Name = "picBoxProfilePic";
            this.picBoxProfilePic.Size = new System.Drawing.Size(150, 150);
            this.picBoxProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProfilePic.TabIndex = 0;
            this.picBoxProfilePic.TabStop = false;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(620, 86);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(184, 39);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(626, 127);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 24);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "username";
            // 
            // btnChangeProfilePic
            // 
            this.btnChangeProfilePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeProfilePic.Location = new System.Drawing.Point(465, 228);
            this.btnChangeProfilePic.Name = "btnChangeProfilePic";
            this.btnChangeProfilePic.Size = new System.Drawing.Size(163, 38);
            this.btnChangeProfilePic.TabIndex = 3;
            this.btnChangeProfilePic.Text = "Change Profile Picture";
            this.btnChangeProfilePic.UseVisualStyleBackColor = true;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1039, 387);
            this.Controls.Add(this.btnChangeProfilePic);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.picBoxProfilePic);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OvalPictureBox picBoxProfilePic;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnChangeProfilePic;

    }
}