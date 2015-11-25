﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cassandra;
using MALT_Music.DataObjects;

namespace MALT_Music
{
    public partial class HomePage : Form
    {
        //Initialise other forms here
        MusicPlayer musicPlayer = new MusicPlayer();

        public User currentUser;


        public void setCurrentUser(User theUser) 
        {
            this.currentUser = theUser;
        }


        public HomePage()
        {
            InitializeComponent();
        }


        private void HomePage_Load(object sender, EventArgs e)
        {
            lblFullName.Text = currentUser.getFirstName() + " " + currentUser.getLastName();
            IsMdiContainer = true;

            hideForms();

            loadMusicPlayer();
        }

        private void hideForms()
        {
            musicPlayer.Hide();
        }

        private void loadMusicPlayer()
        {
            musicPlayer.TopLevel = false;
            musicPlayer.Parent = this;
            musicPlayer.Dock = DockStyle.Bottom;
            musicPlayer.FormBorderStyle = FormBorderStyle.None;
            musicPlayer.Show();
        }

        //When the user clicks on the search box, clear the placeholder text
        private void txtSearchBox_Enter(object sender, EventArgs e)
        {
            if (txtSearchBox.Text == "Search for songs, artists and albums...")
            {
                txtSearchBox.Text = "";
            }
        }

        //When the user clicks away from the search box
        private void txtSearchBox_Leave(object sender, EventArgs e)
        {
            if (txtSearchBox.Text == "")
            {
                txtSearchBox.Text = "Search for songs, artists and albums...";
            }
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            System.Environment.Exit(0);

        }



    }
}
