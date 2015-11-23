﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using MALT_Music.DataObjects;
using MALT_Music.lib;

namespace MALT_Music.Models
{
    class LoginModel
    {
        private Cluster cluster;
        public void init() {

            try{
                cluster = CassHosts.getCluster();
                Console.WriteLine("GOT CLUSTER");
            }
            catch(Exception e){
                Console.WriteLine("Exception Occurred Getting Cluster INIT");            
            }
        }



        /*
         * Function to attempt log in to a user account
         * @PARAMETERS: - username: the user's username
         *             - password: the user's password
         * @RETURNS: The User who has been logged in - null if unsuccesful
         * @AUTHORS: Andrew Davis and Matt Malone
         * NOTE - Commented code left in by Matt - just in case it breaks
         */
        public User doLogin(String username, String password) {

            try
            {
<<<<<<< HEAD

                //Should be in init() but that broke so to make work for now
                cluster = CassHosts.getCluster();                
=======
                //Call to initialise cluster connection
                init();
                              
>>>>>>> c673a566c18b03e09c5c09dae8f65817953e18fc


                //Just keepin a note:
                //http://docs.datastax.com/en/developer/csharp-driver/2.0/csharp-driver/quick_start/qsSimpleClientBoundStatements_t.html
                //HashSet<String> tags = new HashSet<String>();
                //tags.Add("jazz");
                //tags.Add("2013");

                //Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                //prepare and bind statement passing in username
                PreparedStatement ps = session.Prepare("Select * from userprofiles where user_id = :user");
                BoundStatement bs = ps.Bind(username);


                //var statement1 = session.Prepare("Select * from userprofiles where user_id = :user");
                //RowSet rows = session.Execute(statement1.Bind(new { user = username }));

                //Execute Query
                RowSet rows = session.Execute(bs);
                //Bind(user = username));

                // When the username finds a match...
                foreach (Row row in rows)
                {
                    // Get the password for that database entry
                    String thePassword = row["password"].ToString();

                    // Check if the password matches the password that was entered
                    if (thePassword.Equals(password))
                    {
                        // If it does, set up a new User object
                        String first_name = row["first_name"].ToString();
                        String last_name = row["last_name"].ToString();

                        User user = new User(username, password, first_name, last_name);

                        // Return the new user object
                        return user;

                    }
                }
                // Catch exceptions
            }catch(Exception ex){
                Console.WriteLine("SOMETHING WENT WRONG: " + ex.Message);
            }

            // If no matches for BOTH username and password, return null
            return null;
        }

    }
}
