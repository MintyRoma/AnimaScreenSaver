using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace ScreenSaver_Anima
{
    
    public class App : ApplicationContext
    {
        public static MODE mode = MODE.Play;
        public const int BUILD = 23;
        string path = "";
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
                Cursor.Hide();
                Tools.GetData();
                Tools.GenerateRandom();
                path = Tools.Video;
                List<WMP> wmps = new List<WMP>();
                foreach (Screen scr in Screen.AllScreens)
                {
                    WMP wm = new WMP(scr,path);
                    wm.Show();
                    wmps.Add(wm);
                }
                foreach (WMP wm in wmps)
                {
                    wm.Play();
                }
            }
            if (mode == MODE.Test)
            {
                videoplay vp = new videoplay();
            }
        }

    }
}
