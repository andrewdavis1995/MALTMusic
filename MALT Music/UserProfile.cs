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
        HomePage parent;
        UserModel model = new UserModel();

        public UserProfile()
        {
            InitializeComponent();
            txtBioEdit.Hide();
        }

        public void setParent(HomePage hp)
        {
            this.parent = hp;
        }

        public void setUser(User theUser)
        {
            currentUser = theUser;

            if ((currentUser.getBio().Equals("")) || (currentUser.getBio().Equals(null)))
            {
                lblBioText.Text = "Enter your bio here...";
                
            }
            else {
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
                parent.currentUser.setBio(lblBioText.Text);

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
                model.updateDetails(currentUser.getUsername(), txtFirstName.Text, txtLastName.Text, txtEmail.Text);
                MessageBox.Show(result.getError());
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //Show password change window
            PasswordChange changeWindow = new PasswordChange(currentUser);
            changeWindow.Show();
        }

        //Button to change the user's profile picture
        private void btnChangeProfilePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSearch = new OpenFileDialog();
            
            //Filter so the user can only select jpeg or png files
            fileSearch.Filter = "Images (*.JPG;*.PNG)|*.JPG;*.PNG";

            //if statement that means the code will only continue if the user clicks OK and doesn't cancel the window
            if (fileSearch.ShowDialog() == DialogResult.OK)
            {
                //This is the path and file name. Not sure if we need it but we have it
                //SAFEFileName has the full path
                String filename = fileSearch.FileName;

                try
                {
                    //Set image location to be the loading one
                    picBoxProfilePic.ImageLocation = filename;

                    //This is where we put it into the database
                    PicModel insert = new PicModel();

                    //Call PicModel's insert image
                    insert.setImage(filename, currentUser.getUsername());

                    //Set the parent to be the home page
                    HomePage parent = (HomePage)this.Parent;

                    //And call the method to change the profile pic on the home panel
                    parent.loadProfilePicHome();

                }
                catch (Exception IOException)
                {
                    MessageBox.Show("ABORT ABORT ");
                    Console.WriteLine("Error occured on things " + IOException);
                }

            }
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            //Call method to load picture
            loadProfilePic();
        }

        private void loadProfilePic()
        {
            //Get the image from the database
            PicModel getImg = new PicModel();
            Image target = getImg.getImage(currentUser.getUsername());

            //Set it to be the image inside picBoxProfilePic
            picBoxProfilePic.Image = target;

            if (target == null)
            {
                picBoxProfilePic.Image = Properties.Resources.iconprofile;
            }
        }

        //Pressing enter on textbox does same thing as leaving
        private void txtBioEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBioEdit_MouseLeave(this, new EventArgs());
            }
        }


    }
}
