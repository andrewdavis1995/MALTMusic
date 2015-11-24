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
            String first_name = txtFirstName.Text;
            String last_name = txtLastName.Text;
            String email = txtEmail.Text;           // Not used yet
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            HashSet<String> emailSet = new HashSet<String>();
            emailSet.Add(email);

            User newUser = new User(username, password, first_name, last_name, emailSet);

            RegisterModel registerModel = new RegisterModel();
            bool success = registerModel.doRegister(newUser);

            if (success)
            {
                MessageBox.Show("User Created Successfully");
                this.Close();
            }
            else 
            {
                MessageBox.Show("User Creation Failed");
            }

        }
    }
}
