﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using MALT_Music.DataObjects;
using MALT_Music.lib;


namespace MALT_Music.Models
{
    class VoteModel
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
                Console.WriteLine("Exception Occurred Getting Cluster INIT" + e);
            }
        }


        public void doUpVote(Guid tid, String voter)
        {
            try
            {
                // Call to initialise cluster connection
                init();

                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                // Prepare and bind statement passing in username
                String todo = ("update votecount SET upvotes = upvotes+1 Where track_id = :tid");
                // votecount SET playcount = playcount+1, Where track_id = 81ad3117-1b1c-4a75-8658-77df7814a02a;
                PreparedStatement ps = session.Prepare(todo);
                //BoundStatement bs = ps.Bind(artist);
                BoundStatement bs = ps.Bind(tid);
                // Execute Query
                session.Execute(bs);

                updateVoteCountForUser(tid, voter, 1, session);

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR WHILE DOING up vote " + e);
            }


        }


        public void doDownVote(Guid tid, String voter)
        {
            try
            {
                // Call to initialise cluster connection
                init();

                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                // Prepare and bind statement passing in username
                String todo = ("update votecount SET downvotes = downvotes+1 Where track_id = :tid");
                // votecount SET playcount = playcount+1, Where track_id = 81ad3117-1b1c-4a75-8658-77df7814a02a;
                PreparedStatement ps = session.Prepare(todo);
                //BoundStatement bs = ps.Bind(artist);
                BoundStatement bs = ps.Bind(tid);
                // Execute Query
                session.Execute(bs);

                updateVoteCountForUser(tid, voter, -1, session);

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR WHILE DOING up vote " + e);
            }


        }


        public void updateVoteCountForUser(Guid tid, String voter, int voteType, ISession session)
        {
            String vtype;
            if (voteType == 1)
            {
                vtype = "up";
            }
            else if (voteType == -1)
            {
                vtype = "down";
            }
            else
            {
                Console.WriteLine("ERRORS Occurring");
                return;
            }
            // Prepare and bind statement passing in things
            String todo = ("insert into user_votes (track_id, voter, howvoted) values (:tid, :vtr, :hwvt) if not exists");
            PreparedStatement ps = session.Prepare(todo);
            BoundStatement bs = ps.Bind(tid, voter, vtype);
            // Execute Query
            session.Execute(bs);

        }

        public Vote getVotesForTrack(Guid tid)
        {
            try
            {
                // Call to initialise cluster connection
                init();

                // Connect to cluster
                ISession session = cluster.Connect("maltmusic");

                // Prepare and bind statement passing in things
                String todo = ("select * from votecount where track_id = :tid");
                PreparedStatement ps = session.Prepare(todo);
                BoundStatement bs = ps.Bind(tid);
                // Execute Query
                RowSet rows = session.Execute(bs);


                foreach (Row row in rows)
                {
                    int upVotes;
                    int downVotes;
                    if (row["upvotes"] != null)
                    {
                        upVotes = int.Parse(row["upvotes"].ToString());
                    }
                    else
                    {
                        upVotes = 0;
                    }
                    if (row["downvotes"] != null)
                    {
                        downVotes = int.Parse(row["downvotes"].ToString());
                    }
                    else
                    {
                        downVotes = 0;
                    }
                    Vote v = new Vote(tid, upVotes, downVotes);
                    return v;
                }
                return new Vote();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in vote retrieval " + e);
                return new Vote();
            }
        }


    }
}
