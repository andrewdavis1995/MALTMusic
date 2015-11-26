using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using MALT_Music.Models;


namespace MALT_Music.lib
{
    class keyspaces
    {

        public static void SetUpKeySpaces(Cluster c)
        {
            try
            {
                Console.WriteLine("====================="); Console.WriteLine("=====================");
                Console.WriteLine("STARTING TO SETUP KEY SPACES");
                Console.WriteLine("====================="); Console.WriteLine("=====================");




                String createkeyspace = "create keyspace if not exists maltmusic WITH replication = {'class':'SimpleStrategy', 'replication_factor':1}";
                String createUserProfile = "CREATE TABLE if not exists maltmusic.userprofiles (\n"
                    + "User_ID text PRIMARY KEY,\n"
                    + "password text,\n"
                    + "bio text,\n"
                    + "first_name text,\n"
                    + "last_name text,\n"
                    + "email set<text>,\n"
                    + "profpic  UUID);";

                String createTracks = "create table if not exists maltmusic.tracks (\n"
                    + "Track_ID UUID, \n"
                    + "track_Name text,\n"
                    + "artist text,\n"
                    + "album text,\n"
                    + "year int, \n"
                    + "length int, \n"
                    + "genre text,\n"
                    + "file_loc text,\n"
                    + "PRIMARY KEY (Track_ID, artist, album, year, genre))";

                String createPlaylist = " create table if not exists maltmusic.playlist(\n"
                    + "Playlist_ID UUID,\n"
                    + "Track_ID UUID,\n"
                    + "Track_Pos int,\n"
                    + "PRIMARY KEY (Playlist_ID, Track_ID))";

                String createVotes = "create table if not exists maltmusic.votecount(\n"
                    + " track_ID UUID Primary Key, \n"
                    + " playcount counter,\n"
                    + "upvotes counter,\n"
                    + "downvotes counter)";

                String createListPlaylist = "create table  if not exists maltmusic.list_playlist(\n"
                    + "playlist_id UUID,\n"
                    + "owner text,\n"
                    + "playlist_name text,"
                    + "PRIMARY KEY (playlist_ID, owner, playlist_name)\n"
                    + ")";

                String createUserVotes = "create table if not exists maltmusic.user_votes(\n"
                    + " track_ID UUID,\n"
                    + " voter text, \n"
                    + " howvoted text,\n"
                    + " Primary Key (track_id, voter)\n"
                    + " ); ";

                //Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
                ISession session = c.Connect();



                try {
                    PreparedStatement statement = session.Prepare(createkeyspace);
                    BoundStatement bs = new BoundStatement(statement);
                    RowSet rs = session.Execute(bs);
                     Console.WriteLine("Created Malt ");
                } catch (Exception et) {
                Console.WriteLine("Creation of keyspace broke - " + et);
                }

                try
                {
                    PreparedStatement statement = session.Prepare(createUserProfile);
                    BoundStatement bs = new BoundStatement(statement);
                    RowSet rs = session.Execute(bs);
                    Console.WriteLine("Created user profiles ");
                }
                catch (Exception et)
                {
                    Console.WriteLine("Creation profiles broke - " + et);
                }

                try
                {
                    PreparedStatement statement = session.Prepare(createPlaylist);
                    BoundStatement bs = new BoundStatement(statement);
                    RowSet rs = session.Execute(bs);
                    Console.WriteLine("Created Playlist ");
                }
                catch (Exception et)
                {
                    Console.WriteLine("Creating Playlist broke - " + et);
                }


                try
                {
                    PreparedStatement statement = session.Prepare(createTracks);
                    BoundStatement bs = new BoundStatement(statement);
                    RowSet rs = session.Execute(bs);
                    Console.WriteLine("Created Tracks ");
                }
                catch (Exception et)
                {
                    Console.WriteLine("Creating Tracks broke - " + et);
                }




                try
                {
                    PreparedStatement statement = session.Prepare(createVotes);
                    BoundStatement bs = new BoundStatement(statement);
                    RowSet rs = session.Execute(bs);
                    Console.WriteLine("Created Votes ");
                }
                catch (Exception et)
                {
                    Console.WriteLine("Creating votes broke - " + et);
                }


                try
                {
                    PreparedStatement statement = session.Prepare(createListPlaylist);
                    BoundStatement bs = new BoundStatement(statement);
                    RowSet rs = session.Execute(bs);
                    Console.WriteLine("Created List Playlist ");
                }
                catch (Exception et)
                {
                    Console.WriteLine("Creating List Playlist broke - " + et);
                }

                
                try
                {
                    PreparedStatement statement = session.Prepare(createUserVotes);
                    BoundStatement bs = new BoundStatement(statement);
                    RowSet rs = session.Execute(bs);
                    Console.WriteLine("Created User Votes ");
                }
                catch (Exception et)
                {
                    Console.WriteLine("Creating User Votes broke - " + et);
                }

                //session.End();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something keyspacey broke - " + e);
            }

        }

        public void populateTracks() 
        {
            //populate database with things
            SongModel s = new SongModel();
            s.populateDB();
        }

    }
}
