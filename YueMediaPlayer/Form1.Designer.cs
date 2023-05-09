namespace YueMediaPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_playMusic = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助F1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_music = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trackBar_audioPos = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label_volumn = new System.Windows.Forms.Label();
            this.button_pause = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_audioPos)).BeginInit();
            this.SuspendLayout();
            // 
            // button_playMusic
            // 
            this.button_playMusic.Location = new System.Drawing.Point(713, 415);
            this.button_playMusic.Name = "button_playMusic";
            this.button_playMusic.Size = new System.Drawing.Size(75, 23);
            this.button_playMusic.TabIndex = 0;
            this.button_playMusic.Text = "播放音乐";
            this.button_playMusic.UseVisualStyleBackColor = true;
            this.button_playMusic.Click += new System.EventHandler(this.button_playMusic_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助F1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.打开文件夹ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.menu_openAudioFiles);
            // 
            // 打开文件夹ToolStripMenuItem
            // 
            this.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem";
            this.打开文件夹ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.打开文件夹ToolStripMenuItem.Text = "打开文件夹";
            // 
            // 帮助F1ToolStripMenuItem
            // 
            this.帮助F1ToolStripMenuItem.Name = "帮助F1ToolStripMenuItem";
            this.帮助F1ToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.帮助F1ToolStripMenuItem.Text = "帮助(F1)";
            // 
            // listView_music
            // 
            this.listView_music.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_music.FullRowSelect = true;
            this.listView_music.HideSelection = false;
            this.listView_music.Location = new System.Drawing.Point(12, 28);
            this.listView_music.MultiSelect = false;
            this.listView_music.Name = "listView_music";
            this.listView_music.Size = new System.Drawing.Size(776, 342);
            this.listView_music.TabIndex = 2;
            this.listView_music.UseCompatibleStateImageBehavior = false;
            this.listView_music.View = System.Windows.Forms.View.Details;
            this.listView_music.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_music_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "曲名";
            this.columnHeader2.Width = 320;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "路径";
            this.columnHeader3.Width = 100;
            // 
            // trackBar_audioPos
            // 
            this.trackBar_audioPos.Location = new System.Drawing.Point(49, 415);
            this.trackBar_audioPos.Maximum = 100;
            this.trackBar_audioPos.Name = "trackBar_audioPos";
            this.trackBar_audioPos.Size = new System.Drawing.Size(273, 45);
            this.trackBar_audioPos.TabIndex = 4;
            this.trackBar_audioPos.ValueChanged += new System.EventHandler(this.trackBar_audioPos_ValueChanged);
            this.trackBar_audioPos.MouseCaptureChanged += new System.EventHandler(this.trackBar_audioPos_MouseCaptureChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "音量：";
            // 
            // label_volumn
            // 
            this.label_volumn.AutoSize = true;
            this.label_volumn.Location = new System.Drawing.Point(329, 425);
            this.label_volumn.Name = "label_volumn";
            this.label_volumn.Size = new System.Drawing.Size(23, 12);
            this.label_volumn.TabIndex = 6;
            this.label_volumn.Text = "50%";
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(632, 415);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(75, 23);
            this.button_pause.TabIndex = 7;
            this.button_pause.Text = "暂停";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.label_volumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_audioPos);
            this.Controls.Add(this.listView_music);
            this.Controls.Add(this.button_playMusic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_audioPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_playMusic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助F1ToolStripMenuItem;
        private System.Windows.Forms.ListView listView_music;
        private System.Windows.Forms.TrackBar trackBar_audioPos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_volumn;
        private System.Windows.Forms.Button button_pause;
    }
}

