using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Bitmap[] Frames;
        private int FrameNum = 0;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frames = new Bitmap[13];
            for (int i = 0; i<13; i++)
            {
                Frames[i] = new Bitmap("D:\\207 Лабутина Гаврилов Блинков\\PR11\\WindowsFormsApp1\\del\\Frame" + i + ".jpg");
            }
            pictureBox1.Image = Frames[FrameNum];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FrameNum = ++FrameNum % Frames.Length;
            pictureBox1.Image = Frames[FrameNum];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled) button1.Text = "Стоп";
            else button1.Text = "Старт";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }
    }
}
