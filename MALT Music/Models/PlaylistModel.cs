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
                Console.WriteLine("Exception Occurred Getting Cluster INIT " + e);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="playlist"></param>
        /// <param name="song"></param>
        /// <returns></returns>
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
                 "values (:tid, :pid,:tpos) if not exists;");
                PreparedStatement ps = session.Prepare(todo);

                // Getting Appropriate ID's for query
                Guid tid = song.getSongID();
                Guid pid = playlist.getID();

                // Matt - change this
                // done
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

        
        /// <summary>
        ///     FUNCTION TO GET A PLAYLIST BASED ON ITS NAME
        /// </summary>
        /// <param name="plname">The name of the playlist</param>
        /// <param name="owner">The owner of the playlist</param>
        /// <returns>A playlist object - the found playlist</returns>
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
        
        /// <summary>
        ///     Get the songs from a playlist
        /// </summary>
        /// <param name="pid">the id of the playlist</param>
        /// <param name="session">the session for connecting to Cassandra</param>
        /// <returns></returns>
        public List<Song> getTracksInPlist(Guid pid, ISession session)
        {
            List<Song> songs = new List<Song>();
            List<int> positions = new List<int>();

            String todo = ("select * from playlist where playlist_id = :pid");
            PreparedStatement ps = session.Prepare(todo);
            BoundStatement bs = ps.Bind(pid);
            // Execute Query
            RowSet rows = session.Execute(bs);
            foreach (Row row in rows)
            {
                //under duress i do this
                Guid tid = (Guid)row["track_id"];

                int pos = (int)row["track_pos"];
                positions.Add(pos);

                String things = ("select track_name,artist,file_loc,length,album from tracks where track_id = :tid");
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
                    String file_loc = (String)rowset["file_loc"];
                    int length = (int)rowset["length"];
                    String album = rowset["album"].ToString();

                    Song toadd = new Song(artist, file_loc, name, tid, length, album);
                    songs.Add(toadd);
                }
            }

            // SORT

            List<Song> sortedSongs = new List<Song>();

            while (positions.Count > 0 && songs.Count > 0) 
            {
                int currentLowest = positions[0];
                int lowestIndex = 0;

                for (int i = 0; i < positions.Count; i++) 
                {
                    if (positions[i] < currentLowest) 
                    {
                        currentLowest = positions[i];
                        lowestIndex = i;
                    }
                }

                sortedSongs.Add(songs[lowestIndex]);

                songs.RemoveAt(lowestIndex);
                positions.RemoveAt(lowestIndex);
   
            }

            return sortedSongs;

        }

        public List<Playlist> getPlaylistsForUser(String plOwner)
        {

            init();
            // Connect to cluster
            ISession session = cluster.Connect("maltmusic");

            List<Playlist> playlists = new List<Playlist>();
            String todo = ("select playlist_name from list_playlist where owner = :own ALLOW FILTERING");
            PreparedStatement ps = session.Prepare(todo);
            BoundStatement bs = ps.Bind(plOwner);
            // Execute Query
            RowSet rows = session.Execute(bs);
            foreach (Row row in rows)
            {
                String plname = (String)row["playlist_name"];
                Playlist toadd = getPlaylist(plname, plOwner);
                playlists.Add(toadd);
            }

            return playlists;
        }

        public List<Playlist> searchPlaylists(String target) 
        {
            List<Playlist> playlists = new List<Playlist>();

            init();
            // Connect to cluster
            ISession session = cluster.Connect("maltmusic");

            String todo = ("select playlist_name,owner from list_playlist");
            PreparedStatement ps = session.Prepare(todo);
            BoundStatement bs = ps.Bind();
            // Execute Query
            RowSet rows = session.Execute(bs);
            foreach (Row row in rows)
            {
                String curr = (String)row["playlist_name"];
                String current = curr.ToLower();
                if (current.Contains(target.ToLower()))
                {
                    String owner = (String)row["owner"];
                    Playlist toget = getPlaylist(curr,owner);
                    playlists.Add(toget);
                }
            }

            return playlists;
        
        }

        public void removeSongFromPlaylist(Playlist playlist, Song song)
        {
            try
            {
                init();
                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                // get playlist id
                // get track id
                Guid play_id = playlist.getID();
                Guid track_id = song.getSongID();

                String todo = "delete from playlist where playlist_id = :pid and track_id = :tid";
                PreparedStatement ps = session.Prepare(todo);
                BoundStatement bs = ps.Bind(play_id, track_id);
                session.Execute(bs);
            }
            catch (Exception andrewIsABaw) 
            {
                Console.WriteLine("Removing from a plist broke " + andrewIsABaw);
            }
        }

        public void renamePlaylist(Playlist playlist, String newName)
        {
            try
            {
                init();
                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                // get playlist id and owner
                Guid play_id = playlist.getID();
                String owner = playlist.getOwner(); 

                // Delete Playlist with old name
                String todo = "delete from list_playlist WHERE playlist_id = :pid";
                PreparedStatement ps = session.Prepare(todo);
                BoundStatement bs = ps.Bind(play_id);
                session.Execute(bs);

                // Recreate playlist with new name, same old id
                // Slightly hacky way of updating a primary key
                String insert = "insert into list_playlist (\n" +
                      "playlist_id, owner,playlist_name)\n" +
                     "values (:pid,:own,:plnm) if not exists";
                PreparedStatement preps = session.Prepare(insert);
                BoundStatement bounds = preps.Bind(play_id, owner, newName);
                session.Execute(bounds);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Renaming a plist broke " + ex);
            }
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

            //String todo = ("select * from playlist where track_id = :tid and playlist_id = :pid");

            String todo = ("select * from playlist where playlist_id = :pid");

            PreparedStatement ps = session.Prepare(todo);
            //BoundStatement bs = ps.Bind(tid, pid);
            BoundStatement bs = ps.Bind(pid);
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
                pos = max + 1;
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
