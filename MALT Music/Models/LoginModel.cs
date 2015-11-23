using System;
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
         * @AUTHOR: Andrew Davis
         */
        public User doLogin(String username, String password) {

            try
            {
                Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
                ISession session = cluster.Connect("maltmusic");


                var statement1 = session.Prepare("Select * from userprofiles where user_id = :user");

                RowSet rows = session.Execute(statement1.Bind(new { user = username }));

                foreach (Row row in rows)
                {
                    String thePassword = row["password"].ToString();

                    if (thePassword.Equals(password))
                    {
                        String first_name = row["first_name"].ToString();
                        String last_name = row["last_name"].ToString();

                        User user = new User(username, password, first_name, last_name);

                        return user;

                    }
                }
            }catch(Exception ex){
                Console.WriteLine("SOMETHING WENT WRONG: " + ex.Message);
            }


            return null;
        }

    }
}
