using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MALT_Music.DataObjects;

namespace MALT_Music.DataObjects
{
    public class Playlist
    {
        private String playlistName;
        private Guid pID;
        private String owner;
        private List<Song> songs;

        // BLANK CONSTRUCTOR 
        public Playlist() { }

        /*
         * CONSTRUCTOR
         * @PARAMETERS: - name: the name of the playlist
         *              - pID: the ID of the playlist
         *              - user: the owner of the playlist
         *              - songs: the list of songs in the playlist
         */
        public Playlist(String name, Guid pID, String user, List<Song> songs)
        {
            this.playlistName = name;
            this.pID = pID;
            this.owner = user;
            this.songs = songs;
        }

        /*
         * CONSTRUCTOR
         * @PARAMETERS: - name: the name of the playlist
         *              - pID: the ID of the playlist
         *              - user: the owner of the playlist
         */
        public Playlist(String name, Guid pID, String user)
        {
            this.playlistName = name;
            this.pID = pID;
            this.owner = user;
        }

        /*
         * FUNCTION TO SET THE LIAT OF SONGS
         * @PARAMETERS: - songs: the list of songs
         */
        public void setSongs(List<Song> songs)
        {
            this.songs = songs;
        }

        /*
         * FUNCTION TO ADD A SONG TO THE LIST
         * @PARAMETERS: - theSong: the song to add
         */
        public void addSongs(Song theSong)
        {
            this.songs.Add(theSong);
        }


        // ACCESSOR METHODS
        public String getPlaylistName() { return this.playlistName; }
        public String getOwner() { return this.owner; }
        public Guid getID() { return this.pID; }
        public List<Song> getSongs() { return this.songs; }

    }
}
