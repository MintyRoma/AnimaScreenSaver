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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(289, 21);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(227, 45);
            this.VolumeBar.TabIndex = 0;
            this.VolumeBar.TickFrequency = 10;
            // 
            // EnableVolumeControlCB
            // 
            this.EnableVolumeControlCB.AutoSize = true;
            this.EnableVolumeControlCB.Location = new System.Drawing.Point(289, 63);
            this.EnableVolumeControlCB.Name = "EnableVolumeControlCB";
            this.EnableVolumeControlCB.Size = new System.Drawing.Size(227, 56);
            this.EnableVolumeControlCB.TabIndex = 1;
            this.EnableVolumeControlCB.Text = "Управление клавишами\r\nРазрешить управление громкостью\r\nво время воспроизведения с" +
    " помощью\r\nклавиш <Вверх> и <Вниз>";
            this.EnableVolumeControlCB.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 95);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить видео";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 324);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.EnableVolumeControlCB);
            this.Controls.Add(this.VolumeBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setup";
            this.Text = "Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setup_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.CheckBox EnableVolumeControlCB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}