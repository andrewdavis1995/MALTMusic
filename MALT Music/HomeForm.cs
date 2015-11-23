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
            try
            {
                //Connect to the demo keyspace on our cluster running at 127.0.0.1
                Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
                ISession session = cluster.Connect("maltmusic");

                //var statement2 = session.Prepare("SELECT * FROM DynamicTimeUUIDTable WHERE id = :RowKey AND ColumnName IN :names");
                var statement1 = session.Prepare("Select * from userprofiles where user_id = :RowKey");

                //List<string> nameslist = new List<string>();
                //nameslist.Add("malt");
                //nameslist.Add("colName2");

                //RowSet rows = session.Execute(statement1.Bind(new { RowKey = "userseven", names = nameslist }));
                RowSet rows = session.Execute(statement1.Bind(new { RowKey = "userseveneight" }));
                //System.Console.WriteLine ("Here we are. The count is: ");
                //System.Console.WriteLine (results2.Count());

                foreach (Row row in rows)
                {
                    String lsString = row["first_name"] + "  " + row["last_name"] + " | " + row["user_id"];
                    listBox1.Items.Add(lsString);
                }

                /*
                RowSet rows = session.Execute("select * from userprofiles");
                foreach (Row row in rows)
                {
                    String lsString = row["firstname"] + " " + row["lastname"];
                    listBox1.Items.Add(lsString);
                }
                */
                //Wait for enter key before exiting
                Console.ReadLine();
            }catch(Exception ex){
                Console.WriteLine("SOMETHING WENT WRONG! - " + ex.Message);
            }
        }

    }
}
