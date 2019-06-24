 namespace ScreenSaver_Anima
{
    partial class Setup
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
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.EnableVolumeControlCB = new System.Windows.Forms.CheckBox();
            this.VideoList = new System.Windows.Forms.ListBox();
            this.BrowseVideo = new System.Windows.Forms.Button();
            this.DeleteVideo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BUILDLABEL = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(6, 37);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(271, 45);
            this.VolumeBar.TabIndex = 0;
            this.VolumeBar.TickFrequency = 10;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // EnableVolumeControlCB
            // 
            this.EnableVolumeControlCB.AutoSize = true;
            this.EnableVolumeControlCB.Location = new System.Drawing.Point(6, 88);
            this.EnableVolumeControlCB.Name = "EnableVolumeControlCB";
            this.EnableVolumeControlCB.Size = new System.Drawing.Size(227, 43);
            this.EnableVolumeControlCB.TabIndex = 1;
            this.EnableVolumeControlCB.Text = "Разрешить управление громкостью\r\nво время воспроизведения с помощью\r\nклавиш <Ввер" +
    "х> и <Вниз>";
            this.EnableVolumeControlCB.UseVisualStyleBackColor = true;
            this.EnableVolumeControlCB.CheckedChanged += new System.EventHandler(this.EnableVolumeControlCB_CheckedChanged);
            // 
            // VideoList
            // 
            this.VideoList.FormattingEnabled = true;
            this.VideoList.Location = new System.Drawing.Point(6, 15);
            this.VideoList.Name = "VideoList";
            this.VideoList.Size = new System.Drawing.Size(271, 95);
            this.VideoList.TabIndex = 2;
            // 
            // BrowseVideo
            // 
            this.BrowseVideo.Location = new System.Drawing.Point(6, 116);
            this.BrowseVideo.Name = "BrowseVideo";
            this.BrowseVideo.Size = new System.Drawing.Size(142, 23);
            this.BrowseVideo.TabIndex = 3;
            this.BrowseVideo.Text = "Добавить видео";
            this.BrowseVideo.UseVisualStyleBackColor = true;
            this.BrowseVideo.Click += new System.EventHandler(this.BrowseVideo_Click);
            // 
            // DeleteVideo
            // 
            this.DeleteVideo.Location = new System.Drawing.Point(198, 117);
            this.DeleteVideo.Name = "DeleteVideo";
            this.DeleteVideo.Size = new System.Drawing.Size(74, 23);
            this.DeleteVideo.TabIndex = 4;
            this.DeleteVideo.Text = "Удалить";
            this.DeleteVideo.UseVisualStyleBackColor = true;
            this.DeleteVideo.Click += new System.EventHandler(this.DeleteVideo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BUILDLABEL);
            this.groupBox1.Controls.Add(this.VolumeBar);
            this.groupBox1.Controls.Add(this.EnableVolumeControlCB);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Громкость";
            // 
            // BUILDLABEL
            // 
            this.BUILDLABEL.AutoSize = true;
            this.BUILDLABEL.Location = new System.Drawing.Point(6, 134);
            this.BUILDLABEL.Name = "BUILDLABEL";
            this.BUILDLABEL.Size = new System.Drawing.Size(0, 13);
            this.BUILDLABEL.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VideoList);
            this.groupBox2.Controls.Add(this.BrowseVideo);
            this.groupBox2.Controls.Add(this.DeleteVideo);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 162);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Воспроизводимые видео";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(224, 369);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(136, 369);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(82, 23);
            this.ConfirmBtn.TabIndex = 7;
            this.ConfirmBtn.Text = "Принять";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(48, 369);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(82, 23);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 404);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setup";
            this.Text = "Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setup_FormClosing);
            this.Load += new System.EventHandler(this.Setup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.CheckBox EnableVolumeControlCB;
        private System.Windows.Forms.ListBox VideoList;
        private System.Windows.Forms.Button BrowseVideo;
        private System.Windows.Forms.Button DeleteVideo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label BUILDLABEL;
    }
}