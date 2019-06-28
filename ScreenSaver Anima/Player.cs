using System;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ScreenSaver_Anima
{
    class Player
    {
        List<Video> vids = new List<Video>();
        Video vid;
        bool stop = false;
        public Player()
        {
            Tools.GetData();
            LoopVideo();
            
        }

        private string GetRandomVideo()
        {
            Random rnd = new Random();
            int rndint = rnd.Next(Tools.Videos.Count);
            return Tools.Videos[rndint];
        }

        private void LoopVideo()
        {
                string path = GetRandomVideo();
                vid = new Video(path);
                Form frm = new Form();
                vid.Owner = frm;
                vid.Audio.Volume = (Tools.Volume * 100) - 10000;
                Screen scr = Screen.AllScreens[0];
                frm.StartPosition = FormStartPosition.Manual;
                frm.Size = scr.Bounds.Size;
                frm.Location = scr.Bounds.Location;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.BackColor = System.Drawing.Color.Black;
                //frm.TopMost = true;
                frm.Click += Frm_Close;
                frm.KeyDown += Frm_Close;
                frm.MouseClick += Frm_Close;
                //frm.MouseMove += Frm_Close
                vid.Play();
                frm.Show();
        }

        private void Frm_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
