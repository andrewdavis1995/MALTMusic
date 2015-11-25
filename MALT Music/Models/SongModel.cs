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
    class SongModel
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
        public bool doInsertTrack(Song s) {

            try
            {

                //Call to initialise cluster connection
                init();

                String artist = s.getArtist();
                String album = s.getAlbum();
                int year = s.getYear();
                String genre = s.getGenre();
                String file_loc = s.getFileLocation();
                int length = s.getLength();
                String trackname = s.getTrackName();

                //Connect to cluster
                ISession session = cluster.Connect("maltmusic");


                Guid tid = Guid.NewGuid();
 

                //prepare and bind statement passing in username

                //PreparedStatement ps = session.Prepare("Select * from userprofiles where user_id = :user");
                //BoundStatement bs = ps.Bind(username);

                String todo = ("insert into tracks (\n" +
                  "track_id, artist, album, year,genre, file_loc,length,track_name)\n" + 
                 "values (:tid, :art,:alb,:yr,:gnr,:floc,:len,:tnm);");


                PreparedStatement ps = session.Prepare(todo);

                //values ('useven','seven','sev','en') if not exists;");

                BoundStatement bs = ps.Bind(tid,artist,album, year, genre, file_loc, length, trackname);


                //Execute Query
                //RowSet rows = 
                session.Execute(bs);

                return true;

                // Catch exceptions
            }catch(Exception ex){
                Console.WriteLine("SOMETHING WENT WRONG in INSERT TRACK: " + ex.Message);
                return false;
            }

        }

    }
}
