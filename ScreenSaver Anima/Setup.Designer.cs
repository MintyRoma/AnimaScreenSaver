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
            this.BrowseVideo = new System.Windows.Forms.Button();
            this.DeleteVideo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.BUILDLABEL = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AbouObject = new System.Windows.Forms.Label();
            this.VideoList = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.VolumeBar.Location = new System.Drawing.Point(6, 19);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(308, 45);
            this.VolumeBar.TabIndex = 0;
            this.VolumeBar.TickFrequency = 10;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // EnableVolumeControlCB
            // 
            this.EnableVolumeControlCB.AutoSize = true;
            this.EnableVolumeControlCB.Location = new System.Drawing.Point(9, 70);
            this.EnableVolumeControlCB.Name = "EnableVolumeControlCB";
            this.EnableVolumeControlCB.Size = new System.Drawing.Size(301, 30);
            this.EnableVolumeControlCB.TabIndex = 1;
            this.EnableVolumeControlCB.Text = "Разрешить управление громкостью во время воспро-\r\nизведения с помощью клавиш <Вве" +
    "рх> и <Вниз>";
            this.EnableVolumeControlCB.UseVisualStyleBackColor = true;
            this.EnableVolumeControlCB.CheckedChanged += new System.EventHandler(this.EnableVolumeControlCB_CheckedChanged);
            // 
            // BrowseVideo
            // 
            this.BrowseVideo.Location = new System.Drawing.Point(262, 15);
            this.BrowseVideo.Name = "BrowseVideo";
            this.BrowseVideo.Size = new System.Drawing.Size(75, 23);
            this.BrowseVideo.TabIndex = 3;
            this.BrowseVideo.Text = "Добавить";
            this.BrowseVideo.UseVisualStyleBackColor = true;
            this.BrowseVideo.Click += new System.EventHandler(this.BrowseVideo_Click);
            // 
            // DeleteVideo
            // 
            this.DeleteVideo.Location = new System.Drawing.Point(262, 44);
            this.DeleteVideo.Name = "DeleteVideo";
            this.DeleteVideo.Size = new System.Drawing.Size(75, 23);
            this.DeleteVideo.TabIndex = 4;
            this.DeleteVideo.Text = "Удалить";
            this.DeleteVideo.UseVisualStyleBackColor = true;
            this.DeleteVideo.Click += new System.EventHandler(this.DeleteVideo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VolumeLabel);
            this.groupBox1.Controls.Add(this.VolumeBar);
            this.groupBox1.Controls.Add(this.EnableVolumeControlCB);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Громкость";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(312, 19);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(25, 13);
            this.VolumeLabel.TabIndex = 2;
            this.VolumeLabel.Text = "100";
            // 
            // BUILDLABEL
            // 
            this.BUILDLABEL.AutoSize = true;
            this.BUILDLABEL.Location = new System.Drawing.Point(18, 343);
            this.BUILDLABEL.Name = "BUILDLABEL";
            this.BUILDLABEL.Size = new System.Drawing.Size(0, 13);
            this.BUILDLABEL.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AbouObject);
            this.groupBox2.Controls.Add(this.VideoList);
            this.groupBox2.Controls.Add(this.BrowseVideo);
            this.groupBox2.Controls.Add(this.DeleteVideo);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 209);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Воспроизводимые видео";
            // 
            // AbouObject
            // 
            this.AbouObject.AutoSize = true;
            this.AbouObject.Location = new System.Drawing.Point(6, 190);
            this.AbouObject.Name = "AbouObject";
            this.AbouObject.Size = new System.Drawing.Size(10, 13);
            this.AbouObject.TabIndex = 6;
            this.AbouObject.Text = " ";
            // 
            // VideoList
            // 
            this.VideoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item});
            this.VideoList.GridLines = true;
            this.VideoList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.VideoList.HideSelection = false;
            this.VideoList.Location = new System.Drawing.Point(6, 15);
            this.VideoList.MultiSelect = false;
            this.VideoList.Name = "VideoList";
            this.VideoList.Size = new System.Drawing.Size(250, 172);
            this.VideoList.TabIndex = 5;
            this.VideoList.UseCompatibleStateImageBehavior = false;
            this.VideoList.View = System.Windows.Forms.View.Details;
            this.VideoList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoList_KeyDown);
            // 
            // Item
            // 
            this.Item.Text = "";
            this.Item.Width = 260;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(274, 345);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Enabled = false;
            this.ConfirmBtn.Location = new System.Drawing.Point(186, 345);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(82, 23);
            this.ConfirmBtn.TabIndex = 7;
            this.ConfirmBtn.Text = "Принять";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(98, 345);
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
            this.ClientSize = new System.Drawing.Size(365, 380);
            this.Controls.Add(this.BUILDLABEL);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.CheckBox EnableVolumeControlCB;
        private System.Windows.Forms.Button BrowseVideo;
        private System.Windows.Forms.Button DeleteVideo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label BUILDLABEL;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.ListView VideoList;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.Label AbouObject;
    }
}