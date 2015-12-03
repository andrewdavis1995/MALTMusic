namespace MALT_Music
{
    partial class ViewAllResults
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
            this.lblSearchedFor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSearchedFor
            // 
            this.lblSearchedFor.AutoSize = true;
            this.lblSearchedFor.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchedFor.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchedFor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearchedFor.Location = new System.Drawing.Point(28, 9);
            this.lblSearchedFor.Name = "lblSearchedFor";
            this.lblSearchedFor.Size = new System.Drawing.Size(235, 26);
            this.lblSearchedFor.TabIndex = 0;
            this.lblSearchedFor.Text = "ALL THE LABEL-Y THINGS";
            // 
            // ViewAllResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(862, 369);
            this.Controls.Add(this.lblSearchedFor);
            this.Name = "ViewAllResults";
            this.Text = "ViewAllResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchedFor;
    }
}