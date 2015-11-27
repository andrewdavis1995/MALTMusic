using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALT_Music.DataObjects
{
    class Album
    {
        String name;
        List<Song> songs;

        public String getName()
        {
            return this.name;
        }

        public Album(string name)
        {
            this.name = name;
            songs = new List<Song>();
        }

        public Album(string name, List<Song> songs) 
        {
            this.name = name;
            this.songs = songs;
        }
        
        public void addSong(Song song)
        {
            this.songs.Add(song);
        }

        public List<Song> getSongs()
        {
            return this.songs;
        }

        public bool compareName(String albumName) 
        { 
            return albumName == this.name;
        }

    }
}
