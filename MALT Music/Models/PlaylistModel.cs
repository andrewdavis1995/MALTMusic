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
    class PlaylistModel
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


        public void createPlaylist(Playlist playlist)
        {
            throw new NotImplementedException();
        }

        public bool addSongToPlaylist(Playlist playlist, Song song) 
        {
            try
            {
                // Call to initialise cluster connection
                init();

                
                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");


                // Prepare and bind statement passing in the relevant fields
                String todo = ("insert into playlist (track_id,playlist_id,track_pos)\n" +
                 "values (:tid, :pid,:tpos);");


                PreparedStatement ps = session.Prepare(todo);

                Guid tid = song.getSongID();
                Guid pid = playlist.getID();



                // Matt - change this
                int pos = 0;


                BoundStatement bs = ps.Bind(tid, pid, pos);


                // Execute Query
                session.Execute(bs);

                return true;

                // Catch exceptions
            }
            catch (Exception ex)
            {
                Console.WriteLine("SOMETHING WENT WRONG add to playlist: " + ex.Message);
                return false;
            }

        }
        
        public void removeSongFromPlaylist(Playlist playlist, Song song)
        {
            throw new NotImplementedException();
        }

        public void renamePlaylist(Playlist playlist, String newName) 
        {
            throw new NotImplementedException();
        }

        public void deletePlaylist(Playlist playlist) 
        {
            throw new NotImplementedException();
        }

        public void followPlaylist(Playlist playlist, User follower)
        {
            throw new NotImplementedException();
        }

        // NOT SURE ABOUT THIS ONE - Facebook, Twitter, Email?
        public void sharePlaylist(Playlist playlist)
        {
            throw new NotImplementedException();
        }

    }
}
