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
    public partial class WMP : Form
    {
        public WMP(Screen sc, string path)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = sc.Bounds.Location;
            this.Size = sc.Bounds.Size;
            vid.URL = path;
            vid.Size = this.Size;
            vid.Location = this.Location;
            vid.settings.volume = Tools.Volume;
            if (sc != Screen.AllScreens[0]) vid.settings.volume = 0;
        }

        public void Play()
        {
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
            //Application.Exit();
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
        }
    }
}
