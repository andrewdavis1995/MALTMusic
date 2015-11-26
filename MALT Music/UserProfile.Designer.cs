namespace MALT_Music
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnChangeProfilePic = new System.Windows.Forms.Button();
            this.picBoxProfilePic = new MALT_Music.OvalPictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblFNE = new System.Windows.Forms.Label();
            this.lblLNE = new System.Windows.Forms.Label();
            this.lblENE = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.lblBioText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFullName.Location = new System.Drawing.Point(395, 113);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(184, 39);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUsername.Location = new System.Drawing.Point(405, 154);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 24);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "username";
            // 
            // btnChangeProfilePic
            // 
            this.btnChangeProfilePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeProfilePic.Location = new System.Drawing.Point(240, 255);
            this.btnChangeProfilePic.Name = "btnChangeProfilePic";
            this.btnChangeProfilePic.Size = new System.Drawing.Size(163, 38);
            this.btnChangeProfilePic.TabIndex = 3;
            this.btnChangeProfilePic.Text = "Change Profile Picture";
            this.btnChangeProfilePic.UseVisualStyleBackColor = true;
            // 
            // picBoxProfilePic
            // 
            this.picBoxProfilePic.BackColor = System.Drawing.Color.LightGray;
            this.picBoxProfilePic.ErrorImage = global::MALT_Music.Properties.Resources.icon_profile;
            this.picBoxProfilePic.Image = global::MALT_Music.Properties.Resources.icon_profile;
            this.picBoxProfilePic.InitialImage = global::MALT_Music.Properties.Resources.icon_profile;
            this.picBoxProfilePic.Location = new System.Drawing.Point(247, 98);
            this.picBoxProfilePic.Name = "picBoxProfilePic";
            this.picBoxProfilePic.Size = new System.Drawing.Size(150, 150);
            this.picBoxProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProfilePic.TabIndex = 0;
            this.picBoxProfilePic.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmail.Location = new System.Drawing.Point(406, 175);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 24);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(760, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetails.Location = new System.Drawing.Point(676, 271);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(163, 38);
            this.btnUpdateDetails.TabIndex = 9;
            this.btnUpdateDetails.Text = "Update Details";
            this.btnUpdateDetails.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(760, 168);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(163, 26);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(760, 200);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(163, 26);
            this.txtLastName.TabIndex = 11;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEdit.Location = new System.Drawing.Point(716, 121);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(69, 33);
            this.lblEdit.TabIndex = 12;
            this.lblEdit.Text = "Edit";
            // 
            // lblFNE
            // 
            this.lblFNE.AutoSize = true;
            this.lblFNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNE.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFNE.Location = new System.Drawing.Point(639, 168);
            this.lblFNE.Name = "lblFNE";
            this.lblFNE.Size = new System.Drawing.Size(101, 24);
            this.lblFNE.TabIndex = 13;
            this.lblFNE.Text = "First Name";
            // 
            // lblLNE
            // 
            this.lblLNE.AutoSize = true;
            this.lblLNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLNE.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLNE.Location = new System.Drawing.Point(641, 200);
            this.lblLNE.Name = "lblLNE";
            this.lblLNE.Size = new System.Drawing.Size(99, 24);
            this.lblLNE.TabIndex = 14;
            this.lblLNE.Text = "Last Name";
            // 
            // lblENE
            // 
            this.lblENE.AutoSize = true;
            this.lblENE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblENE.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblENE.Location = new System.Drawing.Point(659, 231);
            this.lblENE.Name = "lblENE";
            this.lblENE.Size = new System.Drawing.Size(63, 24);
            this.lblENE.TabIndex = 15;
            this.lblENE.Text = "E-mail";
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBio.Location = new System.Drawing.Point(241, 302);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(60, 33);
            this.lblBio.TabIndex = 16;
            this.lblBio.Text = "Bio";
            // 
            // lblBioText
            // 
            this.lblBioText.AutoSize = true;
            this.lblBioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBioText.Location = new System.Drawing.Point(243, 335);
            this.lblBioText.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblBioText.Name = "lblBioText";
            this.lblBioText.Size = new System.Drawing.Size(281, 40);
            this.lblBioText.TabIndex = 17;
            this.lblBioText.Text = "I\'m a person who enjoys long walks on the beach, music and dogs.";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1249, 533);
            this.Controls.Add(this.lblBioText);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblENE);
            this.Controls.Add(this.lblLNE);
            this.Controls.Add(this.lblFNE);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnUpdateDetails);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
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
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblFNE;
        private System.Windows.Forms.Label lblLNE;
        private System.Windows.Forms.Label lblENE;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.Label lblBioText;

    }
}