namespace MALT_Music
{
    partial class WeatherPage
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
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.lblBeta = new System.Windows.Forms.Label();
            this.lblDetected = new System.Windows.Forms.Label();
            this.lblPlaylistName = new System.Windows.Forms.LinkLabel();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Aberdeen",
            "Birmingham",
            "Dundee",
            "Edinburgh",
            "Glasgow",
            "Hull",
            "Liverpool",
            "London",
            "Manchester",
            "Middlesbrough",
            "Perth",
            "Ullapool"});
            this.cmbCity.Location = new System.Drawing.Point(325, 111);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(221, 25);
            this.cmbCity.TabIndex = 0;
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerate.Location = new System.Drawing.Point(325, 146);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(220, 189);
            this.cmdGenerate.TabIndex = 1;
            this.cmdGenerate.Text = "GENERATE";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // lblBeta
            // 
            this.lblBeta.AutoSize = true;
            this.lblBeta.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeta.ForeColor = System.Drawing.Color.Red;
            this.lblBeta.Location = new System.Drawing.Point(325, 89);
            this.lblBeta.Name = "lblBeta";
            this.lblBeta.Size = new System.Drawing.Size(47, 21);
            this.lblBeta.TabIndex = 2;
            this.lblBeta.Text = "BETA";
            // 
            // lblDetected
            // 
            this.lblDetected.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetected.ForeColor = System.Drawing.Color.White;
            this.lblDetected.Location = new System.Drawing.Point(502, 135);
            this.lblDetected.Name = "lblDetected";
            this.lblDetected.Size = new System.Drawing.Size(383, 62);
            this.lblDetected.TabIndex = 3;
            this.lblDetected.Text = "We have detected that the weather in XXXXX is YYYYY.\r\nSo, we made you this playli" +
    "st:";
            this.lblDetected.Visible = false;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.ActiveLinkColor = System.Drawing.Color.White;
            this.lblPlaylistName.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.LinkColor = System.Drawing.Color.White;
            this.lblPlaylistName.Location = new System.Drawing.Point(511, 197);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(443, 115);
            this.lblPlaylistName.TabIndex = 4;
            this.lblPlaylistName.TabStop = true;
            this.lblPlaylistName.Text = "FUNNY PUN NAME HERE";
            this.lblPlaylistName.Visible = false;
            this.lblPlaylistName.VisitedLinkColor = System.Drawing.Color.White;
            this.lblPlaylistName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPlaylistName_LinkClicked);
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.ForeColor = System.Drawing.Color.White;
            this.lblDisclaimer.Location = new System.Drawing.Point(502, 308);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(383, 62);
            this.lblDisclaimer.TabIndex = 5;
            this.lblDisclaimer.Text = "Please note, this Playlist will expire (and be deleted) in 1 hour - unless you ch" +
    "oose to save it";
            this.lblDisclaimer.Visible = false;
            // 
            // WeatherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(974, 379);
            this.Controls.Add(this.lblDisclaimer);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.lblDetected);
            this.Controls.Add(this.lblBeta);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.cmbCity);
            this.Name = "WeatherPage";
            this.Text = "Weather Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.Label lblBeta;
        private System.Windows.Forms.Label lblDetected;
        private System.Windows.Forms.LinkLabel lblPlaylistName;
        private System.Windows.Forms.Label lblDisclaimer;
    }
}