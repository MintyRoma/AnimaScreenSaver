using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ScreenSaver_Anima
{
    
    public class App : ApplicationContext
    {
        public static MODE mode = MODE.Play;
        public const int BUILD = 23;
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            OnStart(args);
            App app = new App();
            Application.Run(app);
        }

        public static void OnStart(string[] args)
        {
            if (args.Length > 1 || args.Length == 0) mode = MODE.Play;
            else if (args[0] == "/c") mode = MODE.Setup;
            else if (args[0] == "/p") mode = MODE.Demo;
            else if (args[0] == "/t") mode = MODE.Test;
            else mode = MODE.Play;
        }

        public App()
        {
            if (mode == MODE.Setup)
            {
                Setup st = new Setup();
                st.Show();
            }
            if (mode == MODE.Play)
            {
                Tools.GetData();
                Random rnd = new Random();
                string path = Tools.Videos[rnd.Next(Tools.Videos.Count)];
                foreach (Screen scr in Screen.AllScreens)
                {
                    WMP frm = new WMP(scr, path);
                    frm.Show();
                }
                List<WMP> frms = new List<WMP>();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is WMP)
                    {
                        frms.Add((WMP)frm);
                    }
                }
                foreach (WMP act in frms)
                {
                    act.Play();
                }

            }
            if (mode == MODE.Test)
            {
                videoplay vp = new videoplay();
            }
        }

    }
}
