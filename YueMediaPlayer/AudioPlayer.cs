using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.AudioVideoPlayback;
using SharpDX.DirectSound;
using SharpDX.Multimedia;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace YueMediaPlayer
{
    public interface IMediaPlayer
    {
        void Play();
        void Stop();

        long GetPosition();

        bool IsPlaying();

        void Pause();
    }
    public class AudioPlayer : IMediaPlayer
    {
        private static AudioPlayer player = new AudioPlayer();

        //private DirectSound directSound;

        //private PrimarySoundBuffer primarySoundBuffer;

        private WaveOutEvent outputDevice;

        public AudioPlayQueue audioPlayQueue { get; }

        //private SampleChannel sampleChannel;
        public static AudioPlayer Get()
        {
            return player;
        }
        private AudioPlayer()
        {
            try
            {
                audioPlayQueue = new AudioPlayQueue();
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;

                

                //directSound = new DirectSound();

                //var soundBufferDescription = new SoundBufferDescription
                //{
                //    Flags = BufferFlags.PrimaryBuffer | BufferFlags.ControlVolume,
                //    BufferBytes = 0,
                //    Format = null,
                //    AlgorithmFor3D = Guid.Empty,
                //};

                //int samplesPerSec = 44100;      //采样率
                //int bitsPerSample = 16;
                //int nChannels = 2;
                //var blockAlign = bitsPerSample / 8 * nChannels;
                //var nAvgBytesPerSec = samplesPerSec * blockAlign;

                //primarySoundBuffer = new PrimarySoundBuffer(directSound, soundBufferDescription);
                //var wavFormat = WaveFormat.CreateCustomFormat(
                //    WaveFormatEncoding.Pcm,
                //    samplesPerSec,
                //    nChannels,
                //    nAvgBytesPerSec,
                //    blockAlign,
                //    bitsPerSample);
                //primarySoundBuffer.Format = wavFormat;

            }
            catch (Exception)
            {

            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {

        }
        private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        public void Play()
        {
            Play(1);
        }

        public int Play(int id)
        {
            try
            {
                AudioFileReader audioFile = audioPlayQueue.Find(id);

                //sampleChannel = new SampleChannel(new SampleToWaveProvider(audioFile));

                outputDevice.Init(audioFile);
                outputDevice.Play();
                return (int)audioFile.TotalTime.TotalSeconds;
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public void Stop()
        {
            outputDevice.Stop();
        }

        public long GetPosition()
        {
            return outputDevice.GetPosition();
        }

        public bool IsPlaying()
        {
            return outputDevice.PlaybackState == PlaybackState.Playing;
        }

        public void Pause()
        {
            outputDevice.Pause();
        }
    }
}
