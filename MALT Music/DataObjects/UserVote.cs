using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALT_Music.DataObjects
{
    class UserVote
    {
        Guid tid;
        // 1 up, -1 down
        int howVoted;

        public UserVote() { }

        public UserVote(Guid id, int how) { this.tid = id; this.howVoted = how;}

        public Guid getID() { return this.tid; }
        public int getHowVoted() { return this.howVoted; }

        public void setID(Guid id) { this.tid = id; }
        public void setHowVoted(int x) { this.howVoted = x; }
    }
}
