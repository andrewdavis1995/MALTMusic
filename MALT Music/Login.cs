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

namespace MALT_Music
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username...")
            {
                txtUsername.Text = "";
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

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                txtUsername.Text = "Username...";
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

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            // Create a LoginModel object to handle the login
            LoginModel loginModel = new LoginModel();

            // Get the user credentials from the form
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            // Attempt the login
            bool success = loginModel.doLogin(username, password);

            // If it was successful, go to the Home Page
            if (success)
            {
                // Create a Home Form
                HomeForm homeForm = new HomeForm();

                // Hide the current form
                this.Hide();
                
                // Show the Home Form
                homeForm.Show();

            }
            else 
            {
                // Clear the Password field
                txtPassword.Text = "";
            }

        }

    }
}
