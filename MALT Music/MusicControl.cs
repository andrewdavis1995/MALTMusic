using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Media;
using System.Runtime.InteropServices;

namespace MALT_Music
{
    /// <summary>
    ///  This class allows the controlling of the media playing
    /// </summary>
    class MusicController
    {
        [DllImport("winmm.dll")]

        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        /// <summary>
        /// Opens a new media (.mp3) file for playing
        /// </summary>
        /// <param name="file">Stores the file for playing</param>
        public void open(string file)
        {
            // Constructs a new command for Windows
            string command = "open \"" + file + "\" type MPEGVideo alias MyMp3";

            // Excutes command
            mciSendString(command, null, 0, 0);
        }

        /// <summary>
        ///  Plays the chosen music file
        /// </summary>
        public void play()
        {
            // Constructs a new command
            string command = "play MyMp3";

            // Executes command
            mciSendString(command, null, 0, 0);
        }


        /// <summary>
        /// Stops playing the chosen music file
        /// </summary>
        public void stop()
        {
            // Stops the music from playing
            string command = "stop MyMp3";
            mciSendString(command, null, 0, 0);

            // Closes the file
            command = "close MyMp3";
            mciSendString(command, null, 0, 0);
        }

        //Pauses chosen music file
        public void pause()
        {
            string command = "pause MyMp3";
            mciSendString(command, null, 0, 0);
        }
        //static MediaPlayer mediaControl = new MediaPlayer();
    }
}
