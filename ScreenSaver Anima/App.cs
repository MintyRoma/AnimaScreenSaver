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
                Player pl = new Player();
            }
        }

    }
}
