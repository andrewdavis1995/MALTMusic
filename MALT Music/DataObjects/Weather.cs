using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALT_Music.DataObjects
{
    class Weather
    {

        Guid track_id;
        HashSet<String> tags;

        public Weather() { }

        public Weather(Guid tid, HashSet<String> theTags)
        {
            this.track_id = tid;
            this.tags = theTags;
        }

        /// <summary>
        /// Accessor methods for fields of vote object
        /// </summary>
        public Guid getTrackId() { return this.track_id; }
        public HashSet<String> getTags() { return this.tags; }
        public void setTrackId(Guid tid) { this.track_id = tid; }
        public void setTags(HashSet<String> t) { this.tags = t; }
    }
}

