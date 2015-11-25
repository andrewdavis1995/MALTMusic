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


        public void createPlaylist(Playlist p)
        {
            try
            {
                init();
                ISession session = cluster.Connect("maltmusic");

                String plName = p.getPlaylistName();
                Guid pid = p.getID();
                String owner = p.getOwner();

                String todo = ("insert into list_playlist (\n" +
                      "playlist_id, owner,playlist_name)\n" +
                     "values (:pid,:own,:plnm) if not exists");

                PreparedStatement ps = session.Prepare(todo);

                BoundStatement bs = ps.Bind(pid, owner, plName);

                session.Execute(bs);
            }
            catch (Exception e){
                Console.WriteLine("Exception during playlist create" + e);
            }


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

        public Playlist getPlaylist(String plname, String owner)
        {
            try
            {
                // Call to initialise cluster connection
                init();
                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                //plname = plname.ToLower();

                String todo = ("select * from list_playlist where playlist_name = :plnm AND owner = :own ALLOW FILTERING");
                PreparedStatement ps = session.Prepare(todo);
                BoundStatement bs = ps.Bind(plname, owner);
                // Execute Query
                RowSet rows = session.Execute(bs);
                foreach (Row row in rows)
                {
                    Playlist toGet;

                    // Get Things
                    Guid pid = (Guid)row["playlist_id"];
                    String theOwner = row["owner"].ToString();

                    List<Song> songs = new List<Song>();
                    songs = getTracksInPlist(pid, session);
                    //Playlist is name, ID user, songs 
                    toGet = new Playlist(plname, pid, theOwner, songs);

                    return toGet;
                }
                return null;
            }
            catch (Exception e){
                Console.WriteLine("Errors Occured In here " + e);
                return null;
            }
        }

        public List<Song> getTracksInPlist(Guid pid, ISession session)
        {
            List<Song> songs = new List<Song>();
            String todo = ("select * from playlist where playlist_id = :pid");
            PreparedStatement ps = session.Prepare(todo);
            BoundStatement bs = ps.Bind(pid);
            // Execute Query
            RowSet rows = session.Execute(bs);
            foreach (Row row in rows)
            {
                //under duress i do this
                Guid tid = (Guid)row["track_id"];

                String things = ("select track_name,artist,file_loc from tracks where track_id = :tid");
                PreparedStatement prep = session.Prepare(things);
                BoundStatement bound = prep.Bind(tid);
                // Execute Query
                RowSet rows2 = session.Execute(bound);

                foreach (Row rowset in rows2)
                {
                    //this one
                    //public Song(String artist, String location, String name, Guid tid) 
                    String name = (String)rowset["track_name"];
                    String artist = (String)rowset["artist"];
                    String file_loc= (String)rowset["file_loc"];

                    Song toadd = new Song(artist, file_loc, name, tid);
                    songs.Add(toadd);
                }

            }

            return songs;
        }

        public List<Playlist> getPlaylistsForUser(String plOwner)
        {
            // Connect to cluster
            ISession session = cluster.Connect("maltmusic");

            List<Playlist> playlists = new List<Playlist>();
            String todo = ("select playlist_name from list_playlist where owner = :own");
            PreparedStatement ps = session.Prepare(todo);
            BoundStatement bs = ps.Bind(plOwner);
            // Execute Query
            RowSet rows = session.Execute(bs);
            foreach (Row row in rows)
            {
                String plname = (String)row["playlist_name"];
                Playlist toadd = getPlaylist(plname, plOwner);
            }

            return playlists;
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
