﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenSaver_Anima
{
    public static class Tools
    {
        private static List<string> videos = new List<string>();
        private static int volume = 50;
        private static bool allowkeys = false;


        public static void GetData()
        {
            CheckReg();
            videos = InitVideos();
            volume = InitVolume();
            allowkeys = InitAllow();
        }

        public static List<string> InitVideos()
        {
            List<string> video = new List<string>();
            RegistryKey WorkKey = Registry.CurrentUser;
            WorkKey = WorkKey.OpenSubKey(@"Software\AnimaScreenSaver");
            string alldata = Convert.ToString(WorkKey.GetValue("Play"));
            string[] vid = alldata.Split('|');
            for (int i = 0; i < vid.Length; i++)
            {
                video.Add(vid[i]);
#if DEBUG
                MessageBox.Show(vid[i]);
#endif
            }
            return video;
        }
        /// <summary>
        /// Считывает из реестра значение звука от 0 до 100.
        /// В случае если значение в реестре больше чем 100 или меньше 0,
        /// то автоматически исправляет на 50
        /// </summary>
        /// <returns>Возвращает громость от 0 до 100</returns>
        private static int InitVolume()
        {
            int vol = 50;
            RegistryKey WorkKey = Registry.CurrentUser.OpenSubKey(@"Software\AnimaScreenSaver");
            vol = Convert.ToInt32(WorkKey.GetValue("Volume"));
            if (vol > 100 || vol < 0)
            {
                vol = 50;
                WorkKey = Registry.CurrentUser.OpenSubKey(@"Software\AnimaScreenSaver", true);
                WorkKey.SetValue("Volume", 50, RegistryValueKind.DWord);
            }
            return vol;
        }

        /// <summary>
        /// Считывает из реестра значение отвечающее за использование клавиш как регуляторы громкости.
        /// </summary>
        /// <returns>Возвращает bool</returns>
        private static bool InitAllow()
        {
            bool allow = false;
            RegistryKey WorkKey = Registry.CurrentUser.OpenSubKey(@"Software\AnimaScreenSaver");
            int vol = 0;
            vol = Convert.ToInt32(WorkKey.GetValue("AllowKeys"));
            if (vol > 1 || vol < 0)
            {
                vol = 0;
                WorkKey = Registry.CurrentUser.OpenSubKey(@"Software\AnimaScreenSaver", true);
                WorkKey.SetValue("AllowKeys", 0, RegistryValueKind.DWord);
            }
            if (vol == 1) allow = true;
            if (vol == 0) allow = false;
            return allow;
        }

        /// <summary>
        /// Проверяет целостность данных в реестре. В случае отсутствия параметров записывает их все по дефолту.
        /// </summary>
        private static void CheckReg()
        {
            string[] keys = new string[] { };
            RegistryKey WorkKey = Registry.CurrentUser;
            WorkKey = WorkKey.OpenSubKey(@"Software", true);
            keys = WorkKey.GetSubKeyNames();
            if (!keys.Contains("AnimaScreenSaver"))
            {
                CreateReg();
                return;
            }
            WorkKey = WorkKey.OpenSubKey("AnimaScreenSaver");
            keys = WorkKey.GetValueNames();
            if ((!keys.Contains("Play")) || (!keys.Contains("Volume")) || (!keys.Contains("AllowKeys")))
            {
                CreateReg();
                return;
            }
            return;
        }

        /// <summary>
        /// Создает раздел и значения в реестре по умолчанию.
        /// </summary>
        private static void CreateReg()
        {
            RegistryKey WorkKey = Registry.CurrentUser;
            WorkKey = WorkKey.OpenSubKey(@"Software", true);
            WorkKey.CreateSubKey("AnimaScreenSaver");
            WorkKey = WorkKey.OpenSubKey("AnimaScreenSaver", true);
            WorkKey.SetValue("Play", "", RegistryValueKind.String);
            WorkKey.SetValue("Volume", 50, RegistryValueKind.DWord);
            WorkKey.SetValue("AllowKeys", 0, RegistryValueKind.DWord);
        }

        public static int Volume
        {
            get { return volume; }
        }
        public static List<string> Videos
        {
            get { return videos; }
        }
        public static bool AllowKeys
        {
            get { return allowkeys; }
        }
        
    }
}