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



        /*
         * Function to attempt log in to a user account
         * @PARAMETERS: - song: the song to add
         * @RETURNS: The User who has been logged in - null if unsuccesful
         * @AUTHORS: Andrew Davis and Matt Malone
         * NOTE - Commented code left in by Matt - just in case it breaks
         */
        public bool doInsertTrack(Song song)
        {
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
                 "values (:tid, :art,:alb,:yr,:gnr,:floc,:len,:tnm) if not exists");


                PreparedStatement ps = session.Prepare(todo);

                BoundStatement bs = ps.Bind(tid, artist, album, year, genre, file_loc, length, trackname);


                // Execute Query
                session.Execute(bs);

                return true;

                // Catch exceptions
            }
            catch (Exception ex)
            {
                Console.WriteLine("SOMETHING WENT WRONG in INSERT TRACK: " + ex.Message);
                return false;
            }

        }

        public bool populateDB()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("../../tracks/populate.txt");

                foreach (string line in lines)
                {


                    // Use a tab to indent each line of the file.
                    Console.WriteLine("\t" + line);

                    char[] delimiterChars = { '|' };

                    System.Console.WriteLine("Original text: '{0}'", line);

                    string[] text = line.Split(delimiterChars);

                    foreach (string s in text)
                    {
                        System.Console.WriteLine(s);
                    }

                    Guid sid = new Guid();
                    String artist = text[0].Trim();
                    String album = text[1].Trim();
                    int year = int.Parse(text[2]);
                    String genre = text[3].Trim();
                    int length = int.Parse(text[4]);
                    String tname = text[5].Trim();

                    String file_loc = ("../../tracks/" + artist + "/" + album + "/" + tname + ".mp3");


                    Song toAdd = new Song(artist, album, year, genre, file_loc, length, tname, sid);
                    doInsertTrack(toAdd);

                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Broke while reading data to base" + e);
                return false;
            }
        }




        public List<Song> getSongsByArtist(String artist)
        {
            List<Song> songs = new List<Song>();

            try
            {
                // Call to initialise cluster connection
                init();
                
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
                init();

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

                    if (trackName.ToLower().Contains(searchText))
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

