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
        private string status = "";
        private bool edited = false;

        List<string> videos = new List<string>();
        public Setup()
        {
            InitializeComponent();
            InitVideos();
        }

        private void Setup_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        public string Status
        {
            get { return status; }
            set
            {
                edited = true;
                status = value;
            }
        }

        private List<string> InitVideos()
        {
            List<string> videos = new List<string>();
            RegistryKey WorkKey = Registry.CurrentUser;
            try
            {
                WorkKey = WorkKey.OpenSubKey(@"Software\AnimaScreenSaver");
                string alldata = Convert.ToString(WorkKey.GetValue("Play"));
                string[] vid = alldata.Split('|');
                for (int i = 0; i<vid.Length;i++)
                {
                    videos.Add(vid[i]);
#if DEBUG
                    MessageBox.Show(vid[i]);
#endif
                }


            }
            catch
            {
                WorkKey = WorkKey.OpenSubKey(@"Software");
                WorkKey.CreateSubKey("AnimaScreenSaver");
                WorkKey = WorkKey.OpenSubKey("AnimaScreenSaver");
                WorkKey.
            }
            return videos;
        }
    }
} 