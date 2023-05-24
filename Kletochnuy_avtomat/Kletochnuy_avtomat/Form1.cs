using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kletochnuy_avtomat
{
    public partial class Form1 : Form
    {
        Form2 form2= new Form2();
        Form3 form3 = new Form3();
        WireWorld wireworld = new WireWorld();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            form2.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wireworld.ShowDialog();
        }
    }
}
