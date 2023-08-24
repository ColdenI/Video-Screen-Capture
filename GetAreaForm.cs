using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Screen_Capture
{
    public partial class GetAreaForm : Form
    {

        private Point startPos = new Point(-100, -100), endPos = new Point(-100, -100);
        private bool flag = true;
        Image bitmap;
        Graphics graphics;

        public GetAreaForm()
        {
            InitializeComponent();
            bitmap = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height, PixelFormat.Format32bppArgb);
        }

        private void GetAreaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                MainForm mainForm = this.Owner as MainForm;
                mainForm.sPos = Point.Empty;
                mainForm.fPos = (Point)Screen.PrimaryScreen.WorkingArea.Size;
                this.Dispose();
                Close();
                return;
            }

            this.Dispose();
            Close();
        }

        private void GetAreaForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (flag)
                {
                    startPos = Cursor.Position;
                }
                else
                {
                    endPos = Cursor.Position;
                }

                flag = !flag;
            }

            if (e.Button == MouseButtons.Right)
            {
                tableLayoutPanel1.Location = Cursor.Position;
                timer2_Tick(sender, e);
            }

            if (startPos != new Point(-100, -100) && endPos != new Point(-100, -100))
            {
                if(startPos.X > endPos.X || startPos.Y > endPos.Y)
                {
                    startPos = new Point(-100, -100);
                    endPos = new Point(-100, -100);
                    MessageBox.Show("Точка окончания не может иметь координаты меньше, чем точка начала!", "Ой...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Draw(startPos.X, startPos.Y, Cursor.Position.X, Cursor.Position.Y, Color.Red);
                MainForm mainForm = this.Owner as MainForm;
                mainForm.sPos = startPos;
                mainForm.fPos = endPos;
                this.Dispose();              
                Close();
            }
        }



        private void GetAreaForm_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void GetAreaForm_MouseMove(object sender, MouseEventArgs e)
        {
            int cX = Cursor.Position.X;
            int cY = Cursor.Position.Y;

            if(startPos != new Point(-100, -100))
            Draw(startPos.X, startPos.Y, cX, cY, Color.Green);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_cursor.Text = $"{Cursor.Position.X}X{Cursor.Position.Y}";
            if(startPos == new Point(-100, -100)) label_start.Text = label_cursor.Text;
            else label_start.Text = $"{startPos.X}X{startPos.Y}";
            if (endPos == new Point(-100, -100)) label_end.Text = label_cursor.Text;
            else label_end.Text = $"{endPos.X}X{endPos.Y}";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Location = new Point(new Random().Next(0, bitmap.Width - label4.Width), new Random().Next(0, bitmap.Height - label4.Height));
        }

        public void Draw(int x, int y, int x2, int y2, Color color)
        {
            //bitmap = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format32bppArgb);
            graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.Transparent);
            graphics.FillRectangle(new SolidBrush(color), x, y, Math.Abs(x2 - x), Math.Abs(y2 - y));
            pictureBox1.Image = bitmap;
        }
    }
}
