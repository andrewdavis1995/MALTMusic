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
using MALT_Music.lib;

namespace MALT_Music
{
    public partial class PasswordChange : Form
    {
        User currentUser;

        public PasswordChange(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((txtCurrentPassword.Text.Equals("")) || (txtNewPassword.Text.Equals("")))
            {
                MessageBox.Show("One or more fields has been left empty.");
            }
            else
            {

                //Get passwords
                String passwordOld = txtCurrentPassword.Text;
                String passwordNew = txtNewPassword.Text;

                LoginModel loginValidateAttempt = new LoginModel();
                User detailsToCheck = loginValidateAttempt.doLogin(currentUser.getUsername(), passwordOld);

                //If a login attempt does not return null, the attempt was successful
                if (detailsToCheck != null)
                {
                    //If the new password is the same as the old password, we say something
                    if (detailsToCheck.getPassword().Equals(Encryption.calcMD5(passwordNew)))
                    {
                        MessageBox.Show("The password you entered is the same as your old password.");
                    }
                    else
                    {
                        //Then we can change the password
                        UserModel uModel = new UserModel();
                        uModel.updatePassword(passwordNew, currentUser.getUsername());

                        MessageBox.Show("Password successfully changed.");
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("The password you entered does not match your current password.");
                }
            }
        }
    }
}
