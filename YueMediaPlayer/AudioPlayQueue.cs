using NAudio.Dmo.Effect;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueMediaPlayer
{
    public class AudioPlayQueue
    {
        private Dictionary<int, AudioFileReader> AudioFiles;

        public AudioPlayQueue() 
        {
            AudioFiles = new Dictionary<int, AudioFileReader>();
        }

        public int Add(string path)
        {
            try
            {
                AudioFileReader audioFile = new AudioFileReader(path);
                int id = AudioFiles.Count + 1;
                AudioFiles.Add(id, audioFile);
                return id;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public AudioFileReader Find(int id)
        {
            try
            {
                AudioFileReader audioFile = null;
                AudioFiles.TryGetValue(id, out audioFile);
                return audioFile;
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
    }
}
