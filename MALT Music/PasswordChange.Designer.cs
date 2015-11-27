namespace MALT_Music
{
    partial class PasswordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChange));
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCurrent.Location = new System.Drawing.Point(58, 21);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(92, 13);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Current password:";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNew.Location = new System.Drawing.Point(58, 79);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(80, 13);
            this.lblNew.TabIndex = 1;
            this.lblNew.Text = "New password:";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtCurrentPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCurrentPassword.Location = new System.Drawing.Point(73, 41);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(113, 20);
            this.txtCurrentPassword.TabIndex = 2;
            this.txtCurrentPassword.Text = "**********";
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNewPassword.Location = new System.Drawing.Point(73, 101);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(113, 20);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.Text = "**********";
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(89, 137);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 32);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(256, 193);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblCurrent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 400);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordChange";
            this.Text = "Change Your Password";
            this.Load += new System.EventHandler(this.PasswordChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnSubmit;
    }
}