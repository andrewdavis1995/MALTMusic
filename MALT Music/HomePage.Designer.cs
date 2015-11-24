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
            this.picBoxMagnifyingGlass = new System.Windows.Forms.PictureBox();
            this.grpBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMagnifyingGlass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(602, 167);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(61, 24);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 296);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // grpBoxSearch
            // 
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
            this.txtSearchBox.Location = new System.Drawing.Point(337, 21);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(539, 40);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.Text = "Search for songs, artists and albums...";
            this.txtSearchBox.Enter += new System.EventHandler(this.txtSearchBox_Enter);
            this.txtSearchBox.Leave += new System.EventHandler(this.txtSearchBox_Leave);
            // 
            // picBoxMagnifyingGlass
            // 
            this.picBoxMagnifyingGlass.Image = global::MALT_Music.Properties.Resources.Magnifying_glass_icon;
            this.picBoxMagnifyingGlass.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxMagnifyingGlass.InitialImage")));
            this.picBoxMagnifyingGlass.Location = new System.Drawing.Point(269, 18);
            this.picBoxMagnifyingGlass.Name = "picBoxMagnifyingGlass";
            this.picBoxMagnifyingGlass.Size = new System.Drawing.Size(50, 47);
            this.picBoxMagnifyingGlass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMagnifyingGlass.TabIndex = 1;
            this.picBoxMagnifyingGlass.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 586);
            this.Controls.Add(this.grpBoxSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFullName);
            this.IsMdiContainer = true;
            this.Name = "HomePage";
            this.Text = "MALT Music";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.grpBoxSearch.ResumeLayout(false);
            this.grpBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMagnifyingGlass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxSearch;
        private System.Windows.Forms.PictureBox picBoxMagnifyingGlass;
        private System.Windows.Forms.TextBox txtSearchBox;

    }
}

