using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MALT_Music.lib;
using Cassandra;

namespace MALT_Music
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initStuff();
            Application.Run(new Login());
        }

        static void initStuff()
        {
            keyspaces keys = new keyspaces();
            Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            cluster = CassHosts.getCluster();
            keyspaces.SetUpKeySpaces(cluster);
            keys.populateTracks();
            
        }
    }
}
