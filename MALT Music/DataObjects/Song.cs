﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALT_Music.DataObjects
{
    class Song
    {
        String artist;
        String album;
        int year;
        String genre;
        String file_loc;
        int length;
        String track_name;

        public Song() { }

        public Song(String artist, String album, int year, String genre, String location, int length, String track) 
        {
            this.artist = artist;
            this.album = album;
            this.year = year;
            this.genre = genre;
            this.file_loc = location;
            this.length = length;
            this.track_name = track;
        }


        public String getArtist() { return this.artist; }
        public String getAlbum() { return this.album; }
        public int getYear() { return this.year; }
        public String getGenre() { return this.genre; }
        public String getFileLocation() { return this.file_loc; }
        public int getLength() { return this.length; }
        public String getTrackName() { return this.track_name; }


    }
}