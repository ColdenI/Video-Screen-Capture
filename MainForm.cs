using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

            checkBox_isBuildVideoAndAudio.Checked = Properties.Settings.Default.isNotBuildVideoAndAudio;
            checkBox_isRecordSound.Checked = Properties.Settings.Default.isWriteSysSound;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            recorder.Dispose();
            System.Windows.Forms.Application.Exit();
        }

 
        
        private void button1_Click(object sender, EventArgs e)
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
            recorder.Start(save_file.FileName + ".avi", sPos, fPos);
            //recorder.Start("video.avi", new Point(300, 100), (Point)Screen.PrimaryScreen.WorkingArea.Size);

            button_startRecord.Enabled = false;
            button_playRecord.Enabled = false;
            button_stopRecord.Enabled = true;
            button_pauseRecord.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_timer.Text = $"{ParseStringTime(recorder.Sec)}:{ParseStringTime(recorder.Min)}:{ParseStringTime(recorder.Hour)}";
        }

        private void button_stopRecord_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            recorder.Stop();
            
            button_playRecord.Enabled = false;
            button_stopRecord.Enabled = false;
            button_pauseRecord.Enabled = false;
            button_startRecord.Enabled = true;
        }

        public static string ParseStringTime(int num)
        {
            if (num > 9) return num.ToString();
            return "0" + num.ToString();
        }

        private void button_screenshot_Click(object sender, EventArgs e)
        {
            var im = recorder.ScreenShot();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG |.png";
            if(saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            im.Save(saveFileDialog.FileName);
            if (File.Exists(saveFileDialog.FileName)) Process.Start(saveFileDialog.FileName);
        }

        private void button_pauseRecord_Click(object sender, EventArgs e)
        {
            if (recorder.isWriteAudio) return;
            recorder.Pause();

            button_playRecord.Enabled = true; 
            button_pauseRecord.Enabled = false;
        }

        private void button_playRecord_Click(object sender, EventArgs e)
        {
            if (recorder.isWriteAudio) return;
            recorder.Play();

            button_playRecord.Enabled = false;
            button_pauseRecord.Enabled = true;
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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
