﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YueMediaPlayer
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer positionTimer;
        public Form1()
        {
            InitializeComponent();

            //AudioPlayer.Get().audioPlayQueue.Add("01. 愛し子よ.mp3");
            AudioPlayer.Get().SetVolumn(0.5f);
            positionTimer = new System.Windows.Forms.Timer();
            positionTimer.Interval = 500;
            positionTimer.Tick += (object sender, EventArgs args) =>
            {
                AudioPlayer player = AudioPlayer.Get();
                if (player.IsPlaying())
                {
                    trackBar_audioPos.Value = (int)player.GetPosition();
                }
                else
                {
                    positionTimer.Stop();
                }
            };
            
        }

        /// <summary>
        /// 用于播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_playMusic_Click(object sender, EventArgs e)
        {
            AudioPlayer player = AudioPlayer.Get();
            player.Play(1);
            //positionTimer.Start();
        }

        private void trackBar_audioPos_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void OpenAudioFiles()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "mp3 files|*.mp3|wav files|*.wav";
            openFileDialog.Title = "音频文件";
            openFileDialog.Multiselect = true;
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                //string[] files = openFileDialog.FileNames;
                int count = openFileDialog.FileNames.Count();
                listView_music.BeginUpdate();
                for (int i = 0; i < count; i++)
                {
                    //string currentCount = Convert.ToString(listView_music.Items.Count + 1);
                    int curcount = AudioPlayer.Get().audioPlayQueue.Add(openFileDialog.SafeFileNames[i], openFileDialog.FileNames[i]);
                    string currentCount = Convert.ToString(curcount);
                    ListViewItem listViewItem = listView_music.Items.Add(currentCount);
                    listViewItem.SubItems.Add(openFileDialog.SafeFileNames[i]);
                }
                listView_music.EndUpdate();
            }
        }

        private void menu_openAudioFiles(object sender, EventArgs e)
        {
            OpenAudioFiles();
        }

        private void listView_music_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem listViewItem = listView_music.SelectedItems[0];
            int id = Convert.ToInt32(listViewItem.Text);
            AudioPlayer.Get().Play(id);
            
        }
    }
}
