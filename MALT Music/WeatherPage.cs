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
        public WeatherPage()
        {
            InitializeComponent();
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            GetWeather getWeather = new GetWeather();
            String city = cmbCity.Text;
            String weatherType = getWeather.getWeather(city);

            WeatherModel weatherModel = new WeatherModel();
            SongModel songModel = new SongModel();

            List<Weather> weathers = weatherModel.getAllWithTags();
            MessageBox.Show(weathers.Count + " songs read from file");

            List<Song> suitableSongs = new List<Song>();

            for (int i = 0; i < weathers.Count; i++) 
            {
                List<String> weatherTags = weathers[i].getTags();

                for (int j = 0; j < weatherTags.Count; j++)
                {
                    MessageBox.Show(weathers[i].getTrackId() + "----> " + weatherTags[j]);
                    if (weatherType.Contains(weatherTags[j])) 
                    {

                        Song toAdd = songModel.getTrackByID(weathers[i].getTrackId());
                        suitableSongs.Add(toAdd);

                        break;
                    }
                }
            }

            MessageBox.Show(weathers.Count + " songs matched the tag");

        }
    }
}
