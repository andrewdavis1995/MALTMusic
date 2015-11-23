using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;


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
                    + " playcount int,\n"
                    + "upvotes int,\n"
                    + "downvote int)";

                //Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
                ISession session = c.Connect("maltmusic");

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



                //session.End();
            }
            catch
            {


            }



        }
    }
}
