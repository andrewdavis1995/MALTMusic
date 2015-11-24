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

        public bool doRegister(User toRegister){
        try{     
        
                //Call to initialise cluster connection
                init();
                
                String uname = toRegister.getUsername();
                String fname = toRegister.getUsername();
                String sname = toRegister.getUsername();
                String password = toRegister.getUsername();

                //Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                //prepare and bind statement passing in username
            
            //PreparedStatement ps = session.Prepare("Select * from userprofiles where user_id = :user");
            //BoundStatement bs = ps.Bind(username);

                PreparedStatement ps = session.Prepare("insert into userprofiles (user_id, password, first_name, last_name) values (?,?,?,?) if not exists");

                //values ('useven','seven','sev','en') if not exists;");
              
                BoundStatement bs = ps.Bind(uname, password, fname, sname);


                //Execute Query
                //RowSet rows = 
                session.Execute(bs);
                
                        return true;

            // Catch exceptions
            }catch(Exception ex){
                Console.WriteLine("SOMETHING WENT WRONG DURING REG : " + ex.Message);
                return false;
            }

            // If no matches for BOTH username and password, return null
            //return false;
        }

    }






    }
