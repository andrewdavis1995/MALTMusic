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
            
            

        }
    }
}
