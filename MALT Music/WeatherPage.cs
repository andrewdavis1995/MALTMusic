using MALT_Music.DataObjects;
using MALT_Music.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MALT_Music
{
    public partial class WeatherPage : Form
    {

        User currentUser;
        HomePage parent;

        Playlist generatedPlaylist;

        public WeatherPage(User CU, HomePage homepage)
        {
            InitializeComponent();
            this.currentUser = CU;
            this.parent = homepage;
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            GetWeather getWeather = new GetWeather();
            String city = cmbCity.Text;
            String weatherType = getWeather.getWeather(city);

            WeatherModel weatherModel = new WeatherModel();
            SongModel songModel = new SongModel();

            List<Weather> weathers = weatherModel.getAllWithTags();
            MessageBox.Show(weathers.Count + " songs found");

            List<Song> suitableSongs = new List<Song>();

            for (int i = 0; i < weathers.Count; i++) 
            {
                List<String> weatherTags = weathers[i].getTags();

                for (int j = 0; j < weatherTags.Count; j++)
                {
                    if (weatherType.Contains(weatherTags[j])) 
                    {

                        Song toAdd = songModel.getTrackByID(weathers[i].getTrackId());
                        suitableSongs.Add(toAdd);

                        break;
                    }
                }
            }

            MessageBox.Show(suitableSongs.Count + " songs matched the tag");


            Random r = new Random();

            List<Song> selectedSongs = new List<Song>();

            while (selectedSongs.Count < 5 && suitableSongs.Count > 0) {
                int index = r.Next(0, suitableSongs.Count-1);

                Song toAdd = suitableSongs[index];
                selectedSongs.Add(toAdd);
                suitableSongs.RemoveAt(index);
            }

            Guid newGuid = Guid.NewGuid();

            generatedPlaylist = new Playlist("$temp$The " + city + " " + weatherType + " Playlist", newGuid, currentUser.getUsername(), selectedSongs);

            PlaylistModel playlistModel = new PlaylistModel();
            playlistModel.createTempPlaylist(generatedPlaylist);

            lblDetected.Text = "We have detected that the weather in " + city + " is " + weatherType + ". So, we made you this playlist:";
            lblPlaylistName.Text = "The " + city + " " + weatherType + " Playlist";
            lblDetected.Visible = true;
            lblPlaylistName.Visible = true;
            cmdGenerate.Visible = false;
            cmbCity.Visible = false;

        }

        private void lblPlaylistName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            parent.showViewPlaylist(generatedPlaylist);
        }
    }
}
