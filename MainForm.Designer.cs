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
            this.button_smalModeWindow = new System.Windows.Forms.Button();
            this.button_pauseRecord = new System.Windows.Forms.Button();
            this.button_playRecord = new System.Windows.Forms.Button();
            this.checkBox_isRecordSound = new System.Windows.Forms.CheckBox();
            this.checkBox_isBuildVideoAndAudio = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_startRecord
            // 
            this.button_startRecord.Location = new System.Drawing.Point(32, 39);
            this.button_startRecord.Name = "button_startRecord";
            this.button_startRecord.Size = new System.Drawing.Size(175, 41);
            this.button_startRecord.TabIndex = 0;
            this.button_startRecord.Text = "Начать запись";
            this.button_startRecord.UseVisualStyleBackColor = true;
            this.button_startRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_stopRecord
            // 
            this.button_stopRecord.Location = new System.Drawing.Point(32, 86);
            this.button_stopRecord.Name = "button_stopRecord";
            this.button_stopRecord.Size = new System.Drawing.Size(175, 41);
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
            this.label_timer.Location = new System.Drawing.Point(12, 9);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(108, 27);
            this.label_timer.TabIndex = 5;
            this.label_timer.Text = "00:00:00";
            // 
            // button_screenshot
            // 
            this.button_screenshot.Location = new System.Drawing.Point(210, 140);
            this.button_screenshot.Name = "button_screenshot";
            this.button_screenshot.Size = new System.Drawing.Size(175, 37);
            this.button_screenshot.TabIndex = 6;
            this.button_screenshot.Text = "Снимок экрана";
            this.button_screenshot.UseVisualStyleBackColor = true;
            this.button_screenshot.Click += new System.EventHandler(this.button_screenshot_Click);
            // 
            // button_fastScreenshot
            // 
            this.button_fastScreenshot.Location = new System.Drawing.Point(210, 183);
            this.button_fastScreenshot.Name = "button_fastScreenshot";
            this.button_fastScreenshot.Size = new System.Drawing.Size(175, 27);
            this.button_fastScreenshot.TabIndex = 7;
            this.button_fastScreenshot.Text = "Быстрый снимок";
            this.button_fastScreenshot.UseVisualStyleBackColor = true;
            // 
            // button_openSettings
            // 
            this.button_openSettings.Location = new System.Drawing.Point(161, 375);
            this.button_openSettings.Name = "button_openSettings";
            this.button_openSettings.Size = new System.Drawing.Size(174, 32);
            this.button_openSettings.TabIndex = 8;
            this.button_openSettings.Text = "Настройки";
            this.button_openSettings.UseVisualStyleBackColor = true;
            this.button_openSettings.Click += new System.EventHandler(this.button_openSettings_Click);
            // 
            // button_smalModeWindow
            // 
            this.button_smalModeWindow.Location = new System.Drawing.Point(58, 371);
            this.button_smalModeWindow.Name = "button_smalModeWindow";
            this.button_smalModeWindow.Size = new System.Drawing.Size(97, 40);
            this.button_smalModeWindow.TabIndex = 9;
            this.button_smalModeWindow.Text = "Уменьшить";
            this.button_smalModeWindow.UseVisualStyleBackColor = true;
            // 
            // button_pauseRecord
            // 
            this.button_pauseRecord.Location = new System.Drawing.Point(18, 236);
            this.button_pauseRecord.Name = "button_pauseRecord";
            this.button_pauseRecord.Size = new System.Drawing.Size(63, 37);
            this.button_pauseRecord.TabIndex = 10;
            this.button_pauseRecord.Text = "Пауза";
            this.button_pauseRecord.UseVisualStyleBackColor = true;
            this.button_pauseRecord.Click += new System.EventHandler(this.button_pauseRecord_Click);
            // 
            // button_playRecord
            // 
            this.button_playRecord.Location = new System.Drawing.Point(87, 236);
            this.button_playRecord.Name = "button_playRecord";
            this.button_playRecord.Size = new System.Drawing.Size(105, 37);
            this.button_playRecord.TabIndex = 11;
            this.button_playRecord.Text = "Продолжить";
            this.button_playRecord.UseVisualStyleBackColor = true;
            this.button_playRecord.Click += new System.EventHandler(this.button_playRecord_Click);
            // 
            // checkBox_isRecordSound
            // 
            this.checkBox_isRecordSound.AutoSize = true;
            this.checkBox_isRecordSound.Location = new System.Drawing.Point(10, 291);
            this.checkBox_isRecordSound.Name = "checkBox_isRecordSound";
            this.checkBox_isRecordSound.Size = new System.Drawing.Size(197, 20);
            this.checkBox_isRecordSound.TabIndex = 12;
            this.checkBox_isRecordSound.Text = "Запись системного звука";
            this.checkBox_isRecordSound.UseVisualStyleBackColor = true;
            this.checkBox_isRecordSound.CheckedChanged += new System.EventHandler(this.checkBox_isRecordSound_CheckedChanged);
            // 
            // checkBox_isBuildVideoAndAudio
            // 
            this.checkBox_isBuildVideoAndAudio.AutoSize = true;
            this.checkBox_isBuildVideoAndAudio.Location = new System.Drawing.Point(10, 317);
            this.checkBox_isBuildVideoAndAudio.Name = "checkBox_isBuildVideoAndAudio";
            this.checkBox_isBuildVideoAndAudio.Size = new System.Drawing.Size(206, 20);
            this.checkBox_isBuildVideoAndAudio.TabIndex = 13;
            this.checkBox_isBuildVideoAndAudio.Text = "Сохранить аудио отдельно";
            this.checkBox_isBuildVideoAndAudio.UseVisualStyleBackColor = true;
            this.checkBox_isBuildVideoAndAudio.CheckedChanged += new System.EventHandler(this.checkBox_isBuildVideoAndAudio_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 420);
            this.Controls.Add(this.checkBox_isBuildVideoAndAudio);
            this.Controls.Add(this.checkBox_isRecordSound);
            this.Controls.Add(this.button_playRecord);
            this.Controls.Add(this.button_pauseRecord);
            this.Controls.Add(this.button_smalModeWindow);
            this.Controls.Add(this.button_openSettings);
            this.Controls.Add(this.button_fastScreenshot);
            this.Controls.Add(this.button_screenshot);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.button_stopRecord);
            this.Controls.Add(this.button_startRecord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "VSC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
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
        private System.Windows.Forms.Button button_smalModeWindow;
        private System.Windows.Forms.Button button_pauseRecord;
        private System.Windows.Forms.Button button_playRecord;
        private System.Windows.Forms.CheckBox checkBox_isRecordSound;
        private System.Windows.Forms.CheckBox checkBox_isBuildVideoAndAudio;
    }
}