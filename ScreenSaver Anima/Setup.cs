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

        
        public Setup()
        {
            InitializeComponent();
            Tools.GetData();
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
            List<string> vids = Tools.Videos;
            for (int i = 0; i < vids.Count; i++)
            {
                VideoList.Items.Add(vids[i]);
            }
        }

        private void BrowseVideo_Click(object sender, EventArgs e)
        {
            string filepath = "";
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Выберите видеофайлы";
        }

        private void Setup_Load(object sender, EventArgs e)
        {

        }
    }
} 