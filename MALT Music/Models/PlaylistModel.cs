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
                int pos = getListPos(session, tid, pid);


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


        public int getListPos(ISession session, Guid tid, Guid pid)
        {
            int pos = -1;

            String todo = ("select track_pos from playlist where track_id = :tid and playlist_id = :pid");

            PreparedStatement ps = session.Prepare(todo);
            BoundStatement bs = ps.Bind(tid, pid);
            // Execute Query
            RowSet rows = session.Execute(bs);

            List<int> li = new List<int>();

            // When the username finds a match...
            foreach (Row row in rows)
            {
                if (row["track_pos"] != null)
                {
                    int x = (int)row["track_pos"];
                    li.Add(x);
                }
                else
                {
                    return 0;
                }
            }
            //get length of list
            int y = li.Count();

            //if list not empty
            if (y != 0)
            {
                //set init highest value
                int max = li[0];
                //for each value in list check against current highest
                for (int x = 0; x < y; x++)
                {
                    if (li[x] > max)
                    {
                        //If larger than current, set max to new highest
                        max = li[x];
                    }

                }
                pos = max;
                return pos;
            }
            else
            {
                pos = 0;
                return pos;
            }
        }


        // NOT SURE ABOUT THIS ONE - Facebook, Twitter, Email?
        public void sharePlaylist(Playlist playlist)
        {
            throw new NotImplementedException();
        }

    }
}
