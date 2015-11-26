﻿using System;
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
            lblBioText.Text = currentUser.getBio();
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
            model.updateBio(newBio, currentUser.getUsername());

            //Hide textbox
            txtBioEdit.Hide();
        }

    }
}
