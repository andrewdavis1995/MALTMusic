using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALT_Music.DataObjects
{
    public class User
    {

        private String username;
        private String password;
        private String first_name;
        private String last_name;
        private HashSet<String> email;
        private String bio;

        /*
         * BLANK CONSTRUCTOR
         * @PARAMETERS: none
         * @AUTHOR: Andrew Davis
         */
        public User() { }

        /*
         * STANDARD CONSTRUCTOR
         * @PARAMETERS: - username: the user's username
         *             - password: the user's password
         *             - firstName: the user's first name
         *             - surname: the user's surname
         * @AUTHOR: Andrew Davis
         */
        public User(String username, String password, String firstName, String surname, HashSet<String> email, String bio) 
        {
            this.username = username;
            this.password = password;
            this.first_name = firstName;
            this.last_name = surname;
            this.email = email;
            this.bio = bio;
        }

        /*
         * @PARAMETERS: none
         * @AUTHOR: Andrew Davis
         * @RETURNS: the Username property for the current User
         */
        public String getUsername() { return this.username; }

        /*
         * @PARAMETERS: none
         * @AUTHOR: Andrew Davis
         * @RETURNS: the Password property for the current User
         */
        public String getPassword() { return this.password; }

        /*
         * @PARAMETERS: none
         * @AUTHOR: Andrew Davis
         * @RETURNS: the First Name property for the current User
         */
        public String getFirstName() { return this.first_name; }

        /*
         * @PARAMETERS: none
         * @AUTHOR: Andrew Davis
         * @RETURNS: the Last Name property for the current User
         */

        public String getLastName() { return this.last_name; }

        /*
         * @PARAMETERS: none
         * @AUTHOR: Andrew Davis
         * @RETURNS: the Last Name property for the current User
         */
        public HashSet<String> getEmail() { return this.email; }

        /*
         * @PARAMETERS: none
         * @AUTHOR: Lewis Davie
         * @RETURNS: the Bio property for the current User
         */
        public String getBio() { return this.bio; }

        public void setUsername(String username) { this.username = username; }
    }
}
