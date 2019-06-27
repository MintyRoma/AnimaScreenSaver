using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMPLib;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace ScreenSaver_Anima
{
    class Player
    {
        List<Video> vidsActual = new List<Video>();
        string playnow = "";
        Point CursosPosition = new Point();
        public Player()
        {
            Tools.GetData();
            while (true)
            {
                Start();
            }
        }

        private void Play(Video vid)
        {
            vid.Play();
            while (vidsActual[0].CurrentPosition < vidsActual[0].Duration) continue;
            return;
        }

        private void Start()
        {
            Random rnd = new Random();
            int randomvid = rnd.Next(Tools.Videos.Count);
            playnow = Tools.Videos[randomvid];
            foreach(Screen scr in Screen.AllScreens)
            {
                Form frm = new Form();
                Video vid = new Video(playnow);
                vid.Owner = frm;
                frm.Size = scr.Bounds.Size;
                frm.Location = scr.Bounds.Location;
                frm.TopLevel = true;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.BackColor = System.Drawing.Color.Black;
                frm.FormClosing += Frm_Close;
                frm.MouseClick += Frm_Close;
                frm.MouseMove += Frm_MouseMove;
                frm.KeyDown += Frm_Close;
                vidsActual.Add(vid);
                frm.Show();
                
            }
            foreach (Video vid in vidsActual)
            {
                new Thread(() => Play(vid)).Start();
            }
            return;
            
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
