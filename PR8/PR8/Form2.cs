using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR8
{
    public partial class Form2 : Form
    {

        Color colorResult;


        public Form2(Color color)
        {
            InitializeComponent();


            ScrollBar_Red.Tag = numeric_red;
            ScrollBar_Blue.Tag = numeric_Blue;
            ScrollBar_Green.Tag = numeric_Green;

            numeric_red.Tag = ScrollBar_Red;
            numeric_Blue.Tag = ScrollBar_Blue;
            numeric_Green.Tag = ScrollBar_Green;

            numeric_red.Value = color.R;
            numeric_Green.Value = color.G;
            numeric_Blue.Value = color.B;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Scroll_Red_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }

        private void Scroll_Blue_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }
        private void Scroll_Green_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }

        private void numeric_red_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }
        private void numeric_Blue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }
        private void numeric_Green_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            
        }

        private void UpdateColor()
        {
            colorResult = Color.FromArgb(ScrollBar_Red.Value, ScrollBar_Green.Value, ScrollBar_Blue.Value);
            pictureBox1.BackColor = colorResult;

        }

        private void ButtonOthersColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ScrollBar_Blue.Value = colorDialog.Color.B;
                ScrollBar_Red.Value = colorDialog.Color.B;
                ScrollBar_Green.Value = colorDialog.Color.G;

                colorResult = colorDialog.Color;

                UpdateColor();
            }

        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.currentPen.Color = colorResult;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
