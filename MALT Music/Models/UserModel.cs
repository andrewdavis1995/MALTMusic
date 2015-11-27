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
                // no it doesn't
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
                    String bio = (String)row["bio"];
                    if (row["email"] != null)
                    {
                        String email = row["email"].ToString();
                        

                        user = new User(username, password, fname, sname, email, bio);
                    }
                    else
                    {

                        user = new User(username, password, fname, sname, null, "Enter your details here...");
                    }
                    return user;
                }

            }catch(Exception e)
            { 
                Console.WriteLine("ERROR GETTING user profile deets " + e);
            }
            return null;
        }

        public void updateBio(String newBio, String userID) 
        { 
            //this is to do
            //update userprofiles set bio = 'blehhehehegfdyuqibvy'where user_id = 'andrew7';

            init();
            // Connect to cluster
            ISession session = cluster.Connect("maltmusic");

            String todo = ("update userprofiles set bio = :bio where user_id = :uid");
            PreparedStatement ps = session.Prepare(todo);
            BoundStatement bs = ps.Bind(newBio, userID);
            // Execute Query
            session.Execute(bs);
        }

        public void updateDetails(String uname, String first,String last,String email)
        {
            // user, first, last, email
            //this is to do
            //;

            init();
            // Connect to cluster
            ISession session = cluster.Connect("maltmusic");

            String todo = ("update userprofiles set first_name = :first, last_name = :last,email = :email where user_id = :uname");
            PreparedStatement ps = session.Prepare(todo);
            BoundStatement bs = ps.Bind(first, last, email, uname);

            session.Execute(bs);

        }




    }
}
