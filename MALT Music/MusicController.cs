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
        public void setSong(string fileInput)
        {
            audioFileReader = new AudioFileReader(fileInput);
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
        /// Stops the song currently playing
        /// </summary>
        public void stopSong()
        {
            waveOut.Stop();
            audioFileReader.Dispose();
        }
    }
}
