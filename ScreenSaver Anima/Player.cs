using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;
using
using System.Windows.Forms;

namespace ScreenSaver_Anima
{
    class Player
    {
        List<string> videos = new List<string>();
        Video PlayVideo;
        public Player()
        {
            Random rnd = new Random();
            int vid = rnd.Next(videos.Count) - 1;
            string playnow = videos[vid];
            Video.FromFile(playnow);
            foreach (var screen in Screen.AllScreens)
            {
                Form frm = new Form();
                frm.Size = screen.WorkingArea.Size;
                frm.Location = screen.WorkingArea.Location;
                frm.TopMost = true;
                frm.FormBorderStyle = FormBorderStyle.None;
            }
        }
    }
}
