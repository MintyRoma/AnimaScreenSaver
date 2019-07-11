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
            this.debug = new System.Windows.Forms.Label();
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
            this.vid.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Vid_PlayStateChange);
            this.vid.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.Vid_ClickEvent);
            this.vid.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.Vid_KeyDownEvent);
            this.vid.KeyPressEvent += new AxWMPLib._WMPOCXEvents_KeyPressEventHandler(this.Vid_KeyPressEvent);
            this.vid.MouseDownEvent += new AxWMPLib._WMPOCXEvents_MouseDownEventHandler(this.Vid_MouseDownEvent);
            this.vid.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.Vid_MouseMoveEvent);
            this.vid.Enter += new System.EventHandler(this.Vid_Enter);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.BackColor = System.Drawing.Color.Silver;
            this.debug.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debug.ForeColor = System.Drawing.Color.Red;
            this.debug.Location = new System.Drawing.Point(12, 9);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(0, 46);
            this.debug.TabIndex = 1;
            // 
            // WMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.vid);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WMP";
            this.Text = "WMP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WMP_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WMP_KeyDown_1);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WMP_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WMP_MouseMove_1);
            ((System.ComponentModel.ISupportInitialize)(this.vid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer vid;
        private System.Windows.Forms.Label debug;
    }
}