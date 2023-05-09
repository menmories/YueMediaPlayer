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

        private bool bHandStartPlay;        //是手动Play

        private AudioFileReader StartPlayAudio;

        private int StartPlayId;

        public bool bAutoPlay;

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
                bHandStartPlay = false;
                StartPlayAudio = null;
                bAutoPlay = true;
                StartPlayId = 0;

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
            if(bHandStartPlay)
            {
                bHandStartPlay = false;
                StartPlayAudio.Position = 0;
                outputDevice.Init(StartPlayAudio);
                outputDevice.Play();
                return;
            }
            if (bAutoPlay)
            {
                StartPlayId++;
                if(StartPlayId > audioPlayQueue.GetCount())
                {
                    StartPlayId = 1;
                }
                AudioPlayQueue.AudioFileAttribute audioFile = audioPlayQueue.Find(StartPlayId);
                if (audioFile != null)
                {
                    StartPlayAudio.Position = 0;
                    outputDevice.Init(audioFile.AudioFileReader);
                    outputDevice.Play();
                }
                
            }
        }
        private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            //throw new NotImplementedException();
            //outputDevice.Dispose();

            StartPlayAudio.Position = 0;
            outputDevice.Init(StartPlayAudio);
            outputDevice.Play();
        }

        public void Play()
        {
            Play(1);
        }

        public void Play(int id)
        {
            try
            {
                if(outputDevice.PlaybackState == PlaybackState.Paused)
                {
                    outputDevice.Play();
                    return;
                }

                AudioPlayQueue.AudioFileAttribute audioFile = audioPlayQueue.Find(id);
                if(audioFile != null)
                {
                    StartPlayId = id;
                    StartPlayAudio = audioFile.AudioFileReader;
                    if (IsPlaying())
                    {
                        bHandStartPlay = true;
                        outputDevice.Stop();
                    }
                    else
                    {
                        StartPlayAudio.Position = 0;
                        outputDevice.Init(StartPlayAudio);
                        outputDevice.Play();
                    }
                }
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

        public void SetVolumn(float volumn)
        {
            outputDevice.Volume = volumn;
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
