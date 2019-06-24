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
        List<Video> vidsActual = new List<Video>();
        string playnow = "";
        WindowsMediaPlayer play = new WindowsMediaPlayer();
        Point CursosPosition = new Point();
        public Player()
        {
            while (true)
            {
                Start();
                Play();
            }
        }

        private void Play()
        {
            foreach(Video vd in vidsActual)
            {
                vd.Play();
            }
            while (vidsActual[0].Playing == true) continue;
        }

        private void Start()
        {
            Tools.GetData();
            videos = Tools.Videos;
            Random rnd = new Random();
            int vid = rnd.Next(videos.Count);
            string playnow = videos[vid];
            foreach (Screen screen in Screen.AllScreens)
            {
                Video PlayVideo;
                PlayVideo = new Video(playnow, false);
                Form frm = new Form();
                PlayVideo.Owner = frm;
                frm.Size = screen.Bounds.Size;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(screen.Bounds.X, screen.Bounds.Y);
                frm.BackColor = System.Drawing.Color.Black;
                frm.FormBorderStyle = FormBorderStyle.None;
                CursosPosition = Cursor.Position;
                frm.MouseMove += Frm_MouseMove;
                frm.KeyDown += Frm_Close;
                frm.FormClosing += Frm_Close;
                //frm.TopMost = true;
                PlayVideo.Size = frm.Size;
                frm.Size = screen.Bounds.Size;
                PlayVideo.Audio.Volume = (Tools.Volume * 100) - 10000;

                frm.Show();
                Cursor.Hide();
                vidsActual.Add(PlayVideo);
            }
            
        }

        private void Frm_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_MouseMove(object sender, EventArgs e)
        {
            Point TMP = Cursor.Position;
            if ((Math.Abs(CursosPosition.X-TMP.X)>0) || (Math.Abs(CursosPosition.Y - TMP.Y) > 0))
            {
                Application.Exit();
            }
            CursosPosition = TMP;
        }

               
    }
}
