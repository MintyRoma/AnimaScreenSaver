﻿using System;
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
        List<string> videos = new List<string>();
        public videoplay()
        {
            Start();
        }

        private void Start()
        {
            string path = @"";
            bool screen1 = true;
            bool play = true;


            Tools.GetData();
            videos = Tools.Videos;
            Random rnd = new Random();
            int index = rnd.Next(videos.Count);
            path = videos[index];
            

            
                                                                                                                                    Cursor.Hide();

            if (File.Exists(path))
            {
                foreach (Screen screen in Screen.AllScreens)
                {
                    startplay(screen, path, screen1);
                }
            }
            


        }

        public void startplay(Screen screen, String path,bool screen1)
        {
            Form frm = new Form();
            Video video = null;
            video = new Video(path);//dont delete its black magic
            video = null;
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
                frm.Size = screen.Bounds.Size;
                video.Size = frm.Size;

                if (screen1)
                {
                    video.Audio.Volume = (Tools.Volume * 100) - 10000;
                    screen1 = false;
                }
                else
                {
                    video.Audio.Volume = -10000;
                }

                video.Play();
                frm.Show();
            }

        }
    }
}
