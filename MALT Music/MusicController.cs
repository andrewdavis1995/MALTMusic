using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace MALT_Music
{
    /// <summary>
    ///  This class allows the controlling of the media playing
    ///  Uses library from <see cref="http://naudio.codeplex.com/"/>
    /// </summary>
    class MusicController
    {
        // Class variables
        IWavePlayer waveOut;
        AudioFileReader audioFileReader;

        /// <summary>
        /// Constructor
        /// </summary>
        public MusicController()
        {
            // Initialises the WaveOut Device
            waveOut = new WaveOut();
        }
        
        /// <summary>
        /// Sets the song to be played by the player
        /// </summary>
        /// <param name="fileInput"></param>
        /// <returns>The total length (time) of the track</returns>
        public TimeSpan setSong(string fileInput)
        {
            audioFileReader = new AudioFileReader(fileInput);

            return audioFileReader.TotalTime;
        }

        /// <summary>
        /// Plays loaded song
        /// </summary>
        public void playSong()
        {
            waveOut.Init(audioFileReader);
            waveOut.Play();
        }

        /// <summary>
        /// Pauses the track
        /// </summary>
        public void pauseSong()
        {
            waveOut.Pause();
        }

        /// <summary>
        /// Stops the song currently playing
        /// </summary>
        public void stopSong()
        {
            waveOut.Stop();
            audioFileReader.Dispose();
        }
    }
}
