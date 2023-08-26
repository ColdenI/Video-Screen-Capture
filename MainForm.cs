using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Video_Screen_Capture
{
    public partial class MainForm : Form
    {
        private Recorder recorder;
        public Point sPos, fPos;

        public MainForm()
        {
            InitializeComponent();
            recorder = new Recorder();

            button_startRecord.Enabled = true;
            button_stopRecord.Enabled = false;
            button_pauseRecord.Enabled = false;
            button_playRecord.Enabled = false;
            button_openSettings.Enabled = true;

            button_fastScreenshot.Enabled = true;
            button_screenshot.Enabled = true;
            button_s_fastScreenshot.Enabled = true;

            button_s_start.Enabled = true;
            button_s_stop.Enabled = false;
            button_s_pause.Enabled = false;
            button_s_play.Enabled = false;
            
            checkBox_isBuildVideoAndAudio.Enabled = true;
            checkBox_isRecordSound.Enabled = true;
            checkBox_usingMic.Enabled = true;
            checkBox_usingWebcam.Enabled = true;

            checkBox_isBuildVideoAndAudio.Checked = Properties.Settings.Default.isNotBuildVideoAndAudio;
            checkBox_isRecordSound.Checked = Properties.Settings.Default.isWriteSysSound;
            checkBox_usingMic.Checked = Properties.Settings.Default.isUsingMic;
            checkBox_usingWebcam.Checked = Properties.Settings.Default.isUsingWebcam;

            if (Properties.Settings.Default.isView_TopWindows) this.TopMost = true; else this.TopMost = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            recorder.Dispose();
            System.Windows.Forms.Application.Exit();
        }

 
        
        private void button_startRecord_Click(object sender, EventArgs e)
        {
            sPos = new Point(-1000, -1000);
            fPos = sPos;
            var form = new GetAreaForm();
            form.Owner = this;
            form.ShowDialog();
            if (fPos == new Point(-1000, -1000) || sPos == new Point(-1000, -1000)) return;
            //Console.WriteLine($"{sPos}  {fPos}");
            SaveFileDialog save_file = new SaveFileDialog();
            if(save_file.ShowDialog() == DialogResult.Cancel) return;
           
            timer1.Start();
            recorder.IsNotBuildVideoAndAudio = checkBox_isBuildVideoAndAudio.Checked;
            recorder.isWriteAudio = checkBox_isRecordSound.Checked;
            recorder.isDrawCursor = Properties.Settings.Default.isDrawCursor;
            recorder.isMarkCursor = Properties.Settings.Default.isMarkCursor;
            recorder.markCursorSize = Properties.Settings.Default.markCursorSize;
            recorder.BitRate = Properties.Settings.Default.BitRate;
            recorder.isUsingWebcam = Properties.Settings.Default.isUsingWebcam;
            recorder.WebcamDevIndex = Properties.Settings.Default.Webcam_deviseIndex;
            recorder.positionWebcamIcon = new Point(Properties.Settings.Default.Webcam_position_X, Properties.Settings.Default.Webcam_position_Y);
            recorder.sizeWebcamIcon = new Size(Properties.Settings.Default.Webcam_size_X, Properties.Settings.Default.Webcam_size_Y);
            recorder.isUsingMic = Properties.Settings.Default.isUsingMic;
            recorder.micDevIndex = Properties.Settings.Default.Mic_deviseIndex;

            recorder.Start(save_file.FileName + ".avi", sPos, fPos);
            //recorder.Start("video.avi", new Point(300, 100), (Point)Screen.PrimaryScreen.WorkingArea.Size);

            button_startRecord.Enabled = false;
            button_playRecord.Enabled = false;
            button_stopRecord.Enabled = true;
            button_pauseRecord.Enabled = true;
            button_openSettings.Enabled = false;

            button_s_pause.Enabled = true;
            button_s_play.Enabled = false;
            button_s_stop.Enabled = true;
            button_s_start.Enabled = false;

            button_fastScreenshot.Enabled = false;
            button_screenshot.Enabled = false;
            button_s_fastScreenshot.Enabled = false;

            checkBox_isBuildVideoAndAudio.Enabled = false;
            checkBox_isRecordSound.Enabled = false;
            checkBox_usingMic.Enabled = false;
            checkBox_usingWebcam.Enabled = false;

            if (!Properties.Settings.Default.isViewIconOnTaskBar) this.ShowInTaskbar = false;           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_timer.Text = $"{ParseStringTime(recorder.Hour)}:{ParseStringTime(recorder.Min)}:{ParseStringTime(recorder.Sec)}";
            if(recorder.Min >= 5 && (recorder.isWriteAudio || recorder.isUsingMic))
            {
                button_stopRecord_Click(sender, e);
            }
        }

        private void button_stopRecord_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            recorder.Stop();
            
            button_playRecord.Enabled = false;
            button_stopRecord.Enabled = false;
            button_pauseRecord.Enabled = false;
            button_startRecord.Enabled = true;
            button_openSettings.Enabled = true;

            button_s_pause.Enabled = false;
            button_s_play.Enabled = false;
            button_s_stop.Enabled = false;
            button_s_start.Enabled = true;

            button_fastScreenshot.Enabled = true;
            button_screenshot.Enabled = true;
            button_s_fastScreenshot.Enabled = true;

            checkBox_isBuildVideoAndAudio.Enabled = true;
            checkBox_isRecordSound.Enabled = true;
            checkBox_usingMic.Enabled = true;
            checkBox_usingWebcam.Enabled = true;

            this.ShowInTaskbar = true;
        }

        public static string ParseStringTime(int num)
        {
            if (num > 9) return num.ToString();
            return "0" + num.ToString();
        }

        private void button_screenshot_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Thread.Sleep(200);
            var im = recorder.ScreenShot();
            Thread.Sleep(200);
            this.Visible = true;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG |.png";
            if(saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            im.Save(saveFileDialog.FileName);
            if (File.Exists(saveFileDialog.FileName)) Process.Start(saveFileDialog.FileName);
            im.Dispose();
        }

        private void button_pauseRecord_Click(object sender, EventArgs e)
        {
            if (recorder.isWriteAudio || recorder.isUsingMic) return;
            recorder.Pause();

            button_playRecord.Enabled = true; 
            button_pauseRecord.Enabled = false;

            button_s_play.Enabled = true;
            button_s_pause.Enabled = false;
        }

        private void button_playRecord_Click(object sender, EventArgs e)
        {
            if (recorder.isWriteAudio || recorder.isUsingMic) return;
            recorder.Play();

            button_playRecord.Enabled = false;
            button_pauseRecord.Enabled = true;

            button_s_play.Enabled = false;
            button_s_pause.Enabled = true;
        }

        private void checkBox_isRecordSound_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isWriteSysSound = checkBox_isRecordSound.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_isBuildVideoAndAudio_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isNotBuildVideoAndAudio = checkBox_isBuildVideoAndAudio.Checked;
            Properties.Settings.Default.Save();
        }

        private void button_openSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();

            checkBox_isBuildVideoAndAudio.Checked = Properties.Settings.Default.isNotBuildVideoAndAudio;
            checkBox_isRecordSound.Checked = Properties.Settings.Default.isWriteSysSound;
            checkBox_usingMic.Checked = Properties.Settings.Default.isUsingMic;
            checkBox_usingWebcam.Checked = Properties.Settings.Default.isUsingWebcam;
            if (Properties.Settings.Default.isView_TopWindows) this.TopMost = true; else this.TopMost = false;
        }

        private void checkBox_usingMic_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isUsingMic = checkBox_usingMic.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_usingWebcam_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isUsingWebcam = checkBox_usingWebcam.Checked;
            Properties.Settings.Default.Save();
        }

        private void button_fastScreenshot_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Thread.Sleep(200);
            var im = recorder.ScreenShot();
            Thread.Sleep(200);
            this.Visible = true;

            if (!Directory.Exists(Properties.Settings.Default.standartPathSaveFastScreenshot))
            {
                if (MessageBox.Show("Не удалось найти путь для сохранения! Сохранить снимок экрана и запомнить путь?", "Ой...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG |.png";
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
                im.Save(saveFileDialog.FileName);
                //if (File.Exists(saveFileDialog.FileName)) Process.Start(saveFileDialog.FileName);
                Properties.Settings.Default.standartPathSaveFastScreenshot = Path.GetDirectoryName(saveFileDialog.FileName);
                Properties.Settings.Default.Save();
            }
            else im.Save($"{Properties.Settings.Default.standartPathSaveFastScreenshot}\\{DateTime.Now.ToString().Replace(":", "-")}.png");
            im.Dispose();
        }

        private void button_smalModeWindow_Click(object sender, EventArgs e)
        {
            panel_sm.Visible = true;
            this.Size = new System.Drawing.Size(262, 120);
            if (Properties.Settings.Default.isView_TopWindows) this.TopMost = true;
        }

        private void button_bigWindow_Click(object sender, EventArgs e)
        {
            panel_sm.Visible = false;
            this.Size = new System.Drawing.Size(275, 433);
            if(Properties.Settings.Default.isView_TopWindows) this.TopMost = false;           
        }

        private void button_s_start_EnabledChanged(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Enabled) ((PictureBox)sender).Image = Properties.Resources.butt_startRec;
            else ((PictureBox)sender).Image = Properties.Resources.butt_startRec_ef;
        }

        private void button_s_stop_EnabledChanged(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Enabled) ((PictureBox)sender).Image = Properties.Resources.butt_stopRec;
            else ((PictureBox)sender).Image = Properties.Resources.butt_stopRec_ef;
        }

        private void button_s_play_EnabledChanged(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Enabled) ((PictureBox)sender).Image = Properties.Resources.butt_playRec;
            else ((PictureBox)sender).Image = Properties.Resources.butt_playRec_ef;
        }

        private void button_s_pause_EnabledChanged(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Enabled) ((PictureBox)sender).Image = Properties.Resources.butt_pauseRec;
            else ((PictureBox)sender).Image = Properties.Resources.butt_pauseRec_ef;
        }

        private void button_s_fastScreenshot_EnabledChanged(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Enabled) ((PictureBox)sender).Image = Properties.Resources.butt_screenshot;
            else ((PictureBox)sender).Image = Properties.Resources.butt_screenshot_ef;
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        public static DialogResult DialogBox(string title, string promptText, ref string value, string button1 = "OK", string button2 = "Cancel", string button3 = null)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button button_1 = new Button();
            Button button_2 = new Button();
            Button button_3 = new Button();

            int buttonStartPos = 228; //Standard two button position


            if (button3 != null)
                buttonStartPos = 228 - 81;
            else
            {
                button_3.Visible = false;
                button_3.Enabled = false;
            }


            form.Text = title;

            // Label
            label.Text = promptText;
            label.SetBounds(9, 20, 372, 13);
            label.Font = new Font("Microsoft Tai Le", 10, FontStyle.Regular);

            // TextBox
            if (value == null)
            {
            }
            else
            {
                textBox.Text = value;
                textBox.SetBounds(12, 36, 372, 20);
                textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            }

            button_1.Text = button1;
            button_2.Text = button2;
            button_3.Text = button3 ?? string.Empty;
            button_1.DialogResult = DialogResult.OK;
            button_2.DialogResult = DialogResult.Cancel;
            button_3.DialogResult = DialogResult.Yes;


            button_1.SetBounds(buttonStartPos, 72, 75, 23);
            button_2.SetBounds(buttonStartPos + 81, 72, 75, 23);
            button_3.SetBounds(buttonStartPos + (2 * 81), 72, 75, 23);

            label.AutoSize = true;
            button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, button_1, button_2 });
            if (button3 != null)
                form.Controls.Add(button_3);
            if (value != null)
                form.Controls.Add(textBox);

            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = button_1;
            form.CancelButton = button_2;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
