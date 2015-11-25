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
    class RegisterModel
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


        public bool doRegister(User toRegister)
        {
            try
            {
                // Call to initialise cluster connection
                init();

                // Get the relevant details
                String uname = toRegister.getUsername();
                String fname = toRegister.getFirstName();
                String sname = toRegister.getLastName();
                String password = toRegister.getPassword();
                HashSet<String> email = toRegister.getEmail();

                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                // Prepare and bind statement passing in username
                PreparedStatement ps = session.Prepare("insert into userprofiles (user_id, password, first_name, last_name, email) values (:un,:pw,:fn,:sn,:em) if not exists");

                // Bind 
                BoundStatement bs = ps.Bind(uname, password, fname, sname, email);

                //Execute Query
                session.Execute(bs);


                return true;

                // Catch exceptions
            }
            catch (Exception ex)
            {

                // Output the error
                Console.WriteLine("SOMETHING WENT WRONG DURING REG : " + ex.Message);
                return false;
            }
        }


        /*
         *  METHOD TO VALIDATE THE USER'S INPUT
         *  @PARAMETERS: - user: the user to validate the data for
         *  @RETURNS: a boolean value: whether or not the data is valid
         *  @AUTHOR: Andrew Davis
         */
        public Validation validateData(User user, String confirmPassword) 
        {

            // First Name Validation:
            String fName = user.getFirstName();
            fName = fName.Trim(); // Trim trailing/leading whitespaces
            if (fName == null || fName.Length == 0) { return new Validation("First Name must be at least 7 characters long", false); }   // Length Check
            

            // Last Name Validation:
            String lName = user.getLastName();
            lName = lName.Trim(); // Trim trailing/leading whitespaces
            if (lName == null || lName.Length == 0) { return new Validation("Last Name must be at least 7 characters long", false); }   // Length Check

            
            // User Name Validation:
            String username = user.getUsername();
            username = username.Trim(); // Trim trailing/leading whitespaces
            if (username == null || username.Length == 0) { return new Validation("Username must be at least 7 characters long", false); }   // Length Check

            bool usernameTaken = checkUsername(username);    // Check that the username is not already taken
            if (usernameTaken) { return new Validation("Username has already been taken", false); }


            // Email Validation:
            HashSet<String> email = user.getEmail();

            foreach (String address in email)
            {
                if (address.Trim().Length < 7) { return new Validation("Email address is not long enough", false); }    // Length validation
                if (!address.Contains('@')) { return new Validation("Email address must contain a '@'", false); }   // Content validation
                if (!address.Contains('.')) { return new Validation("Email address must contain a '.'", false); }   // Content validation
            }


            // Password Validation: 
            String password = user.getPassword();
            if (password.Trim().Length < 7) { return new Validation("Password is not long enough - must be at least 7 characters", false); }    // Length validation
            if (!password.Equals(confirmPassword)) { return new Validation("Password's entered do not match", false); }
            if (!password.Any(char.IsDigit)) { return new Validation("Password must contain at least 1 number", false); }   // Content validation   // Length validation
            if (!password.Any(char.IsUpper)) { return new Validation("Password must contain at least 1 Upper Case letter", false); }   // Content validation

            
            return new Validation("SUCCESS", true);

        }


        public bool checkUsername(String username) 
        {
            init();

            // Connect to cluster
            ISession session = cluster.Connect("maltmusic");

            username = username.ToLower();
            PreparedStatement ps = session.Prepare("Select * from userprofiles where user_id = :user");
            BoundStatement bs = ps.Bind(username);
            RowSet rows = session.Execute(bs);
            foreach (Row row in rows)
            {
                return true;
            }
            return false;
        }


    }
}
