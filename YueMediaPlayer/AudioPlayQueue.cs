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
        public class AudioFileAttribute
        {
            public AudioFileReader AudioFileReader
            {
                set;get;
            }

            public string FileName;

            public string FullPath;
        }

        private Dictionary<int, AudioFileAttribute> AudioFiles;

        public AudioPlayQueue() 
        {
            AudioFiles = new Dictionary<int, AudioFileAttribute>();
        }

        public int Add(string fileName,string path)
        {
            try
            {
                AudioFileAttribute attribute = new AudioFileAttribute();
                attribute.AudioFileReader = new AudioFileReader(path);
                attribute.FileName = fileName;
                attribute.FullPath = path;

                int id = AudioFiles.Count + 1;
                AudioFiles.Add(id, attribute);
                return id;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public int GetCount()
        {
            return AudioFiles.Count;
        }

        public AudioFileAttribute Find(int id)
        {
            try
            {
                AudioFileAttribute audioFile = null;
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
