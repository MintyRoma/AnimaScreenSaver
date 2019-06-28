namespace ScreenSaver_Anima
{
    partial class WMP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WMP));
            this.vid = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.vid)).BeginInit();
            this.SuspendLayout();
            // 
            // vid
            // 
            this.vid.Dock = System.Windows.Forms.DockStyle.Left;
            this.vid.Enabled = true;
            this.vid.Location = new System.Drawing.Point(0, 0);
            this.vid.Name = "vid";
            this.vid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vid.OcxState")));
            this.vid.Size = new System.Drawing.Size(800, 450);
            this.vid.TabIndex = 0;
            this.vid.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.Vid_ClickEvent);
            this.vid.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.Vid_KeyDownEvent);
            this.vid.MouseDownEvent += new AxWMPLib._WMPOCXEvents_MouseDownEventHandler(this.Vid_MouseDownEvent);
            this.vid.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.Vid_MouseMoveEvent);
            // 
            // WMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WMP";
            this.Text = "WMP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WMP_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.vid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer vid;
    }
}