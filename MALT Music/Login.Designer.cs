namespace MALT_Music
{
    partial class Login
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.btnMusicPlayer = new System.Windows.Forms.Button();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblLoginLabel = new System.Windows.Forms.Label();
            this.cmdSkipLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(400, 247);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username...";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(400, 284);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password...";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(625, 320);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(75, 23);
            this.cmdLogin.TabIndex = 2;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // btnMusicPlayer
            // 
            this.btnMusicPlayer.Location = new System.Drawing.Point(12, 424);
            this.btnMusicPlayer.Name = "btnMusicPlayer";
            this.btnMusicPlayer.Size = new System.Drawing.Size(111, 48);
            this.btnMusicPlayer.TabIndex = 4;
            this.btnMusicPlayer.Text = "Music Player";
            this.btnMusicPlayer.UseVisualStyleBackColor = true;
            this.btnMusicPlayer.Click += new System.EventHandler(this.btnMusicPlayer_Click);
            // 
            // cmdRegister
            // 
            this.cmdRegister.Location = new System.Drawing.Point(400, 320);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(75, 23);
            this.cmdRegister.TabIndex = 5;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = true;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::MALT_Music.Properties.Resources.logo;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(227, 144);
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // lblLoginLabel
            // 
            this.lblLoginLabel.AutoSize = true;
            this.lblLoginLabel.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginLabel.ForeColor = System.Drawing.Color.White;
            this.lblLoginLabel.Location = new System.Drawing.Point(493, 162);
            this.lblLoginLabel.Name = "lblLoginLabel";
            this.lblLoginLabel.Size = new System.Drawing.Size(98, 43);
            this.lblLoginLabel.TabIndex = 12;
            this.lblLoginLabel.Text = "LOGIN";
            // 
            // cmdSkipLogin
            // 
            this.cmdSkipLogin.Location = new System.Drawing.Point(138, 424);
            this.cmdSkipLogin.Name = "cmdSkipLogin";
            this.cmdSkipLogin.Size = new System.Drawing.Size(111, 48);
            this.cmdSkipLogin.TabIndex = 13;
            this.cmdSkipLogin.Text = "Go to Home Page - without Logging in";
            this.cmdSkipLogin.UseVisualStyleBackColor = true;
            this.cmdSkipLogin.Click += new System.EventHandler(this.cmdSkipLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1006, 484);
            this.Controls.Add(this.cmdSkipLogin);
            this.Controls.Add(this.lblLoginLabel);
            this.Controls.Add(this.cmdRegister);
            this.Controls.Add(this.btnMusicPlayer);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnMusicPlayer;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.Label lblLoginLabel;
        private System.Windows.Forms.Button cmdSkipLogin;
    }
}