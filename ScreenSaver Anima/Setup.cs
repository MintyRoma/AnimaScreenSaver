using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenSaver_Anima
{
    public partial class Setup : Form
    {
        private const  int guiversion = 4;
        private bool edited = false;
        private List<string> vids;
        private delegate void SMTChngd();
        private event SMTChngd SomethingChanged;

        private bool Edited
        {
            get { return edited; }
            set { if (value != edited)
                {
                    edited = value;
                    SomethingChanged();
                }
            }
        }
        public Setup()
        {
            InitializeComponent();
#if DEBUG
            BUILDLABEL.Text = "Build №" + App.BUILD+"\nGUI №"+guiversion;
#endif
            SomethingChanged += EnableConfirm;
            Tools.GetData();
            vids = Tools.Videos;
            AddVideos();
            EnableVolumeControlCB.Checked = Tools.AllowKeys;
            VolumeBar.Value = Tools.Volume;
            VolumeLabel.Text = Convert.ToString(Tools.Volume);
        }

        private void EnableConfirm()
        {
            if(edited==true)ConfirmBtn.Enabled = true;
        }

        private void Setup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Добавляет список видео в ListBox
        /// </summary>
        private void AddVideos()
        {
            VideoList.Items.Clear();
            vids = Tools.Videos;
            foreach (string vid in vids)
            {
                if (!File.Exists(vid))
                {
                    ListViewItem item = new ListViewItem();
                    item.BackColor = System.Drawing.Color.Red;
                    item.ForeColor = System.Drawing.Color.White;
                    item.Text = vid;
                    AbouObject.Text = "Есть несуществующие объекты";
                    AbouObject.ForeColor = System.Drawing.Color.Red;
                    VideoList.Items.Add(item);
                }
                else VideoList.Items.Add(vid);
            }
        }

        private void BrowseVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();


            fd.Title = "Выберите видеофайлы";
            fd.Multiselect = true;
            fd.InitialDirectory = "C:\\";
            fd.Filter = "video files (*.mp4;*.avi;*.mov)|*.mp4;*.avi;*.mov";
            fd.FilterIndex = 1;
            fd.RestoreDirectory = true;


            if (fd.ShowDialog() == DialogResult.OK)
            {
                string[] files = fd.FileNames;
                for (int i = 0; i < files.Count(); i++)
                { 
                    if (!vids.Contains(files[i]))
                    {
                        vids.Add(files[i]);
                        AddVideos();
                    }
                }
                Edited = true;
            }

        }

        private void Setup_Load(object sender, EventArgs e)
        {

        }

        private void DeleteVideo_Click(object sender, EventArgs e)
        {
            ListViewItem selected = VideoList.SelectedItems[0];
            VideoList.Items.Remove(selected);
            vids.Remove(selected.Text);
            Edited = true;


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Tools.SetData(vids, Tools.Volume, Tools.AllowKeys);
            Application.Exit();
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            Tools.Volume = VolumeBar.Value;
            ToolTip tl = new ToolTip();
            VolumeLabel.Text = Convert.ToString(VolumeBar.Value);
            Edited = true;
        }

        private void EnableVolumeControlCB_CheckedChanged(object sender, EventArgs e)
        {
            Tools.AllowKeys = EnableVolumeControlCB.Checked;
            Edited = true;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Tools.SetData(vids, Tools.Volume, Tools.AllowKeys);
            ConfirmBtn.Enabled = false;
            edited = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}