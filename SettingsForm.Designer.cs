namespace Video_Screen_Capture
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.button_viewStandartPathSaveFastScreenshot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_StandartPathSaveFastScreenshot = new System.Windows.Forms.TextBox();
            this.numericUpDown_bitRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_MarkCursorSize = new System.Windows.Forms.NumericUpDown();
            this.checkBox_drawCursor = new System.Windows.Forms.CheckBox();
            this.checkBox_MarkCursor = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_openWebcamSettings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_usingMic = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_MicDevIndex = new System.Windows.Forms.ComboBox();
            this.checkBox_isBuildVideoAndAudio = new System.Windows.Forms.CheckBox();
            this.checkBox_isRecordSound = new System.Windows.Forms.CheckBox();
            this.checkBox_view_TopWindows = new System.Windows.Forms.CheckBox();
            this.checkBox_viewIconOnTaskBar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bitRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MarkCursorSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_viewStandartPathSaveFastScreenshot
            // 
            this.button_viewStandartPathSaveFastScreenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_viewStandartPathSaveFastScreenshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_viewStandartPathSaveFastScreenshot.Location = new System.Drawing.Point(832, 5);
            this.button_viewStandartPathSaveFastScreenshot.Name = "button_viewStandartPathSaveFastScreenshot";
            this.button_viewStandartPathSaveFastScreenshot.Size = new System.Drawing.Size(75, 25);
            this.button_viewStandartPathSaveFastScreenshot.TabIndex = 0;
            this.button_viewStandartPathSaveFastScreenshot.Text = "Обзор";
            this.button_viewStandartPathSaveFastScreenshot.UseVisualStyleBackColor = true;
            this.button_viewStandartPathSaveFastScreenshot.Click += new System.EventHandler(this.button_viewStandartPathSaveFastScreenshot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сохранять быстрые снимки экрана в:";
            // 
            // textBox_StandartPathSaveFastScreenshot
            // 
            this.textBox_StandartPathSaveFastScreenshot.Location = new System.Drawing.Point(259, 6);
            this.textBox_StandartPathSaveFastScreenshot.Name = "textBox_StandartPathSaveFastScreenshot";
            this.textBox_StandartPathSaveFastScreenshot.ReadOnly = true;
            this.textBox_StandartPathSaveFastScreenshot.Size = new System.Drawing.Size(567, 22);
            this.textBox_StandartPathSaveFastScreenshot.TabIndex = 2;
            // 
            // numericUpDown_bitRate
            // 
            this.numericUpDown_bitRate.Location = new System.Drawing.Point(503, 154);
            this.numericUpDown_bitRate.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.numericUpDown_bitRate.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_bitRate.Name = "numericUpDown_bitRate";
            this.numericUpDown_bitRate.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_bitRate.TabIndex = 3;
            this.numericUpDown_bitRate.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_bitRate.ValueChanged += new System.EventHandler(this.numericUpDown_bitRate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "BitRate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Размер выделения курсора";
            // 
            // numericUpDown_MarkCursorSize
            // 
            this.numericUpDown_MarkCursorSize.Location = new System.Drawing.Point(229, 79);
            this.numericUpDown_MarkCursorSize.Name = "numericUpDown_MarkCursorSize";
            this.numericUpDown_MarkCursorSize.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_MarkCursorSize.TabIndex = 6;
            this.numericUpDown_MarkCursorSize.ValueChanged += new System.EventHandler(this.numericUpDown_MarkCursorSize_ValueChanged);
            // 
            // checkBox_drawCursor
            // 
            this.checkBox_drawCursor.AutoSize = true;
            this.checkBox_drawCursor.Location = new System.Drawing.Point(14, 27);
            this.checkBox_drawCursor.Name = "checkBox_drawCursor";
            this.checkBox_drawCursor.Size = new System.Drawing.Size(158, 20);
            this.checkBox_drawCursor.TabIndex = 8;
            this.checkBox_drawCursor.Text = "Отображать курсор";
            this.checkBox_drawCursor.UseVisualStyleBackColor = true;
            this.checkBox_drawCursor.CheckedChanged += new System.EventHandler(this.checkBox_drawCursor_CheckedChanged);
            // 
            // checkBox_MarkCursor
            // 
            this.checkBox_MarkCursor.AutoSize = true;
            this.checkBox_MarkCursor.Location = new System.Drawing.Point(14, 53);
            this.checkBox_MarkCursor.Name = "checkBox_MarkCursor";
            this.checkBox_MarkCursor.Size = new System.Drawing.Size(141, 20);
            this.checkBox_MarkCursor.TabIndex = 9;
            this.checkBox_MarkCursor.Text = "Выделять курсор";
            this.checkBox_MarkCursor.UseVisualStyleBackColor = true;
            this.checkBox_MarkCursor.CheckedChanged += new System.EventHandler(this.checkBox_MarkCursor_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_drawCursor);
            this.groupBox1.Controls.Add(this.numericUpDown_MarkCursorSize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBox_MarkCursor);
            this.groupBox1.Location = new System.Drawing.Point(8, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 112);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Курсор";
            // 
            // button_openWebcamSettings
            // 
            this.button_openWebcamSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_openWebcamSettings.Location = new System.Drawing.Point(645, 150);
            this.button_openWebcamSettings.Name = "button_openWebcamSettings";
            this.button_openWebcamSettings.Size = new System.Drawing.Size(188, 28);
            this.button_openWebcamSettings.TabIndex = 11;
            this.button_openWebcamSettings.Text = "Настройки веб-камеры";
            this.button_openWebcamSettings.UseVisualStyleBackColor = true;
            this.button_openWebcamSettings.Click += new System.EventHandler(this.button_openWebcamSettings_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_usingMic);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_MicDevIndex);
            this.groupBox2.Location = new System.Drawing.Point(376, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 112);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Микрофон";
            // 
            // checkBox_usingMic
            // 
            this.checkBox_usingMic.AutoSize = true;
            this.checkBox_usingMic.Location = new System.Drawing.Point(13, 77);
            this.checkBox_usingMic.Name = "checkBox_usingMic";
            this.checkBox_usingMic.Size = new System.Drawing.Size(206, 20);
            this.checkBox_usingMic.TabIndex = 18;
            this.checkBox_usingMic.Text = "Запись звука с микрофона";
            this.checkBox_usingMic.UseVisualStyleBackColor = true;
            this.checkBox_usingMic.CheckedChanged += new System.EventHandler(this.checkBox_usingMic_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Устройство микрофона";
            // 
            // comboBox_MicDevIndex
            // 
            this.comboBox_MicDevIndex.FormattingEnabled = true;
            this.comboBox_MicDevIndex.Location = new System.Drawing.Point(178, 26);
            this.comboBox_MicDevIndex.Name = "comboBox_MicDevIndex";
            this.comboBox_MicDevIndex.Size = new System.Drawing.Size(344, 24);
            this.comboBox_MicDevIndex.TabIndex = 0;
            this.comboBox_MicDevIndex.SelectedIndexChanged += new System.EventHandler(this.comboBox_MicDevIndex_SelectedIndexChanged);
            // 
            // checkBox_isBuildVideoAndAudio
            // 
            this.checkBox_isBuildVideoAndAudio.AutoSize = true;
            this.checkBox_isBuildVideoAndAudio.Location = new System.Drawing.Point(9, 155);
            this.checkBox_isBuildVideoAndAudio.Name = "checkBox_isBuildVideoAndAudio";
            this.checkBox_isBuildVideoAndAudio.Size = new System.Drawing.Size(206, 20);
            this.checkBox_isBuildVideoAndAudio.TabIndex = 17;
            this.checkBox_isBuildVideoAndAudio.Text = "Сохранить аудио отдельно";
            this.checkBox_isBuildVideoAndAudio.UseVisualStyleBackColor = true;
            this.checkBox_isBuildVideoAndAudio.CheckedChanged += new System.EventHandler(this.checkBox_isBuildVideoAndAudio_CheckedChanged);
            // 
            // checkBox_isRecordSound
            // 
            this.checkBox_isRecordSound.AutoSize = true;
            this.checkBox_isRecordSound.Location = new System.Drawing.Point(237, 155);
            this.checkBox_isRecordSound.Name = "checkBox_isRecordSound";
            this.checkBox_isRecordSound.Size = new System.Drawing.Size(197, 20);
            this.checkBox_isRecordSound.TabIndex = 16;
            this.checkBox_isRecordSound.Text = "Запись системного звука";
            this.checkBox_isRecordSound.UseVisualStyleBackColor = true;
            this.checkBox_isRecordSound.CheckedChanged += new System.EventHandler(this.checkBox_isRecordSound_CheckedChanged);
            // 
            // checkBox_view_TopWindows
            // 
            this.checkBox_view_TopWindows.AutoSize = true;
            this.checkBox_view_TopWindows.Location = new System.Drawing.Point(9, 183);
            this.checkBox_view_TopWindows.Name = "checkBox_view_TopWindows";
            this.checkBox_view_TopWindows.Size = new System.Drawing.Size(221, 20);
            this.checkBox_view_TopWindows.TabIndex = 18;
            this.checkBox_view_TopWindows.Text = "Программа по верх всех окон";
            this.checkBox_view_TopWindows.UseVisualStyleBackColor = true;
            this.checkBox_view_TopWindows.CheckedChanged += new System.EventHandler(this.checkBox_view_TopWindows_CheckedChanged);
            // 
            // checkBox_viewIconOnTaskBar
            // 
            this.checkBox_viewIconOnTaskBar.AutoSize = true;
            this.checkBox_viewIconOnTaskBar.Location = new System.Drawing.Point(237, 183);
            this.checkBox_viewIconOnTaskBar.Name = "checkBox_viewIconOnTaskBar";
            this.checkBox_viewIconOnTaskBar.Size = new System.Drawing.Size(460, 20);
            this.checkBox_viewIconOnTaskBar.TabIndex = 19;
            this.checkBox_viewIconOnTaskBar.Text = "Отображать значок программы на панели задач во время записи";
            this.checkBox_viewIconOnTaskBar.UseVisualStyleBackColor = true;
            this.checkBox_viewIconOnTaskBar.CheckedChanged += new System.EventHandler(this.checkBox_viewIconOnTaskBar_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 213);
            this.Controls.Add(this.checkBox_viewIconOnTaskBar);
            this.Controls.Add(this.checkBox_view_TopWindows);
            this.Controls.Add(this.checkBox_isBuildVideoAndAudio);
            this.Controls.Add(this.checkBox_isRecordSound);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_openWebcamSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_bitRate);
            this.Controls.Add(this.textBox_StandartPathSaveFastScreenshot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_viewStandartPathSaveFastScreenshot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VSC - Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bitRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MarkCursorSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_viewStandartPathSaveFastScreenshot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_StandartPathSaveFastScreenshot;
        private System.Windows.Forms.NumericUpDown numericUpDown_bitRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_MarkCursorSize;
        private System.Windows.Forms.CheckBox checkBox_drawCursor;
        private System.Windows.Forms.CheckBox checkBox_MarkCursor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_openWebcamSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_MicDevIndex;
        private System.Windows.Forms.CheckBox checkBox_usingMic;
        private System.Windows.Forms.CheckBox checkBox_isBuildVideoAndAudio;
        private System.Windows.Forms.CheckBox checkBox_isRecordSound;
        private System.Windows.Forms.CheckBox checkBox_view_TopWindows;
        private System.Windows.Forms.CheckBox checkBox_viewIconOnTaskBar;
    }
}