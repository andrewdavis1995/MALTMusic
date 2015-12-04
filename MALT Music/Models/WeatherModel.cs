using Cassandra;
using MALT_Music.DataObjects;
using MALT_Music.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALT_Music.Models
{
    class WeatherModel
    {
        private Cluster cluster;
        public WeatherModel() { init(); }
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

        public HashSet<String> getTags(Guid tid)
        {
            try
            {
                HashSet<String> tags = new HashSet<String>();
                ISession session = cluster.Connect("maltmusic");

                String todo = ("select tags from weathertags where track_id = :tid");
                PreparedStatement ps = session.Prepare(todo);
                BoundStatement bs = ps.Bind(tid);
                // Execute Query
                RowSet rows = session.Execute(bs);
                foreach (Row row in rows)
                {
                    HashSet<String> toadd = (HashSet<String>)row["tags"];
                    tags = toadd;
                    return tags;
                }

                return tags;
            }
            catch (Exception e) 
            {
                Console.WriteLine("Broken returning weather tags " + e);
                return null;
            }
        }

        public List<Weather> getAllWithTags()
        {
            try
            {
                List<Weather> weathers = new List<Weather>();
                ISession session = cluster.Connect("maltmusic");

                String todo = ("select * from weathertags");
                PreparedStatement ps = session.Prepare(todo);
                BoundStatement bs = ps.Bind();
                // Execute Query
                RowSet rows = session.Execute(bs);
                foreach (Row row in rows)
                {
                    Guid tid = (Guid) row["track_id"];
                    HashSet<String> theSet = (HashSet<String>)row["tags"];
                    Weather toadd = new Weather(tid, theSet);
                    weathers.Add(toadd);
                }

                return weathers;
            }
            catch (Exception e)
            {
                Console.WriteLine("Broken returning weather tags " + e);
                return null;
            }
        }
    }
}
