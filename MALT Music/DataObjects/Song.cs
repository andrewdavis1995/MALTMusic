using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALT_Music.DataObjects
{
    public class Song
    {
        Guid songID;
        String artist;
        String album;
        int year;
        String genre;
        String file_loc;
        int length;
        String track_name;

        public Song() { }

        public Song(String artist, String album, int year, String genre, String location, int length, String track, Guid id) 
        {
            this.artist = artist;
            this.album = album;
            this.year = year;
            this.genre = genre;
            this.file_loc = location;
            this.length = length;
            this.track_name = track;
            this.songID = id;
        }

        public Song(String artist, String location, String name, Guid tid, int length, String album) 
        {
            this.artist = artist;
            this.file_loc = location;
            this.track_name = name;
            this.songID = tid;
            this.album = album;
            this.length = length;
        }

        public String getArtist() { return this.artist; }
        public String getAlbum() { return this.album; }
        public int getYear() { return this.year; }
        public String getGenre() { return this.genre; }
        public String getFileLocation() { return this.file_loc; }
        public int getLength() { return this.length; }
        public String getTrackName() { return this.track_name; }
        public Guid getSongID() {
            return this.songID;
        }
    }
}
