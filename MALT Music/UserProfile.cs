using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MALT_Music
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
            txtBioEdit.Hide();
        }

        private void lblBioText_Click(object sender, EventArgs e)
        {
            txtBioEdit.Show();
        }

        private void txtBioEdit_MouseLeave(object sender, EventArgs e)
        {
            //Update text for user
            lblBioText.Text = txtBioEdit.Text;

            //Convert to string for use in method
            string newBio = txtBioEdit.Text;

            //TODO: Update bio in database
            //updateBio(newBio, userID);

            //Hide textbox
            txtBioEdit.Hide();
        }

    }
}
