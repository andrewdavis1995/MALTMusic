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
        public void setSong(string fileInput)
        {
            audioFileReader = new AudioFileReader(fileInput);
            waveOut.Init(audioFileReader);
        }

        /// <summary>
        /// Plays loaded song
        /// </summary>
        public void playSong()
        {
            waveOut.Play();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newSpan">Holds the new time </param>
        public void updatePlayTime(TimeSpan newSpan)
        {
            audioFileReader.CurrentTime = newSpan;
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

        /// <summary>
        /// Gets the track length
        /// </summary>
        /// <returns>The length of track as int (seconds)</returns>
        public int getTrackLength()
        {
            double trackLengthDB = audioFileReader.TotalTime.TotalSeconds;
            int trackLength = Convert.ToInt32(trackLengthDB);

            return trackLength;
        }
    }
}
