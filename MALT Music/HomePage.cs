using System;
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

        public static User currentUser;

        public HomePage()
        {
            InitializeComponent();
        }


        private void HomePage_Load(object sender, EventArgs e)
        {
            lblFullName.Text = currentUser.getFirstName() + " " + currentUser.getLastName();
        }

    }
}
