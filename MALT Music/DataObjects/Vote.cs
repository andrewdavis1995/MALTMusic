using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALT_Music.DataObjects
{
    class Vote
    {
        Guid track_id;
        int upvotes;
        int downvotes;

        public Vote() { }

        public Vote(Guid tid, int up, int down) 
        {
            this.track_id = tid;
            this.upvotes = up;
            this.downvotes = down;
        }

        /// <summary>
        /// Accessor methods for fields of vote object
        /// </summary>
        public Guid getTrackId(){return this.track_id;}
        public int getUpVotes() { return this.upvotes; }
        public int getDownVotes() { return this.downvotes; }
        public void setTrackId(Guid tid) { this.track_id = tid; }
        public void setUpVotes(int up) { this.upvotes = up; }
        public void setDownVotes(int down) { this.downvotes = down; }
    }
}
