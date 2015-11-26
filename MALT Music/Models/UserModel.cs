using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MALT_Music.DataObjects;
using Cassandra;
using MALT_Music.lib;

namespace MALT_Music.Models
{
    class UserModel
    {
        private Cluster cluster;
        public void init()
        {

            try
            {
                cluster = CassHosts.getCluster();
                Console.WriteLine("GOT CLUSTER");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurred Getting Cluster INIT");
            }
        }
        public User getDetailsForUser(String username)
        {
            try
            {
                //THIS NULL POINTERS
                init();
                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                User user;
                String todo = ("select * from userprofiles where user_id = :uid");
                PreparedStatement ps = session.Prepare(todo);
                BoundStatement bs = ps.Bind(username);
                // Execute Query
                RowSet rows = session.Execute(bs);
                foreach (Row row in rows)
                {

                    //public User(String username, String password, String firstName, String surname, HashSet<String> email) 

                    String password = (String)row["password"];
                    String fname = (String)row["first_name"];
                    String sname = (String)row["last_name"];
                    if (row["email"] != null)
                    {
                        String email = row["email"].ToString();
                        email = email.Substring(0, email.Length - 2);

                        HashSet<String> emailSet = new HashSet<String>();
                        emailSet.Add(email);

                        user = new User(username, password, fname, sname, emailSet);
                    }
                    else
                    {

                        user = new User(username, password, fname, sname, null);
                    }
                    return user;
                }

            }catch(Exception e)
            { 
                Console.WriteLine("ERROR GETTING user profile deets " + e);
            }
            return null;
        }







    }
}
