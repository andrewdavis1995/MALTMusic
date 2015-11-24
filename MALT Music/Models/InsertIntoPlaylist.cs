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
    class InsertIntoPlaylist
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


        public bool doInsertTrack(Guid tid, Guid pid, int pos)
        {

            try
            {

                //Call to initialise cluster connection
                init();

                
                //Connect to cluster
                ISession session = cluster.Connect("maltmusic");


                //Guid tid = Guid.NewGuid();
                //prepare and bind statement passing in username

                //PreparedStatement ps = session.Prepare("Select * from userprofiles where user_id = :user");
                //BoundStatement bs = ps.Bind(username);

                String todo = ("insert into playlist (track_id,playlist_id,track_pos)\n" +
                 "values (:tid, :pid,:tpos);");


                PreparedStatement ps = session.Prepare(todo);

                //values ('useven','seven','sev','en') if not exists;");

                BoundStatement bs = ps.Bind(tid, pid, pos);


                //Execute Query
                //RowSet rows = 
                session.Execute(bs);

                return true;

                // Catch exceptions
            }
            catch (Exception ex)
            {
                Console.WriteLine("SOMETHING WENT WRONG add to playlist: " + ex.Message);
                return false;
            }

            // If no matches for BOTH username and password, return null
            //return null;

        }











    }
}
