using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Cassandra;
using MALT_Music.DataObjects;
using MALT_Music.lib;
using System.Windows.Forms;
using System.Drawing;

namespace MALT_Music.Models
{
    class PicModel
    {
        // thanks andy
        // http://ac31004.blogspot.co.uk/2014/03/saving-image-in-cassandra-blob-field.html

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



        public void setImage(String filepath, String username)
        {
            //filepath = ("../../tracks/nigeBatman.png");
            FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            byte[] b = new byte[fileStream.Length + 1];
            int length = b.Length;
            fileStream.Read(b, 0, length);

            MemoryStream stream = new MemoryStream();
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                writer.Write(b);
            }
            byte[] bytes = stream.ToArray();

            //Guid pic_id = new Guid();
            //pic_id = Guid.NewGuid();

            String todo = "insert into images (image, user_id, timeadded ,imagelength) values(:im,:uid,:time,:len) if not exists";

            init();
            ISession session = cluster.Connect("maltmusic");

            //String user_id = "adminstuff";

            DateTime theTime;
            theTime = DateTime.Now;

            PreparedStatement ps = session.Prepare(todo);
            BoundStatement bs = ps.Bind(bytes, username, theTime, length);

            session.Execute(bs);
        }

        public Image getImage(String username)
        {
            init();
            ISession session = cluster.Connect("maltmusic");

            //String username = "adminstuff";

            PreparedStatement ps = session.Prepare("select user_id,image,imagelength from images where user_id =:user");
            BoundStatement bs = ps.Bind(username);
            RowSet rs = session.Execute(bs);

            foreach (Row row in rs)
            {
                byte[] byteArrayIn = (byte[])row["image"];

                if (byteArrayIn != null)
                {
                    Image img = null;
                    using (MemoryStream ms = new MemoryStream(byteArrayIn))
                    {
                        img = Image.FromStream(ms);
                    }
                    return img;
                }
            }
            return null;
        }
    }
}
