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

namespace MALT_Music
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }


        private void HomeForm_Load(object sender, EventArgs e)
        {
            //Connect to the demo keyspace on our cluster running at 127.0.0.1
            Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            ISession session = cluster.Connect("maltmusic");

            RowSet rows = session.Execute("select * from users");
            foreach (Row row in rows)
            {
                String lsString = row["firstname"] + " " + row["lastname"];
                listBox1.Items.Add(lsString);
            }

            //Wait for enter key before exiting
            Console.ReadLine();
        }

    }
}
