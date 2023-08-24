using Accord.Video.FFMPEG;
using NAudio.Wave;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

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

        private Stopwatch stopwatch_audio;
        private string _outputFileNameAudio;
        private WasapiLoopbackCapture captureAudio;


        private int _bitRate = 1000000;
        private string _fileName = "video.avi";
        private Size sizeScreenRec = Screen.PrimaryScreen.WorkingArea.Size;
        private Point startPos = new Point(0, 0);
        private Point finishPos = (Point)Screen.PrimaryScreen.WorkingArea.Size;
        public bool isWriteAudio = true;
        public bool isDrawCursor = true;
        public bool isMarkCursor = false;
        public int markCursorSize = 40;

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
        }

        public void Stop()
        {
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

            timerTime.Stop();

            if (!isNotBuildVideoAndAudio && isWriteAudio)
            {
                if (File.Exists(_fileName + ".mp4")) File.Delete(_fileName + ".mp4");

                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    CreateNoWindow = true,
                    FileName = @"bin\ffmpeg.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    //Arguments = string.Format(" -i {0} -i {1} -shortest {2} -y", @"video.avi", @"video.avi.wav", @"result.avi")
                    Arguments = $" -i {_fileName} -i {_outputFileNameAudio} -c:v copy -map 0:v:0 -map 1:a:0 -c:a aac -b:a 192k {_fileName + ".mp4"}"
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

                if (File.Exists(_fileName)) File.Delete(_fileName);
                //if (isWriteAudio && File.Exists(_outputFileNameAudio)) File.Delete(_outputFileNameAudio);
                //Console.WriteLine(Path.GetDirectoryName(_fileName));
            }

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
            
            writer.WriteVideoFrame(crpBMP);
            crpBMP.Dispose();
        }
        
        private void timerTime_tick(object sender, EventArgs e)
        {
            sec++;
            if (sec > 59) { min++; sec = 0; }
            if (min > 59) { hour++; min = 0; }
        }
    }
}
