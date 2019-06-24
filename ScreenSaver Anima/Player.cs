using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMPLib;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Windows.Forms;
using System.Drawing;

namespace ScreenSaver_Anima
{
    class Player
    {
        List<string> videos = new List<string>();
        Video PlayVideo;
        string playnow = "";
        WindowsMediaPlayer play = new WindowsMediaPlayer();
        public Player()
        {
            Tools.GetData();
            videos = Tools.Videos;
            Random rnd = new Random();
            int vid = rnd.Next(videos.Count);
            string playnow = videos[vid];
            PlayVideo = new Video(playnow, false); 
            foreach (Screen screen in Screen.AllScreens)
            {
                Form frm = new Form();
                PlayVideo.Owner = frm;
                frm.Size = screen.Bounds.Size;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(screen.Bounds.X,screen.Bounds.Y);
                frm.BackColor = System.Drawing.Color.Black;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.MouseMove += Frm_MouseMove;
                frm.KeyDown += Frm_MouseMove;
                frm.FormClosing += Frm_MouseMove;
                frm.TopMost = true;
                PlayVideo.Size = frm.Size;
                frm.Size = screen.Bounds.Size;
                PlayVideo.Audio.Volume = (Tools.Volume*100)-10000;
                
                frm.Show();
                PlayVideo.Play();
            }
        }

        private void Frm_MouseMove(object sender, EventArgs e)
        {
            Application.Exit();
        }

               
    }
}
