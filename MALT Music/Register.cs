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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            // Extract details from the form
            String first_name = txtFirstName.Text;
            String last_name = txtLastName.Text;
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String confirmPassword = txtConfirmPassword.Text;


            // Create a user object
            User newUser = new User(username, password, first_name, last_name, email, "Enter your bio here...");

            // Create a registerModel
            RegisterModel registerModel = new RegisterModel();
            
            //Validate the data
            Validation validation = registerModel.validateData(newUser, confirmPassword);

            // Output the state of the Login
            MessageBox.Show(validation.getError());

            // If it was valid, add the user
            if (validation.getValidity())
            {
                // Convert username to lower case - for storage
                String lowerCaseUsername = newUser.getUsername().ToLower();
                newUser.setUsername(lowerCaseUsername);

                // Attempt to add the user to the database
                bool success = registerModel.doRegister(newUser);

                // If it succeeded, close the current form
                if (success)
                {
                    this.Close();


                    //Set the parent to be login
                   // Login parent = (Login)this.Parent;

                    //Call the method to show
                    //parent.showForm();

                }
            }

        }


        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username...")
            {
                txtUsername.Text = "";
            }

            picUsernameStatus.Visible = false;
            lblUsernameTaken.Visible = false;
            picUsernameStatus.Image = Properties.Resources.spinningWheel;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username...";
            }
            else
            {
                picUsernameStatus.Image = Properties.Resources.spinningWheel;

                RegisterModel registerModel = new RegisterModel();
                bool taken = registerModel.checkUsername(txtUsername.Text);

                picUsernameStatus.Visible = true;

                if (!taken) {
                    picUsernameStatus.Image = Properties.Resources.small_tick;
                }
                else
                {
                    picUsernameStatus.Image = Properties.Resources.small_cross;
                    lblUsernameTaken.Visible = true;
                }

            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Text = "First Name...";
            }
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name...")
            {
                txtFirstName.Text = "";
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Last Name...";
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last Name...")
            {
                txtLastName.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email...";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email...")
            {
                txtEmail.Text = "";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

            if (txtPassword.Text == "Password...")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password...";
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {

            if (txtConfirmPassword.Text == "Confirm Password...")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {

            if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Text = "Confirm Password...";
                txtConfirmPassword.PasswordChar = '\0';
            }
        }
    }
}
