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
    public partial class LoadForm : Form
    {
        private int _Progress = -120;
        private bool isTest = true;

        public LoadForm()
        {
            InitializeComponent();
            progressBar.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _Progress++;
            if(_Progress >= 0) progressBar.Visible = true;
            if (_Progress < 100 && _Progress >= 0) progressBar.Value = _Progress;
            else if (_Progress > 100) progressBar.Style = ProgressBarStyle.Marquee;
            if (_Progress > 300 || isTest)
            {
                this.Visible = false;
                progressBar.Dispose();
                new MainForm().Show();
                timer1.Dispose();
                
            }
        }
    }
}
