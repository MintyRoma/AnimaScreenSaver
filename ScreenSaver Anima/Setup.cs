using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenSaver_Anima
{
    public partial class Setup : Form
    {

        List<string> vids;
        public Setup()
        {
            InitializeComponent();
#if DEBUG
            BUILDLABEL.Text = "Build №" + App.BUILD;
#endif
            Tools.GetData();
            vids = Tools.Videos;
            AddVideos();
            EnableVolumeControlCB.Checked = Tools.AllowKeys;
            VolumeBar.Value = Tools.Volume;
        }

        private void Setup_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        /// <summary>
        /// Считывает из реестра список воспроизводимых видео
        /// </summary>
        /// <returns>Список путей с видео</returns>
        

        /// <summary>
        /// Добавляет список видео в ListBox
        /// </summary>
        private void AddVideos()
        {
            VideoList.Items.Clear();
            vids = Tools.Videos;
            foreach(string vid in vids)
            {
                if (vid == "") ;
                else VideoList.Items.Add(vid);
            }
        }

        private void BrowseVideo_Click(object sender, EventArgs e)
        {
            string filepath = "";
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Выберите видеофайлы";


            fd.InitialDirectory = "C:\\";
            fd.Filter = "video (*.MP4/*.M4V/*.avi/*.mov)|";
            fd.FilterIndex = 2;
            fd.RestoreDirectory = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                
                filepath  = fd.FileName;
                
            }


            if (!vids.Contains(filepath))
            {
                vids.Add(filepath);
                AddVideos();
            }
            
        }

        private void Setup_Load(object sender, EventArgs e)
        {

        }

        private void DeleteVideo_Click(object sender, EventArgs e)
        {
            string selecttext = VideoList.GetItemText(VideoList.SelectedItem);
            VideoList.Items.Remove(selecttext);
            vids.Remove(selecttext);



        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Tools.SetData(vids, Tools.Volume, Tools.AllowKeys);
            Application.Exit();
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            Tools.Volume = VolumeBar.Value;
        }

        private void EnableVolumeControlCB_CheckedChanged(object sender, EventArgs e)
        {
            Tools.AllowKeys = EnableVolumeControlCB.Checked;
        }
    }
} 