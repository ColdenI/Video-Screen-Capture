using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Screen_Capture
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            textBox_StandartPathSaveFastScreenshot.Text = Properties.Settings.Default.standartPathSaveFastScreenshot;

            checkBox_drawCursor.Checked = Properties.Settings.Default.isDrawCursor;
            checkBox_MarkCursor.Checked = Properties.Settings.Default.isMarkCursor;
            numericUpDown_MarkCursorSize.Value = (decimal)Properties.Settings.Default.markCursorSize;
            if (!checkBox_drawCursor.Checked)
            {
                checkBox_MarkCursor.Enabled = false;
                numericUpDown_MarkCursorSize.Enabled = false;
            }
            else
            {
                checkBox_MarkCursor.Enabled = true;
                numericUpDown_MarkCursorSize.Enabled = true;
            }

            checkBox_usingMic.Checked = Properties.Settings.Default.isUsingMic;
            UpdateListMic();
            try
            {
                comboBox_MicDevIndex.SelectedIndex = Properties.Settings.Default.Mic_deviseIndex;
            }
            catch (System.ArgumentOutOfRangeException) { comboBox_MicDevIndex.SelectedIndex = 0; }

            checkBox_isRecordSound.Checked = Properties.Settings.Default.isWriteSysSound;
            checkBox_isBuildVideoAndAudio.Checked = Properties.Settings.Default.isNotBuildVideoAndAudio;
            numericUpDown_bitRate.Value = (decimal)Properties.Settings.Default.BitRate;

            checkBox_viewIconOnTaskBar.Checked = Properties.Settings.Default.isViewIconOnTaskBar;
            checkBox_view_TopWindows.Checked = Properties.Settings.Default.isView_TopWindows;
        }

        private void UpdateListMic()
        {
            comboBox_MicDevIndex.Items.Clear();
            int waveInDevices = WaveIn.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                comboBox_MicDevIndex.Items.Add(string.Format("Device {0}: {1}, {2} channels", waveInDevice, deviceInfo.ProductName, deviceInfo.Channels));
            }
        }

        private void button_openWebcamSettings_Click(object sender, EventArgs e)
        {
            new WebcamSettingsForm().ShowDialog();
        }

        private void checkBox_drawCursor_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_drawCursor.Checked)
            {
                checkBox_MarkCursor.Enabled = false;
                numericUpDown_MarkCursorSize.Enabled = false;
                checkBox_MarkCursor.Checked = false;
            }
            else
            {
                checkBox_MarkCursor.Enabled = true;
                numericUpDown_MarkCursorSize.Enabled = true;
            }
            Properties.Settings.Default.isDrawCursor = checkBox_drawCursor.Checked;
            Properties.Settings.Default.isMarkCursor = checkBox_MarkCursor.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_MarkCursor_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isMarkCursor = checkBox_MarkCursor.Checked;
            Properties.Settings.Default.Save();
        }

        private void numericUpDown_MarkCursorSize_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.markCursorSize = (int)numericUpDown_MarkCursorSize.Value;
            Properties.Settings.Default.Save();
        }

        private void comboBox_MicDevIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Mic_deviseIndex = comboBox_MicDevIndex.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void checkBox_usingMic_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isUsingMic = checkBox_usingMic.Checked;
            Properties.Settings.Default.Save();
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

        private void button_viewStandartPathSaveFastScreenshot_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.Cancel) return;
            textBox_StandartPathSaveFastScreenshot.Text = dialog.SelectedPath;
            Properties.Settings.Default.standartPathSaveFastScreenshot = dialog.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void numericUpDown_bitRate_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BitRate = (int)numericUpDown_bitRate.Value;
            Properties.Settings.Default.Save();
        }

        private void checkBox_viewIconOnTaskBar_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isViewIconOnTaskBar = checkBox_viewIconOnTaskBar.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_view_TopWindows_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isView_TopWindows = checkBox_view_TopWindows.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
