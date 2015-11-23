using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MALT_Music.Models;
using MALT_Music.DataObjects;

namespace MALT_Music
{
    public partial class Login : Form
    {
        /*
         * CONSTRUCTOR
         * AUTHOR: Andrew Davis
         */
        public Login()
        {
            InitializeComponent();
            
        }

        /*
         * clears content if currently holds placeholder 
         * AUTHOR: Andrew Davis
         */
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username...")
            {
                txtUsername.Text = "";
            }
        }

        /*
         * clears content if currently holds placeholder 
         * AUTHOR: Andrew Davis
         */
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password...")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
        }

        /*
         * clears content if currently holds placeholder 
         * AUTHOR: Andrew Davis
         */
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                txtUsername.Text = "Username...";
            }
        }

        /*
         * clears content if currently holds placeholder 
         * AUTHOR: Andrew Davis
         */
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password...";
                txtPassword.PasswordChar = '\0';
            }
        }

        /*
         * Button to attempt the login
         * @AUTHOR: Andrew Davis
         */
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            // Create a LoginModel object to handle the login
            LoginModel loginModel = new LoginModel();

            // Get the user credentials from the form
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            // Attempt the login
            User loggedIn = loginModel.doLogin(username, password);

            // If it was successful, go to the Home Page
            if (loggedIn != null)
            {

                MessageBox.Show("SUCCESS! LOGGED IN AS: " + loggedIn.getFirstName() + " " + loggedIn.getLastName());

                // Create a Home Form
                HomePage homeForm = new HomePage();

                // Set the Current User of the HomePage to be the newly logged in user
                HomePage.currentUser = loggedIn;

                // Show the Home Form
                homeForm.Show();

                // Hide the current form
                this.Hide();                

            }
            else 
            {
                MessageBox.Show("UNSUCCESSFUL LOGIN");

                // Clear the Password field
                txtPassword.Text = "";
            }

        }

        /// <summary>
        /// Opens a music player component
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicPlayer_Click(object sender, EventArgs e)
        {
            MusicPlayer playerForm = new MusicPlayer();
            playerForm.Show();
        }

    }
}
