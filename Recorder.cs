using Accord.Video.FFMPEG;
using NAudio.Wave;
using System;
using System.Diagnostics;
using NAudio;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;

namespace Video_Screen_Capture
{
    internal class Recorder
    {
        private Bitmap bmp;
        private Graphics gr;
        private VideoFileWriter writer = new VideoFileWriter();
        private int min = 0, sec = 0, hour = 0;
        private System.Windows.Forms.Timer timerFrame, timerTime;
        private bool isRecord = false;
        private bool isNotBuildVideoAndAudio = false;
        private Bitmap crpBMP;
        private Icon cursor = Icon.FromHandle(Cursor.Current.Handle);
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice FinalFrame;
        private WaveIn waveIn_micRec;
        private WaveFileWriter writer_micRec;

        private Stopwatch stopwatch_audio;
        private string _outputFileNameAudio;
        private string _outputFileNameMic;
        private WasapiLoopbackCapture captureAudio;


        private int _bitRate = 1000000;
        private string _fileName = "video.avi";
        private Size sizeScreenRec = Screen.PrimaryScreen.WorkingArea.Size;
        private Point startPos = new Point(0, 0);
        private Point finishPos = (Point)Screen.PrimaryScreen.WorkingArea.Size;
        private Image webcamImage;
        //audio
        public bool isWriteAudio = true;
        //cursor
        public bool isDrawCursor = true;
        public bool isMarkCursor = false;
        public int markCursorSize = 40;
        //webcam
        public bool isUsingWebcam = false;
        public int WebcamDevIndex = 0;
        public Size sizeWebcamIcon = new Size(300, 200);
        public Point positionWebcamIcon = new Point(10, 10);
        //mic
        public bool isUsingMic = false;
        public int micDevIndex = 0;


        public Bitmap BitmapNow { get { return bmp; } }
        public int BitRate { get { return _bitRate; } set { if (!isRecord) _bitRate = value; } }
        public string FileName { get { return _fileName; } }
        public int Min { get { return min; } }
        public int Hour { get { return hour; } }
        public int Sec { get { return sec; } }
        public bool IsNotBuildVideoAndAudio { get { return isNotBuildVideoAndAudio; } set { if (!isRecord) isNotBuildVideoAndAudio = value; } }


        public Recorder()
        {
            #region Video
            timerFrame = new System.Windows.Forms.Timer();
            timerTime = new System.Windows.Forms.Timer();

            timerFrame.Tick += timerFrame_tick;
            timerTime.Tick += timerTime_tick;

            timerTime.Interval = 1000;
            timerFrame.Interval = 20;
            #endregion  

            stopwatch_audio = new Stopwatch();
            captureAudio = new WasapiLoopbackCapture();

        }

        public void Dispose()
        {
            if(isRecord)this.Stop();
            timerFrame.Dispose();
            timerTime.Dispose();        
        }

        public void Start(string _fileName, Point _startPos, Point _finishPos)
        {
            _outputFileNameAudio = _fileName + ".wav";
            _outputFileNameMic = _fileName + "_mic.wav";
            this._fileName = _fileName;

            #region Video
            startPos = _startPos;
            finishPos = _finishPos;
            if (startPos.X % 2 == 1) startPos.X++;
            if (finishPos.X % 2 == 1) finishPos.X++;
            if (startPos.Y % 2 == 1) startPos.Y++;
            if (finishPos.Y % 2 == 1) finishPos.Y++;
            sizeScreenRec = new Size(Math.Abs(startPos.X - finishPos.X), Math.Abs(startPos.Y - finishPos.Y));

            cursor = Icon.FromHandle(Cursor.Current.Handle);
            bmp = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            gr = Graphics.FromImage(bmp);
            writer.Open(_fileName, sizeScreenRec.Width, sizeScreenRec.Height, 30, VideoCodec.MPEG4, _bitRate);
            timerFrame.Start();
            timerTime.Start();
            min = 0; sec = 0; hour = 0;
            isRecord = true;
            Console.WriteLine($"StartRecord:\nsP:{startPos}\nfP:{finishPos}\nbitRate:{_bitRate}\nsize:{sizeScreenRec}");
            #endregion

            #region Audio
            if (isWriteAudio)
            {
                var writer_a = new WaveFileWriter(_outputFileNameAudio, captureAudio.WaveFormat);

                captureAudio.DataAvailable += async (s, t) =>
                {
                    if (writer != null)
                    {
                        await writer_a.WriteAsync(t.Buffer, 0, t.BytesRecorded);
                        await writer_a.FlushAsync();
                    }
                };

                captureAudio.RecordingStopped += (s, t) =>
                {
                    if (writer_a != null)
                    {
                        writer_a.Dispose();
                        writer_a = null;
                    }

                    captureAudio.Dispose();
                };

                captureAudio.StartRecording();
                stopwatch_audio.Start();
            }
            #endregion

            #region WebCam Video
            if (isUsingWebcam)
            {
                CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                try
                {
                    FinalFrame = new VideoCaptureDevice(CaptureDevices[WebcamDevIndex].MonikerString);
                }
                catch (System.ArgumentOutOfRangeException) 
                { 
                    FinalFrame = new VideoCaptureDevice(CaptureDevices[0].MonikerString); 
                }
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
                FinalFrame.Start();
                webcamImage = new Bitmap((Image)Properties.Resources.getAreaBG_1, sizeWebcamIcon);
            }
            #endregion

            #region Miv Audio
            if (isUsingMic)
            {
                waveIn_micRec = new WaveIn();
                waveIn_micRec.DeviceNumber = micDevIndex;
                waveIn_micRec.DataAvailable += waveIn_DataAvailable;
                waveIn_micRec.WaveFormat = new WaveFormat(44100, 2);
                writer_micRec = new WaveFileWriter(_outputFileNameMic, waveIn_micRec.WaveFormat);
                waveIn_micRec.StartRecording();
            }
            #endregion

            if(File.Exists("ss.wav"))
                using (var soundPlayer = new SoundPlayer(@"ss.wav"))
                {
                    soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                }
        }

        public void Stop()
        {
            timerTime.Stop();

            #region Video
            writer.Close();
            isRecord = false;
            timerFrame.Stop();
            #endregion

            #region Audio
            if (isWriteAudio)
            {
                captureAudio.StopRecording();
                stopwatch_audio.Stop();
                stopwatch_audio.Reset();
            }
            #endregion

            WaitBuildForm wf = new WaitBuildForm();
            wf.Show();
            wf.Update();
            #region Mic Audio
            if (isUsingMic && !isNotBuildVideoAndAudio)
            {
                waveIn_micRec.StopRecording();
                waveIn_micRec.Dispose();
                waveIn_micRec = null;
                writer_micRec.Close();
                writer_micRec = null;

                if (File.Exists(_fileName + ".mp4")) File.Delete(_fileName + ".mp4");

                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    CreateNoWindow = true,
                    FileName = @"bin\ffmpeg.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    //Arguments = string.Format(" -i {0} -i {1} -shortest {2} -y", @"video.avi", @"video.avi.wav", @"result.avi")
                    Arguments = $" -i {_fileName} -i {_outputFileNameMic} -c:v copy -map 0:v:0 -map 1:a:0 -c:a aac -b:a 192k {_fileName + ".mp4"}"
                };

                using (Process exeProcess = Process.Start(startInfo))
                {
                    Console.WriteLine("Start build mic");
                    //debug
                    string StdOutVideo = exeProcess.StandardOutput.ReadToEnd();
                    string StdErrVideo = exeProcess.StandardError.ReadToEnd();
                    //

                    exeProcess.WaitForExit();
                    exeProcess.Close();
                    Thread.Sleep(1000);
                    //exeProcess.Kill();
                    Console.WriteLine("end build mic");
                }

            }
            #endregion


            if (!isNotBuildVideoAndAudio && isWriteAudio && !isUsingMic)
            {
                if (File.Exists(_fileName + ".mp4") && !isUsingMic) File.Delete(_fileName + ".mp4");
                string arg = "";
                if (isUsingMic) arg = $" -i {_fileName + ".mp4"} -i {_outputFileNameAudio} -map 0 -map 1:a -c:v copy -shortest {_fileName + "_.mp4"}";
                else arg = $" -i {_fileName} -i {_outputFileNameAudio} -c:v copy -map 0:v:0 -map 1:a:0 -c:a aac -b:a 192k {_fileName + ".mp4"}";


                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    CreateNoWindow = true,
                    FileName = @"bin\ffmpeg.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    //Arguments = $" -i {_fileName} -i {_outputFileNameAudio} -c:v copy -map 0:v:0 -map 1:a:0 -c:a aac -b:a 192k {_fileName + ".mp4"}"
                    Arguments = arg
                };

                using (Process exeProcess = Process.Start(startInfo))
                {
                    Console.WriteLine("Start build");
                    //debug
                    string StdOutVideo = exeProcess.StandardOutput.ReadToEnd();
                    string StdErrVideo = exeProcess.StandardError.ReadToEnd();
                    //

                    exeProcess.WaitForExit();
                    exeProcess.Close();
                    Thread.Sleep(1000);
                    //exeProcess.Kill();
                    Console.WriteLine("end build");
                }

            }

            if(FinalFrame != null)
                if(FinalFrame.IsRunning)
                    FinalFrame.Stop();

            //if (File.Exists(_fileName + ".mp4") && isUsingMic) File.Delete(_fileName + ".mp4");
            if (File.Exists(_fileName) && (isUsingMic || isWriteAudio)) File.Delete(_fileName);

            for(int i = 0; i < 100; i++)
            {
                wf.progressBar.Value = i;
                wf.Update();
                Thread.Sleep(10);
            }
            wf.Close();
            Console.WriteLine(Path.GetDirectoryName(_fileName));
        } 

        public void Pause()
        {
            if (isWriteAudio) return;
            if (!isRecord) return;
            isRecord = false;
            timerFrame.Enabled = false;
            timerTime.Enabled = false;
        }

        public void Play()
        {
            if (isWriteAudio) return;
            if (isRecord) return;
            isRecord = true;
            timerFrame.Enabled = true;
            timerTime.Enabled = true;      
        }

        public Bitmap ScreenShot()
        {
            bmp = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(0, 0, 0, 0, new System.Drawing.Size(bmp.Width, bmp.Height));
            gr.Dispose();
            return bmp;
        }

        public Image GetImageScreen()
        {
            gr.CopyFromScreen(0, 0, 0, 0, new System.Drawing.Size(bmp.Width, bmp.Height));

            if (sizeScreenRec != Screen.PrimaryScreen.WorkingArea.Size)
                crpBMP = bmp.Clone(new Rectangle(startPos, sizeScreenRec), bmp.PixelFormat);

            return crpBMP;
        }

        private void timerFrame_tick(object sender, EventArgs e)
        {
            gr.CopyFromScreen(0, 0, 0, 0, new System.Drawing.Size(bmp.Width, bmp.Height));

            if (isDrawCursor) {
                gr.DrawIcon(cursor, Cursor.Position.X, Cursor.Position.Y);

                if (isMarkCursor)
                {
                    Pen pen = new Pen(Color.Red);
                    gr.DrawEllipse(pen, Cursor.Position.X, Cursor.Position.Y, markCursorSize, markCursorSize);
                }
            }

            crpBMP = bmp.Clone(new Rectangle(startPos, sizeScreenRec), bmp.PixelFormat);

            if (isUsingWebcam)
            {
                var gr_ = Graphics.FromImage(crpBMP);
                gr_.DrawImage(webcamImage, positionWebcamIcon);
                gr_.Dispose();
            }

            
            
            writer.WriteVideoFrame(crpBMP);
            crpBMP.Dispose();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Получаем изображение с веб-камеры
            Image image = (Bitmap)eventArgs.Frame.Clone();

            // Определяем размер PictureBox
            int pictureBoxWidth = sizeWebcamIcon.Width;
            int pictureBoxHeight = sizeWebcamIcon.Height;

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
            webcamImage = image;
        }

        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer_micRec.WriteData(e.Buffer, 0, e.BytesRecorded);
        }


        private void timerTime_tick(object sender, EventArgs e)
        {
            sec++;
            if (sec > 59) { min++; sec = 0; }
            if (min > 59) { hour++; min = 0; }
        }
    }
}
