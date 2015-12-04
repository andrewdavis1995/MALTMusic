using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace MALT_Music
{
    class GetWeather
    {
         /*
         * Gets the location code for the city - to be used in the URL
         * @PARAMETERS: - location: the location string to get the code for
         * @RETURNS: an int - the id for the location
         * @AUTHOR: Andrew Davis
         */
        public int getLocationCode(String location)
        {
            switch (location)
            {
                case "Aberdeen":
                    return 2657832;
                case "Birmingham":
                    return 2655603;
                case "Dundee":
                    return 2650752;
                case "Edinburgh":
                    return 2650225;
                case "Glasgow":
                    return 2648579;
                case "Hull":
                    return 2645425;
                case "Liverpool":
                    return 2644210;
                case "London":
                    return 2643743;
                case "Manchester":
                    return 2643123;
                case "Middlesbrough":
                    return 2642607;
                case "Perth":
                    return 2640358;
                case "Ullapool":
                    return 2635199;

                default:
                    return -1;
            }
        }

        /*
         * Takes the important parts out of the Page data
         * @PARAMETERS: - pageSource: the HTML content of the page
         * @RETURNS: a string - the weather type
         */
        public String extractWeatherType(String pageSource){
        
            // Find the position of the first instance of the string "first active" 
            int startPos = pageSource.IndexOf("first active");
            
            // Cut all of the data before the start position off
            String cut1 = pageSource.Substring(startPos);

            // Find the position of the first instance of the string "alt=" (in the substring)
            startPos = cut1.IndexOf("alt=");

            // Cut the relevant part out of the string
            String cut2 = cut1.Substring(startPos + 5);

            // Find the position of the first instance of the string "\"" (in the substring)
            int endPos = cut2.IndexOf("\"");

            // Cut the relevant part out of the string
            String finalCut = cut2.Substring(0, endPos);
        
            //return the fully trimmed String
            return finalCut;
        }

        public static String getUrlSource(String url) {

             HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
             HttpWebResponse response = (HttpWebResponse)request.GetResponse();
             String data = "";
             if (response.StatusCode == HttpStatusCode.OK)
             {
                 Stream receiveStream = response.GetResponseStream();
                 StreamReader readStream = null;
                 if (response.CharacterSet == null)
                 {
                     readStream = new StreamReader(receiveStream);
                 }
                 else
                 {
                     readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                 }
                 
                 data = readStream.ReadToEnd();
                 response.Close();
                 readStream.Close();
             }
             return data;
        }

        public String getWeather(String location){
        
            int cityCode = getLocationCode(location);
            String weatherType = "";
        
            if(cityCode > -1){
            
                try{
                    String pageSource = getUrlSource("http://www.bbc.co.uk/weather/" + cityCode);
                    weatherType = extractWeatherType(pageSource);
                
                }catch(Exception e){
                    Console.WriteLine("SOMETHING WENT WRONG - " + e.Message);
                    weatherType = "ERROR - COULD NOT GET WEATHER";
                }
            }else{
                weatherType = "ERROR - COULD NOT GET WEATHER";
            }
        
            return weatherType;
        }

    }
}
