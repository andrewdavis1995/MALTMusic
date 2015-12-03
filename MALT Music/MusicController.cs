using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using System.Threading;

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
        /// Sets the volume of the player
        /// </summary>
        /// <param name="setVolume">The value of the volume</param>
        public void setVolume(float setVolume)
        {
            if (audioFileReader != null)
            {
                audioFileReader.Volume = setVolume;
            }
        }

        /// <summary>
        /// Plays loaded song
        /// </summary>
        public void playSong()
        {
            Console.WriteLine("Playing from: " + Thread.CurrentThread.Name);
            waveOut.Play();
        }

        /// <summary>
        /// Changes the time position of the song
        /// </summary>
        /// <param name="newSpan">Holds the new time </param>
        public void updatePlayTime(TimeSpan newSpan)
        {
            audioFileReader.CurrentTime = newSpan;
        }

        public long getPlayTime()
        {
            return audioFileReader.Position;
        }

        public long getBigNum()
        {
            return audioFileReader.Length;
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
            try
            {
                // Stops playback
                waveOut.Stop();

                // If audio reader exists, kill it
                if (audioFileReader != null)
                {
                    // Ensures there is a track loaded (if an audio reader exists)
                    if (audioFileReader.Position != null)
                    {
                        audioFileReader.Dispose();
                    }
                }
            }
            catch (Exception needed) { }
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
