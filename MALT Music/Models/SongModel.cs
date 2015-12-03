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
        public SongModel() 
        {
            init();
        }

        public void init()
        {

            try
            {
                cluster = CassHosts.getCluster();
                Console.WriteLine("GOT CLUSTER");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurred Getting Cluster INIT" + e);
            }
        }



        /*
         * Function to attempt log in to a user account
         * @PARAMETERS: - song: the song to add
         * @RETURNS: The User who has been logged in - null if unsuccesful
         * @AUTHORS: Andrew Davis and Matt Malone
         * NOTE - Commented code left in by Matt - just in case it breaks
         */
        public bool doInsertTrack(Song song, ISession session)
        {
            try
            {
                // Call to initialise cluster connection
                //init();

                ///

                Guid tid = song.getSongID();
                String artist = song.getArtist();
                String album = song.getAlbum();
                int year = song.getYear();
                String genre = song.getGenre();
                String file_loc = song.getFileLocation();
                int length = song.getLength();
                String trackname = song.getTrackName();

                // Connect to cluster
                //ISession session = cluster.Connect("maltmusic");


                //Guid tid = Guid.NewGuid();


                // Prepare and bind statement passing in username
                String todo = ("insert into tracks (\n" +
                  "track_id, artist, album, year,genre, file_loc,length,track_name)\n" +
                 "values (:tid, :art,:alb,:yr,:gnr,:floc,:len,:tnm) if not exists");


                PreparedStatement ps = session.Prepare(todo);

                BoundStatement bs = ps.Bind(tid, artist, album, year, genre, file_loc, length, trackname);


                // Execute Query
                session.Execute(bs);
                //session.Dispose();
                return true;

                // Catch exceptions
            }
            catch (Exception ex)
            {
                Console.WriteLine("SOMETHING WENT WRONG in INSERT TRACK: " + ex.Message);
                return false;
            }

        }


        public List<String> getAllArtists()
        {
            List<String> artists = new List<String>();
            try
            {
                // Call to initialise cluster connection
                //init();
                
                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                
                // Prepare and bind statement passing in username
                String todo = ("SELECT artist FROM tracks");


                PreparedStatement ps = session.Prepare(todo);

                //BoundStatement bs = ps.Bind(artist);
                BoundStatement bs = ps.Bind();



                // Execute Query
                RowSet rows = session.Execute(bs);


                foreach (Row r in rows) 
                {

                    String toadd = (String) r["artist"];

                    if(!artists.Contains(toadd))
                    {
                        artists.Add(toadd);
                    }
                   
                }

                return artists;

                // Catch exceptions
            }
            catch (Exception ex)
            {
                Console.WriteLine("SOMETHING WENT WRONG in GET BY ARTIST: " + ex.Message);
                return artists;
            }
        }


        public List<String> searchArtists(String target) 
        {
            List<String> allArtists = getAllArtists();
            List<String> matches = new List<String>();
            String curr;

            for (int i = 0; i < allArtists.Count(); i++) 
            { 
                curr = allArtists[i];
                if(curr.ToLower().Contains(target))
                {
                    matches.Add(curr);
                }
            
            }
            return matches;
 
        }


        public bool populateDB()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("../../tracks/populate.txt");
                ISession session = cluster.Connect("maltmusic");

                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    //Console.WriteLine("\t" + line);
                    char[] delimiterChars = { '|' };
                    //System.Console.WriteLine("Original text: '{0}'", line);
                    string[] text = line.Split(delimiterChars);

                    //Guid sid = new Guid();
                    Guid sid = new Guid(text[0]);
                    String artist = text[1].Trim();
                    String album = text[2].Trim();
                    int year = int.Parse(text[3]);
                    String genre = text[4].Trim();
                    int length = int.Parse(text[5]);
                    String tname = text[6].Trim();


                    
                    String file_loc = ("../../tracks/" + artist + "/" + album + "/" + tname + ".mp3");
                    Song toAdd = new Song(artist, album, year, genre, file_loc, length, tname, sid);
                    doInsertTrack(toAdd, session);
                    //doInsertTrack(toAdd);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Broke while reading data to base" + e);
                return false;
            }
        }


        public List<String> getAlbumsByArtist(String artist)
        {
            List<String> albums = new List<String>();
            try
            {
                // Call to initialise cluster connection
                //init();
                
                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                // Prepare and bind statement passing in username
                String todo = ("SELECT album FROM tracks WHERE artist = :art ALLOW FILTERING");
                PreparedStatement ps = session.Prepare(todo);
                BoundStatement bs = ps.Bind(artist);
                // Execute Query
                RowSet rows = session.Execute(bs);
                foreach (Row r in rows)
                {

                    String toadd = (String)r["album"];
                    if (!albums.Contains(toadd))
                    {
                        albums.Add(toadd);
                    }
                }

                return albums;

                // Catch exceptions
            }
            catch (Exception e)
            {
                Console.WriteLine("SOMETHING WENT WRONG in GET Album BY ARTIST: " + e);
                return albums;
            }
        }

        public List<Song> getAllSongs()
        {
            List<Song> songs = new List<Song>();
            try
            {
                // Call to initialise cluster connection
                //init();
                
                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                // Prepare and bind statement
                String todo = ("SELECT * FROM tracks");
                PreparedStatement ps = session.Prepare(todo);
                BoundStatement bs = ps.Bind();
                // Execute Query
                RowSet rows = session.Execute(bs);
                foreach (Row r in rows)
                {
                    String artist = r["artist"].ToString();
                    String trackName = r["track_name"].ToString();
                    Guid id = (Guid)r["track_id"];
                    String album = r["album"].ToString();
                    String fileLocation = r["file_loc"].ToString();
                    int year = (int)r["year"];
                    int length = (int)r["length"];
                    String genre = r["genre"].ToString();

                    Song theSong = new Song(artist, album, year, genre, fileLocation, length, trackName, id);

                    songs.Add(theSong);
                    
                }

                return songs;

                // Catch exceptions
            }
            catch (Exception e)
            {
                Console.WriteLine("SOMETHING WENT WRONG in GET Album BY ARTIST: " + e);
                return songs;
            }
        }

        public List<Song> getSongsByArtist(String artist)
        {
            List<Song> songs = new List<Song>();

            try
            {
                // Call to initialise cluster connection
                //init();
                
                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                
                // Prepare and bind statement passing in username
                String todo = ("SELECT * FROM tracks WHERE artist = :art ALLOW FILTERING");


                PreparedStatement ps = session.Prepare(todo);

                BoundStatement bs = ps.Bind(artist);

                // Execute Query
                RowSet rows = session.Execute(bs);
                foreach (Row r in rows) 
                {

                    String trackName = r["track_name"].ToString();
                    Guid id = (Guid)r["track_id"];
                    String album = r["album"].ToString();
                    String fileLocation = r["file_loc"].ToString();
                    int year = (int)r["year"];
                    int length = (int)r["length"];
                    String genre = r["genre"].ToString();

                    Song theSong = new Song(artist, album, year, genre, fileLocation, length, trackName, id);

                    songs.Add(theSong);
                }

                return songs;

                // Catch exceptions
            }
            catch (Exception ex)
            {
                Console.WriteLine("SOMETHING WENT WRONG in GET BY ARTIST: " + ex.Message);
                return songs;
            }
        }


        public List<Song> searchSongs(String searchText) 
        {
            List<Song> songs = new List<Song>();

            try
            {
                // Call to initialise cluster connection
                //init();

                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");


                // Prepare and bind statement passing in username
                String todo = ("SELECT * FROM tracks");


                PreparedStatement ps = session.Prepare(todo);

                BoundStatement bs = ps.Bind();

                // Execute Query
                RowSet rows = session.Execute(bs);
                foreach (Row r in rows)
                {

                    String trackName = r["track_name"].ToString();

                    if (trackName.ToLower().Contains(searchText.ToLower()))
                    {
                        Guid id = (Guid)r["track_id"];
                        String album = r["album"].ToString();
                        String artist = r["artist"].ToString();
                        String fileLocation = r["file_loc"].ToString();
                        int year = (int)r["year"];
                        int length = (int)r["length"];
                        String genre = r["genre"].ToString();

                        Song theSong = new Song(artist, album, year, genre, fileLocation, length, trackName, id);

                        songs.Add(theSong);
                    }
                }

                return songs;

                // Catch exceptions
            }
            catch (Exception ex)
            {
                Console.WriteLine("SOMETHING WENT WRONG in GET BY ARTIST: " + ex.Message);
                return songs;
            }
        }


    }
}

