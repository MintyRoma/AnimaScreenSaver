using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX.AudioVideoPlayback;
using WMPLib;
using Microsoft.DirectX;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.DirectX;
namespace ScreenSaver_Anima
{
    class videoplay
    {
        public videoplay()
        {
            Start();
        }

        private void Start()
        {
            String path = @"C:\Users\yan\Videos\savers\terminal.mp4";
            Form form1 = new Form();
            form1.Show();
            form1.WindowState = FormWindowState.Maximized;
            Video movie = new Video(path);
            movie.Owner = form1;
            movie.Size = new Size(1920, 1080);
            movie.Play();
        }
    }
}
