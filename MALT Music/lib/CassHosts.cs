using Cassandra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

using MALT_Music.lib;

//import com.datastax.driver.core.*;
//import java.util.Iterator;
//import java.util.Set;
//import java.util.ArrayList;
//import java.util.List;

namespace MALT_Music.lib
{
    class CassHosts
    {

        private static Cluster cluster;
        static String Host = "127.0.0.1";  

        public CassHosts() {

        }

        public static String getHost() {
            return (Host);
        }

        public static String[] getHosts(Cluster cluster) {

            //From Here:
            //http://docs.datastax.com/en/developer/csharp-driver/2.5/csharp-driver/quick_start/qsSimpleClientCreate_t.html
            //
            try
            {
                if (cluster == null)
                {
                    Console.WriteLine("Creating cluster connection");
                    cluster = Cluster.Builder().AddContactPoint(Host).Build();
                }

                Console.WriteLine("Connected to cluster: " + cluster.Metadata.ClusterName.ToString());
                //List<Host> hosts = (List<Host>)cluster.Metadata.AllHosts();
                ICollection<Host> hosts = (ICollection<Host>) cluster.Metadata.AllHosts();

                String[] sHosts = new String[hosts.Count()];

                int i = 0;
                foreach (var host in hosts)
                {
                    Console.WriteLine("Data Center: " + host.Datacenter + ", " +
                    "Host: " + host.Address + ", " +
                    "Rack: " + host.Rack);

                    sHosts[i] = host.ToString();

                    i++;
                }
                return sHosts;
                
            }
            catch (Exception e) {
                Console.WriteLine("Exception while getting hosts");
            }
            return null;
        }


        public static Cluster getCluster() {
            Console.WriteLine("getCluster");
            cluster = Cluster.Builder().AddContactPoint(Host).Build();
            getHosts(cluster);
            keyspaces.SetUpKeySpaces(cluster);

            return cluster;

        }


        public void Close(Cluster c)
        {
            c.Shutdown();
        }
}



}
