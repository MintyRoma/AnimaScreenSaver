using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX.AudioVideoPlayback;
using WMPLib;
using Microsoft.DirectX;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Threading;

namespace ScreenSaver_Anima
{
    class videoplay
    {
        private Point CursorPosition = new Point();
        List<string> videos = new List<string>();
        public videoplay()
        {
            Start();

        }

        private void Start()
        {
            string path = @"";



            Tools.GetData();
            videos = Tools.Videos;
            Random rnd = new Random();
            int index = rnd.Next(videos.Count);
            path = videos[index];

          
            Cursor.Hide();
            if (File.Exists(path))
            {
                int i = 1;
                foreach (Screen screen in Screen.AllScreens)
                {
                    new Thread(() => startplay(screen, path, i)).Start();
                    i++;
                }
            }



        }

        public void startplay(Screen screen, String path, int screenid)
        {

            Cursor.Hide();
            Form frm = new Form();
            Video video = null;
            video = new Video(path);//dont delete its black magic
            video = new Video(path);

            if (video != null)
            {
                video.Owner = frm;
                frm.Size = screen.Bounds.Size;
                frm.TopMost = true;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(screen.Bounds.X, screen.Bounds.Y);
                frm.BackColor = System.Drawing.Color.Black;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.MouseMove += Frm_MouseMove;
                frm.KeyDown += Frm_Close;
                frm.FormClosing += Frm_Close;
                frm.Size = screen.Bounds.Size;
                video.Size = frm.Size;

                video.Audio.Volume = (Tools.Volume * 100) - 10000;


                video.Play();
                frm.Show();
                while (true)
                {
                    if (video.Duration-1 <= video.CurrentPosition)
                    {
                        video.Stop();
                        video.CurrentPosition = 0;
                        video.Play();
                        
                    }

                }

            }

        }
        private void Frm_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_MouseMove(object sender, EventArgs e)
        {
            Point TMP = Cursor.Position;
            if ((Math.Abs(CursorPosition.X - TMP.X) > 0) || (Math.Abs(CursorPosition.Y - TMP.Y) > 0))
            {
                Application.Exit();
            }
            CursorPosition = TMP;
        }
    }
}