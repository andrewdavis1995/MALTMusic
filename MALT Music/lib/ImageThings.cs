using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Cassandra;

namespace MALT_Music.lib
{
    class ImageThings
    {
        // thanks andy
        // http://ac31004.blogspot.co.uk/2014/03/saving-image-in-cassandra-blob-field.html
        // this helped

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



        public void doThings()
        {
            String filePath = ("../../tracks/nigeBatman.png");
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] b = new byte[fileStream.Length + 1];
            int length = b.Length;
            fileStream.Read(b,0,length);

            //ByteBuffer buffer = ByteBuffer.wrap(b);

            MemoryStream stream = new MemoryStream();
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                writer.Write(b);
                //writer.Write(myInt32);
                //writer.Write("Hello");
            }
            byte[] bytes = stream.ToArray();

            //Guid pic_id = new Guid();
            //pic_id = Guid.NewGuid();

            String fuckyou = "insert into images (image, user_id, timeadded ,imagelength) values(:im,:uid,:time,:len)";

            init();
            ISession session = cluster.Connect("maltmusic");
            String user_id = "adminstuff";

            DateTime theTime;
            theTime = DateTime.Now;

            PreparedStatement ps = session.Prepare(fuckyou);
            BoundStatement bs = ps.Bind(bytes, user_id, theTime, length);

            session.Execute(bs);
        }

        public byte [] maybeGetThings()
        {
            //Getting the image back is simple.  Use a Select to get the result set:
            init();
            ISession session = cluster.Connect("maltmusic");

            String username = "adminstuff";

            PreparedStatement ps = session.Prepare("select user_id,image,imagelength from images where user_id =:user");
            BoundStatement bs = ps.Bind(username);
            RowSet rs = session.Execute(bs);

            int length;

            foreach (Row row in rs)
            {
                byte[] bytethings = (byte[]) row["image"];
                //writer.Write((String)row["image"]);
                //length = (int)row["imagelength"];
                return bytethings;
            }


            return null;



            ///////NNNNEEEEEEEEEEEEEEEEEEEEEEDDDDD ALLLLLLLL THIS
            /*   private void button1_Click(object sender, EventArgs e)
                    {
                        ImageThings it = new ImageThings();
                        it.doThings();
                    }

                    private void button2_Click(object sender, EventArgs e)
                    {
                        String filePath = @"../../tracks/nigeBatman.png";
                        byte[] byteArrayIn = System.IO.File.ReadAllBytes(filePath);

                         if (byteArrayIn != null)
                         {
                             Image img = null;
                             using (MemoryStream ms = new MemoryStream(byteArrayIn))
                             {
                                 img = Image.FromStream(ms);
                             }
                             //return returnImage;
                             plezoutput.BackgroundImage = img;
                         }
                         else {
                             MessageBox.Show("FUCKED");
                         }
                    }
                            }*/

        
        }


    }
}

