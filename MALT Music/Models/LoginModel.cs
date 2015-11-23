using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;

namespace MALT_Music.Models
{
    class LoginModel
    {

        /*
         * Function to attempt log in to a user account
         * PARAMETERS: - username: the user's username
         *             - password: the user's password
         * AUTHOR: Andrew Davis
         */
        public bool doLogin(String username, String password) {


            Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            ISession session = cluster.Connect("maltmusic");


           
            var statement1 = session.Prepare("Select * from userprofiles where user_id = :user AND password = :pass");

            RowSet rows = session.Execute(statement1.Bind(new { user = username, pass = password }));

            if(!rows.IsExhausted())
            {
                return true;
            }

            return false;
        }

    }
}
