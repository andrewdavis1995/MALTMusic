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

            // Convert the email to a set
            HashSet<String> emailSet = new HashSet<String>();
            emailSet.Add(email);

            // Create a user object
            User newUser = new User(username, password, first_name, last_name, emailSet);

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
                }
            }

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            picUsernameStatus.Visible = true;
            
            RegisterModel registerModel = new RegisterModel();

            String username = txtUsername.Text;

            bool taken = registerModel.checkUsername(username);

            if (taken)
            {
                picUsernameStatus.Image = Properties.Resources.small_cross;
            }
            else {
                picUsernameStatus.Image = Properties.Resources.small_tick;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            picUsernameStatus.Visible = false;
            picUsernameStatus.Image = Properties.Resources.spinningWheel;
        }
    }
}
