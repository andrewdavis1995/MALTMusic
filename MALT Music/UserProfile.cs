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

            //Display email
            lblEmail.Text = currentUser.getEmail();

            //TODO - DISPLAY PROFILE PIC

            //Display info in text boxes
            txtEmail.Text = currentUser.getEmail();
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

        //Update details for name and email
        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            Validation result = textFieldValidation();

            if (result.getValidity() == false)
            {
                MessageBox.Show(result.getError());

            }
            else
            {
                //Update labels on form
                lblFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
                lblEmail.Text = txtEmail.Text;

                //Do the database update
                //model.updateDetails(currentUser.getUsername(), txtFirstName.Text, txtLastName.Text, txtEmail.Text);
                //MAAAAAAAAAAAAATTTTTTTTTTTTTTTTTTTTTTTTTTT
            }
            
        }

        private Validation textFieldValidation()
        {
            //Validation step 1 - make sure the fields aren't empty
            if ((txtFirstName.Text.Equals("")) || (txtLastName.Text.Equals("")) || (txtEmail.Text.Equals("")))
            {
                return new Validation("Cannot update info as one or more fields have been left blank.", false);
            }
            else
            {
                //Step 2 - check e-mail
                if (txtEmail.Text.Trim().Length < 7) { return new Validation("Email address is not long enough", false); }    // Length validation
                if (!txtEmail.Text.Contains('@')) { return new Validation("Email address must contain a '@'", false); }   // Content validation
                if (!txtEmail.Text.Contains('.')) { return new Validation("Email address must contain a '.'", false); }   // Content validation
                
                //Otherwise it's fine
                else
                {
                    return new Validation("Successfully updated info.", true);
                }
            }
        }

    }
}
