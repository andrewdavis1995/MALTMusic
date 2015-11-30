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
                Console.WriteLine("Exception Occurred Getting Cluster INIT  " + e);
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
            try
            {
                init();
                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                String todo = ("update userprofiles set first_name = :first, last_name = :last,email = :email where user_id = :uname");
                PreparedStatement ps = session.Prepare(todo);
                BoundStatement bs = ps.Bind(first, last, email, uname);

                session.Execute(bs);
            }
            catch (Exception e) {
                Console.WriteLine("Error Occurred during update details " + e);
            }

        }

        //add in try catch
        //Update password
        //You made this? I made this.
        public void updatePassword(String pass, String uname)
        {
            pass = Encryption.calcMD5(pass);

            init();
            // Connect to cluster
            ISession session = cluster.Connect("maltmusic");

            String todo = ("update userprofiles set password = :pass where user_id = :uname");
            PreparedStatement ps = session.Prepare(todo);
            BoundStatement bs = ps.Bind(pass, uname);

            session.Execute(bs);
        }

        public List<User> searchUsers(String target)
        {
            List<User> users = new List<User>();
            try
            {
                // Call to initialise cluster connection
                init();
                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                // Prepare and bind statement passing in username
                String todo = ("SELECT * FROM userprofiles");
                PreparedStatement ps = session.Prepare(todo);
                BoundStatement bs = ps.Bind();
                // Execute Query
                RowSet rows = session.Execute(bs);
                foreach (Row r in rows)
                {

                    String username = (String)r["user_id"];

                    if (username.ToLower().Contains(target.ToLower()))
                    {
                        // this one
                        // public User(String username, String firstName, String surname, String email)

                        //String username = (String)r["user_id"];
                        String fname = (String)r["first_name"];
                        String sname = (String)r["last_name"];
                        String email = (String)r["email"];
                        
                        User u = new User(username, fname,sname, email);

                        users.Add(u);
                    }
                }

                return users;

                // Catch exceptions
            }
            catch (Exception e)
            {
                Console.WriteLine("SOMETHING WENT WRONG in GET Album BY ARTIST: " + e);
                return users;
            }
        }


    }
}
