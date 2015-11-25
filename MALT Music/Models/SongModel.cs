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
         * @PARAMETERS: - song: the song to add
         * @RETURNS: The User who has been logged in - null if unsuccesful
         * @AUTHORS: Andrew Davis and Matt Malone
         * NOTE - Commented code left in by Matt - just in case it breaks
         */
        public bool doInsertTrack(Song song) {

            try
            {

                // Call to initialise cluster connection
                init();

                String artist = song.getArtist();
                String album = song.getAlbum();
                int year = song.getYear();
                String genre = song.getGenre();
                String file_loc = song.getFileLocation();
                int length = song.getLength();
                String trackname = song.getTrackName();

                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");


                Guid tid = Guid.NewGuid();
 

                // Prepare and bind statement passing in username
                String todo = ("insert into tracks (\n" +
                  "track_id, artist, album, year,genre, file_loc,length,track_name)\n" + 
                 "values (:tid, :art,:alb,:yr,:gnr,:floc,:len,:tnm);");


                PreparedStatement ps = session.Prepare(todo);

                BoundStatement bs = ps.Bind(tid,artist,album, year, genre, file_loc, length, trackname);


                // Execute Query
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
