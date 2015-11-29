using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MALT_Music.DataObjects;

namespace MALT_Music
{
    public partial class ViewPlaylist : Form
    {

        Playlist thePlaylist;

        public ViewPlaylist(Playlist playlist)
        {
            InitializeComponent();
            this.thePlaylist = playlist;
            lblPlaylistName.Text = thePlaylist.getPlaylistName();
            lblOwner.Text = thePlaylist.getOwner();

            List<Song> songs = thePlaylist.getSongs();
            int numSongs = thePlaylist.getSongs().Count;

            lblNumSongs.Text = numSongs.ToString();

            if (numSongs == 1) { lblNumSongs.Text += " song"; } else { lblNumSongs.Text += " songs"; }

            int totalLength = 0;
            for (int i = 0; i < songs.Count; i++) 
            {
                totalLength += songs[i].getLength();
            }

            int hours = totalLength / 3600;
            int minutes = (totalLength - hours * 3600) / 60;
            int seconds = totalLength - (hours * 3600) - (minutes * 60);

            String output = "";
            if(hours > 0)
            {
                output += hours.ToString() + " hours, \n";
            }
            if (minutes > 0)
            {
                output += minutes.ToString() + " minutes, \n";
            }
            if (seconds > 0)
            {
                output += seconds.ToString() + " seconds, \n";
            }

            if (output.Equals(""))
            {
                output = "O seconds";
            }
            else { 
                // trim end
            }

            lblTime.Text = output;

        }
        public ViewPlaylist()
        {
            InitializeComponent();
        }

    }
}
