using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShallowAnatomy
{
    public partial class Form1 : Form
    {
        private bool _isStart;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var g = chart1.CreateGraphics();
            Point p = new Point(10, 10);
            g.FillEllipse(Brushes.Black, p.X, p.Y, 10, 10);
        }

        private void ShowSettingWindow(object sender, EventArgs e)
        {
            SettingWindows settingWindows = new SettingWindows();
            settingWindows.ShowDialog();
        }
    }
}
