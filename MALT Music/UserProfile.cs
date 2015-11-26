using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MALT_Music.DataObjects;
using MALT_Music.Models;

namespace MALT_Music
{
    public partial class UserProfile : Form
    {
        User currentUser;
        UserModel model = new UserModel();

        public UserProfile()
        {
            InitializeComponent();
            txtBioEdit.Hide();
        }

        public void setUser(User theUser)
        {
            currentUser = theUser;

            if((lblBioText.Text.Equals("")) || (lblBioText.Text.Equals(null)))
            {
                lblBioText.Text = "Enter your bio here...";
            }
            else
            {
                lblBioText.Text = currentUser.getBio();
            }

            //Display full name
            lblFullName.Text = currentUser.getFirstName() + " " + currentUser.getLastName();

            //Display username
            lblUsername.Text = currentUser.getUsername();

            //TODO - DISPLAY PROFILE PIC

            //Display info in text boxes
            txtEmail.Text = currentUser.getEmailString();
            txtFirstName.Text = currentUser.getFirstName();
            txtLastName.Text = currentUser.getLastName();

        }

        private void lblBioText_Click(object sender, EventArgs e)
        {
            txtBioEdit.Text = lblBioText.Text;
            txtBioEdit.Show();
        }

        private void txtBioEdit_MouseLeave(object sender, EventArgs e)
        {
            if (txtBioEdit.Text != "")
            {

                //Update text for user
                lblBioText.Text = txtBioEdit.Text;

                //Convert to string for use in method
                string newBio = txtBioEdit.Text;

                //TODO: Update bio in database
                model.updateBio(newBio, currentUser.getUsername());

                //Hide textbox
                txtBioEdit.Hide();
            }
            else
            {
                //Do nothing
            }
        }

    }
}
