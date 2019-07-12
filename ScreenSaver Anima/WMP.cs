using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;
using System.IO;

namespace ScreenSaver_Anima
{
    public partial class WMP : Form
    {
        string pathh;
        private Point CursorPosition = new Point();
        public EventHandler PlayingChanged = delegate { };
        
        public WMP(Screen sc,string path)
        {
            InitializeComponent();



            this.StartPosition = FormStartPosition.Manual;
            this.Location = sc.Bounds.Location;
            this.Size = sc.Bounds.Size;
            //this.TopMost = true;
           
            pathh = path;
            
            if (sc != Screen.AllScreens[0]) vid.settings.volume = 0;
            CursorPosition = Cursor.Position;
            Play();
#if DEBUG
            debug.Text = "DEBUG";
#endif
        }

        public void Play()
        {
            vid.Size = this.Size;
            vid.Location = this.Location;
            vid.settings.volume = Tools.Volume;
            vid.URL = pathh;
            vid.Ctlcontrols.play();

        }

        private void WMP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void WMP_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void WMP_MouseMove(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void WMP_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Vid_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
           Application.Exit();
        }

        private void Vid_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            Point TMP = Cursor.Position;
            if ((Math.Abs(CursorPosition.X - TMP.X) > 0) || (Math.Abs(CursorPosition.Y - TMP.Y) > 0))
            {
                Application.Exit();
            }
            //CursorPosition = TMP;
        }

        private void Vid_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {
            Application.Exit();
            
        }

        private void Vid_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            Application.Exit();
        }

        private void WMP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void WMP_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void Vid_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
          

            if (e.newState == 2) Application.Exit();
            if (e.newState == 8)
            {
                //Tools.GenerateRandom();
                //vid.URL=Tools.Video;

#if DEBUG
                 debug.Text = "end video";
#endif
                vid.Size = this.Size;
                vid.Location = this.Location;
                vid.settings.volume = Tools.Volume;
                vid.URL = pathh;
                vid.Ctlcontrols.play();

            }


        }

        private void WMP_MouseMove_1(object sender, MouseEventArgs e)
        {
            Point TMP = Cursor.Position;
            if ((Math.Abs(CursorPosition.X - TMP.X) > 0) || (Math.Abs(CursorPosition.Y - TMP.Y) > 0))
            {
                Application.Exit();
            }
            CursorPosition = TMP;
        }

        private void WMP_KeyDown_1(object sender, KeyEventArgs e)
        {
            debug.Text = e.KeyValue.ToString();

        }

        private void Vid_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
        {
            if (e.nKeyAscii == 40) MessageBox.Show("DOWN ARROW");
        }

        private void Vid_Enter(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
#if DEBUG
            if (vid.Ctlcontrols.currentPosition != 0)
            {
                debug.Text = vid.Ctlcontrols.currentPosition.ToString();
            }
           
#endif
        
        }
    }
}
