namespace Video_Screen_Capture
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_startRecord = new System.Windows.Forms.Button();
            this.button_stopRecord = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_timer = new System.Windows.Forms.Label();
            this.button_screenshot = new System.Windows.Forms.Button();
            this.button_fastScreenshot = new System.Windows.Forms.Button();
            this.button_openSettings = new System.Windows.Forms.Button();
            this.button_pauseRecord = new System.Windows.Forms.Button();
            this.button_playRecord = new System.Windows.Forms.Button();
            this.checkBox_isRecordSound = new System.Windows.Forms.CheckBox();
            this.checkBox_isBuildVideoAndAudio = new System.Windows.Forms.CheckBox();
            this.checkBox_usingMic = new System.Windows.Forms.CheckBox();
            this.checkBox_usingWebcam = new System.Windows.Forms.CheckBox();
            this.panel_sm = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_info = new System.Windows.Forms.PictureBox();
            this.button_s_play = new System.Windows.Forms.PictureBox();
            this.button_s_start = new System.Windows.Forms.PictureBox();
            this.button_bigWindow = new System.Windows.Forms.PictureBox();
            this.button_s_pause = new System.Windows.Forms.PictureBox();
            this.button_s_fastScreenshot = new System.Windows.Forms.PictureBox();
            this.button_s_stop = new System.Windows.Forms.PictureBox();
            this.button_smalModeWindow = new System.Windows.Forms.PictureBox();
            this.panel_sm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_s_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_s_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_bigWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_s_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_s_fastScreenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_s_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_smalModeWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // button_startRecord
            // 
            this.button_startRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_startRecord.Location = new System.Drawing.Point(10, 30);
            this.button_startRecord.Name = "button_startRecord";
            this.button_startRecord.Size = new System.Drawing.Size(206, 41);
            this.button_startRecord.TabIndex = 0;
            this.button_startRecord.Text = "Начать запись";
            this.button_startRecord.UseVisualStyleBackColor = true;
            this.button_startRecord.Click += new System.EventHandler(this.button_startRecord_Click);
            // 
            // button_stopRecord
            // 
            this.button_stopRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stopRecord.Location = new System.Drawing.Point(10, 77);
            this.button_stopRecord.Name = "button_stopRecord";
            this.button_stopRecord.Size = new System.Drawing.Size(206, 41);
            this.button_stopRecord.TabIndex = 1;
            this.button_stopRecord.Text = "Остановить";
            this.button_stopRecord.UseVisualStyleBackColor = true;
            this.button_stopRecord.Click += new System.EventHandler(this.button_stopRecord_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.Location = new System.Drawing.Point(68, 0);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(108, 27);
            this.label_timer.TabIndex = 5;
            this.label_timer.Text = "00:00:00";
            // 
            // button_screenshot
            // 
            this.button_screenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_screenshot.Location = new System.Drawing.Point(10, 167);
            this.button_screenshot.Name = "button_screenshot";
            this.button_screenshot.Size = new System.Drawing.Size(206, 37);
            this.button_screenshot.TabIndex = 6;
            this.button_screenshot.Text = "Снимок экрана";
            this.button_screenshot.UseVisualStyleBackColor = true;
            this.button_screenshot.Click += new System.EventHandler(this.button_screenshot_Click);
            // 
            // button_fastScreenshot
            // 
            this.button_fastScreenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fastScreenshot.Location = new System.Drawing.Point(10, 210);
            this.button_fastScreenshot.Name = "button_fastScreenshot";
            this.button_fastScreenshot.Size = new System.Drawing.Size(206, 27);
            this.button_fastScreenshot.TabIndex = 7;
            this.button_fastScreenshot.Text = "Быстрый снимок";
            this.button_fastScreenshot.UseVisualStyleBackColor = true;
            this.button_fastScreenshot.Click += new System.EventHandler(this.button_fastScreenshot_Click);
            // 
            // button_openSettings
            // 
            this.button_openSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_openSettings.Location = new System.Drawing.Point(10, 348);
            this.button_openSettings.Name = "button_openSettings";
            this.button_openSettings.Size = new System.Drawing.Size(206, 32);
            this.button_openSettings.TabIndex = 8;
            this.button_openSettings.Text = "Настройки";
            this.button_openSettings.UseVisualStyleBackColor = true;
            this.button_openSettings.Click += new System.EventHandler(this.button_openSettings_Click);
            // 
            // button_pauseRecord
            // 
            this.button_pauseRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pauseRecord.Location = new System.Drawing.Point(10, 124);
            this.button_pauseRecord.Name = "button_pauseRecord";
            this.button_pauseRecord.Size = new System.Drawing.Size(84, 37);
            this.button_pauseRecord.TabIndex = 10;
            this.button_pauseRecord.Text = "Пауза";
            this.button_pauseRecord.UseVisualStyleBackColor = true;
            this.button_pauseRecord.Click += new System.EventHandler(this.button_pauseRecord_Click);
            // 
            // button_playRecord
            // 
            this.button_playRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_playRecord.Location = new System.Drawing.Point(100, 124);
            this.button_playRecord.Name = "button_playRecord";
            this.button_playRecord.Size = new System.Drawing.Size(116, 37);
            this.button_playRecord.TabIndex = 11;
            this.button_playRecord.Text = "Продолжить";
            this.button_playRecord.UseVisualStyleBackColor = true;
            this.button_playRecord.Click += new System.EventHandler(this.button_playRecord_Click);
            // 
            // checkBox_isRecordSound
            // 
            this.checkBox_isRecordSound.AutoSize = true;
            this.checkBox_isRecordSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_isRecordSound.Location = new System.Drawing.Point(10, 243);
            this.checkBox_isRecordSound.Name = "checkBox_isRecordSound";
            this.checkBox_isRecordSound.Size = new System.Drawing.Size(193, 20);
            this.checkBox_isRecordSound.TabIndex = 12;
            this.checkBox_isRecordSound.Text = "Запись системного звука";
            this.checkBox_isRecordSound.UseVisualStyleBackColor = true;
            this.checkBox_isRecordSound.CheckedChanged += new System.EventHandler(this.checkBox_isRecordSound_CheckedChanged);
            // 
            // checkBox_isBuildVideoAndAudio
            // 
            this.checkBox_isBuildVideoAndAudio.AutoSize = true;
            this.checkBox_isBuildVideoAndAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_isBuildVideoAndAudio.Location = new System.Drawing.Point(10, 269);
            this.checkBox_isBuildVideoAndAudio.Name = "checkBox_isBuildVideoAndAudio";
            this.checkBox_isBuildVideoAndAudio.Size = new System.Drawing.Size(202, 20);
            this.checkBox_isBuildVideoAndAudio.TabIndex = 13;
            this.checkBox_isBuildVideoAndAudio.Text = "Сохранить аудио отдельно";
            this.checkBox_isBuildVideoAndAudio.UseVisualStyleBackColor = true;
            this.checkBox_isBuildVideoAndAudio.CheckedChanged += new System.EventHandler(this.checkBox_isBuildVideoAndAudio_CheckedChanged);
            // 
            // checkBox_usingMic
            // 
            this.checkBox_usingMic.AutoSize = true;
            this.checkBox_usingMic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_usingMic.Location = new System.Drawing.Point(10, 295);
            this.checkBox_usingMic.Name = "checkBox_usingMic";
            this.checkBox_usingMic.Size = new System.Drawing.Size(202, 20);
            this.checkBox_usingMic.TabIndex = 14;
            this.checkBox_usingMic.Text = "Запись звука с микрофона";
            this.checkBox_usingMic.UseVisualStyleBackColor = true;
            this.checkBox_usingMic.CheckedChanged += new System.EventHandler(this.checkBox_usingMic_CheckedChanged);
            // 
            // checkBox_usingWebcam
            // 
            this.checkBox_usingWebcam.AutoSize = true;
            this.checkBox_usingWebcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_usingWebcam.Location = new System.Drawing.Point(10, 322);
            this.checkBox_usingWebcam.Name = "checkBox_usingWebcam";
            this.checkBox_usingWebcam.Size = new System.Drawing.Size(98, 20);
            this.checkBox_usingWebcam.TabIndex = 15;
            this.checkBox_usingWebcam.Text = "Вебкамера";
            this.checkBox_usingWebcam.UseVisualStyleBackColor = true;
            this.checkBox_usingWebcam.CheckedChanged += new System.EventHandler(this.checkBox_usingWebcam_CheckedChanged);
            // 
            // panel_sm
            // 
            this.panel_sm.Controls.Add(this.button_s_play);
            this.panel_sm.Controls.Add(this.button_s_start);
            this.panel_sm.Controls.Add(this.button_bigWindow);
            this.panel_sm.Controls.Add(this.button_s_pause);
            this.panel_sm.Controls.Add(this.button_s_fastScreenshot);
            this.panel_sm.Controls.Add(this.button_s_stop);
            this.panel_sm.Location = new System.Drawing.Point(5, 30);
            this.panel_sm.Name = "panel_sm";
            this.panel_sm.Size = new System.Drawing.Size(242, 131);
            this.panel_sm.TabIndex = 16;
            this.panel_sm.Visible = false;
            // 
            // button_info
            // 
            this.button_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_info.Image = global::Video_Screen_Capture.Properties.Resources.info;
            this.button_info.Location = new System.Drawing.Point(222, 348);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(32, 32);
            this.button_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_info.TabIndex = 18;
            this.button_info.TabStop = false;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // button_s_play
            // 
            this.button_s_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_s_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_s_play.Image = global::Video_Screen_Capture.Properties.Resources.butt_playRec;
            this.button_s_play.Location = new System.Drawing.Point(82, 3);
            this.button_s_play.Name = "button_s_play";
            this.button_s_play.Size = new System.Drawing.Size(30, 34);
            this.button_s_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_s_play.TabIndex = 5;
            this.button_s_play.TabStop = false;
            this.toolTip1.SetToolTip(this.button_s_play, "Продолжить запись");
            this.button_s_play.EnabledChanged += new System.EventHandler(this.button_s_play_EnabledChanged);
            this.button_s_play.Click += new System.EventHandler(this.button_playRecord_Click);
            // 
            // button_s_start
            // 
            this.button_s_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_s_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_s_start.Image = global::Video_Screen_Capture.Properties.Resources.butt_startRec;
            this.button_s_start.Location = new System.Drawing.Point(0, 3);
            this.button_s_start.Name = "button_s_start";
            this.button_s_start.Size = new System.Drawing.Size(30, 34);
            this.button_s_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_s_start.TabIndex = 4;
            this.button_s_start.TabStop = false;
            this.toolTip1.SetToolTip(this.button_s_start, "Начать запись");
            this.button_s_start.EnabledChanged += new System.EventHandler(this.button_s_start_EnabledChanged);
            this.button_s_start.Click += new System.EventHandler(this.button_startRecord_Click);
            // 
            // button_bigWindow
            // 
            this.button_bigWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_bigWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_bigWindow.Image = global::Video_Screen_Capture.Properties.Resources.butt_small_1;
            this.button_bigWindow.Location = new System.Drawing.Point(202, 3);
            this.button_bigWindow.Name = "button_bigWindow";
            this.button_bigWindow.Size = new System.Drawing.Size(30, 34);
            this.button_bigWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_bigWindow.TabIndex = 3;
            this.button_bigWindow.TabStop = false;
            this.toolTip1.SetToolTip(this.button_bigWindow, "Увеличить");
            this.button_bigWindow.Click += new System.EventHandler(this.button_bigWindow_Click);
            // 
            // button_s_pause
            // 
            this.button_s_pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_s_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_s_pause.Image = global::Video_Screen_Capture.Properties.Resources.butt_pauseRec;
            this.button_s_pause.Location = new System.Drawing.Point(118, 3);
            this.button_s_pause.Name = "button_s_pause";
            this.button_s_pause.Size = new System.Drawing.Size(30, 34);
            this.button_s_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_s_pause.TabIndex = 2;
            this.button_s_pause.TabStop = false;
            this.toolTip1.SetToolTip(this.button_s_pause, "Остановить запись");
            this.button_s_pause.EnabledChanged += new System.EventHandler(this.button_s_pause_EnabledChanged);
            this.button_s_pause.Click += new System.EventHandler(this.button_pauseRecord_Click);
            // 
            // button_s_fastScreenshot
            // 
            this.button_s_fastScreenshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_s_fastScreenshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_s_fastScreenshot.Image = global::Video_Screen_Capture.Properties.Resources.butt_screenshot;
            this.button_s_fastScreenshot.Location = new System.Drawing.Point(160, 3);
            this.button_s_fastScreenshot.Name = "button_s_fastScreenshot";
            this.button_s_fastScreenshot.Size = new System.Drawing.Size(30, 34);
            this.button_s_fastScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_s_fastScreenshot.TabIndex = 1;
            this.button_s_fastScreenshot.TabStop = false;
            this.toolTip1.SetToolTip(this.button_s_fastScreenshot, "Сделать снимок");
            this.button_s_fastScreenshot.EnabledChanged += new System.EventHandler(this.button_s_fastScreenshot_EnabledChanged);
            this.button_s_fastScreenshot.Click += new System.EventHandler(this.button_fastScreenshot_Click);
            // 
            // button_s_stop
            // 
            this.button_s_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_s_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_s_stop.Image = global::Video_Screen_Capture.Properties.Resources.butt_stopRec;
            this.button_s_stop.Location = new System.Drawing.Point(36, 3);
            this.button_s_stop.Name = "button_s_stop";
            this.button_s_stop.Size = new System.Drawing.Size(30, 34);
            this.button_s_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_s_stop.TabIndex = 0;
            this.button_s_stop.TabStop = false;
            this.toolTip1.SetToolTip(this.button_s_stop, "Завершить запись");
            this.button_s_stop.EnabledChanged += new System.EventHandler(this.button_s_stop_EnabledChanged);
            this.button_s_stop.Click += new System.EventHandler(this.button_stopRecord_Click);
            // 
            // button_smalModeWindow
            // 
            this.button_smalModeWindow.BackgroundImage = global::Video_Screen_Capture.Properties.Resources.butt_small_2;
            this.button_smalModeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_smalModeWindow.Location = new System.Drawing.Point(222, 33);
            this.button_smalModeWindow.Name = "button_smalModeWindow";
            this.button_smalModeWindow.Size = new System.Drawing.Size(25, 309);
            this.button_smalModeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_smalModeWindow.TabIndex = 17;
            this.button_smalModeWindow.TabStop = false;
            this.toolTip1.SetToolTip(this.button_smalModeWindow, "Уменьшить");
            this.button_smalModeWindow.Click += new System.EventHandler(this.button_smalModeWindow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 386);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.panel_sm);
            this.Controls.Add(this.checkBox_usingWebcam);
            this.Controls.Add(this.checkBox_usingMic);
            this.Controls.Add(this.checkBox_isBuildVideoAndAudio);
            this.Controls.Add(this.checkBox_isRecordSound);
            this.Controls.Add(this.button_playRecord);
            this.Controls.Add(this.button_pauseRecord);
            this.Controls.Add(this.button_openSettings);
            this.Controls.Add(this.button_fastScreenshot);
            this.Controls.Add(this.button_screenshot);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.button_stopRecord);
            this.Controls.Add(this.button_startRecord);
            this.Controls.Add(this.button_smalModeWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VSC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel_sm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_s_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_s_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_bigWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_s_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_s_fastScreenshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_s_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_smalModeWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_startRecord;
        private System.Windows.Forms.Button button_stopRecord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Button button_screenshot;
        private System.Windows.Forms.Button button_fastScreenshot;
        private System.Windows.Forms.Button button_openSettings;
        private System.Windows.Forms.Button button_pauseRecord;
        private System.Windows.Forms.Button button_playRecord;
        private System.Windows.Forms.CheckBox checkBox_isRecordSound;
        private System.Windows.Forms.CheckBox checkBox_isBuildVideoAndAudio;
        private System.Windows.Forms.CheckBox checkBox_usingMic;
        private System.Windows.Forms.CheckBox checkBox_usingWebcam;
        private System.Windows.Forms.Panel panel_sm;
        private System.Windows.Forms.PictureBox button_smalModeWindow;
        private System.Windows.Forms.PictureBox button_s_stop;
        private System.Windows.Forms.PictureBox button_s_play;
        private System.Windows.Forms.PictureBox button_s_start;
        private System.Windows.Forms.PictureBox button_bigWindow;
        private System.Windows.Forms.PictureBox button_s_pause;
        private System.Windows.Forms.PictureBox button_s_fastScreenshot;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox button_info;
    }
}