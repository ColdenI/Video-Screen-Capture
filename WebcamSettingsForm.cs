using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Video_Screen_Capture
{
    public partial class WebcamSettingsForm : Form
    {
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice FinalFrame;
        private Bitmap bmp;
        private Graphics gr;


        public WebcamSettingsForm()
        {
            InitializeComponent();
        }

        private void WebcamSettingsForm_Load(object sender, EventArgs e)
        {
            checkBox_usingWebcam.Checked = Properties.Settings.Default.isUsingWebcam;
            numericUpDown_posX.Value = (decimal)Properties.Settings.Default.Webcam_position_X;
            numericUpDown_posY.Value = (decimal)Properties.Settings.Default.Webcam_position_Y;
            numericUpDown_sizeX.Value = (decimal)Properties.Settings.Default.Webcam_size_X;
            numericUpDown_sizeY.Value = (decimal)Properties.Settings.Default.Webcam_size_Y;
            
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            comboBox_webcmDev.Items.Clear();
            foreach(FilterInfo d in CaptureDevices)
            {
                comboBox_webcmDev.Items.Add(d.Name);
            }
            try
            {
                comboBox_webcmDev.SelectedIndex = Properties.Settings.Default.Webcam_deviseIndex;
            }catch(Exception ex) { comboBox_webcmDev.SelectedIndex = 0; }

            bmp = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            gr = Graphics.FromImage(bmp);
            UpdateWeb();
            Console.WriteLine(Properties.Settings.Default.Webcam_position_Y);
        }

        private void UpdateWeb()
        {
            if(FinalFrame != null)
                if(FinalFrame.IsRunning)
                    FinalFrame.Stop();

            FinalFrame = new VideoCaptureDevice(CaptureDevices[comboBox_webcmDev.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Получаем изображение с веб-камеры
            Image image = (Bitmap)eventArgs.Frame.Clone();

            // Определяем размер PictureBox
            int pictureBoxWidth = (int)numericUpDown_sizeX.Value;
            int pictureBoxHeight = (int)numericUpDown_sizeY.Value;

            // Определяем размер полученного изображения
            int imageWidth = image.Width;
            int imageHeight = image.Height;

            // Масштабируем изображение, если оно не помещается в PictureBox
            if (imageWidth > pictureBoxWidth || imageHeight > pictureBoxHeight)
            {
                float aspectRatio = Math.Min((float)pictureBoxWidth / imageWidth, (float)pictureBoxHeight / imageHeight);
                int newWidth = (int)(imageWidth * aspectRatio);
                int newHeight = (int)(imageHeight * aspectRatio);
                Image scaledImage = image.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
                image.Dispose();
                image = scaledImage;
            }

            // Отображаем изображение на PictureBox
            gr.CopyFromScreen(0, 0, 0, 0, new System.Drawing.Size(bmp.Width, bmp.Height));
            gr.DrawImage(image, (int)numericUpDown_posX.Value, (int)numericUpDown_posY.Value);
            pictureBox.Image = bmp;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Dispose();
        }

        private void WebcamSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame != null)
                if (FinalFrame.IsRunning)
                    FinalFrame.Stop();

            pictureBox.Dispose();
            gr.Dispose();
            bmp.Dispose();
            this.Dispose();
        }

        private void comboBox_webcmDev_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWeb();
            Properties.Settings.Default.Webcam_deviseIndex = comboBox_webcmDev.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void numericUpDown_posX_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Webcam_position_X = (int)numericUpDown_posX.Value;
            Properties.Settings.Default.Save();            
        }

        private void numericUpDown_sizeX_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Webcam_size_X = (int)numericUpDown_sizeX.Value;
            Properties.Settings.Default.Save();
        }
        
        private void numericUpDown_posY_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Webcam_position_Y = (int)numericUpDown_posY.Value;
            Properties.Settings.Default.Save();            
        }

        private void numericUpDown_sizeY_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Webcam_size_Y = (int)numericUpDown_sizeY.Value;
            Properties.Settings.Default.Save();
        }

        private void checkBox_usingWebcam_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isUsingWebcam = checkBox_usingWebcam.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
