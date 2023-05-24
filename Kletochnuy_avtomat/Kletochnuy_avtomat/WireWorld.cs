using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kletochnuy_avtomat
{
    public partial class WireWorld : Form
    {
        Color voidCell = Color.Black;
        Color wireCell = Color.Orange;
        Color tailCell = Color.Cyan;
        Color headCell = Color.Red;
        Setka setka;
        Setka nextstep;
        Bitmap bmp;
        Graphics g;
        int cellsize;
        Pen pen = new Pen(Color.Red);
        int Heigh;
        int Width;
        byte index = 0;

        public WireWorld()
        {
            InitializeComponent();
        }
       

        private void WireWorld_Load(object sender, EventArgs e)
        {
            Width = pictureBox1.Width;
            Heigh = pictureBox1.Height;
            SetCellSize();
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            g = Graphics.FromImage(bmp);
            setka = new Setka(Width / cellsize, Heigh / cellsize);
            nextstep = new Setka(Width / cellsize, Heigh / cellsize);
            Draw();
            timer1.Enabled = true;
        }


        public void SetCellSize()
        {
            if (Width >= Heigh)
            {
                cellsize = Heigh / 50;
            }
            else
            {
                cellsize = Width / 50;
            }

        }

        private void Draw() //отрисовка кадров
        { //пустая - 0, проводник - 1, хвост - 2, голова - 3
            g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);
            Brush wire = new SolidBrush(wireCell);
            Brush tail = new SolidBrush(tailCell);
            Brush voidcell = new SolidBrush(voidCell);
            Brush head = new SolidBrush(headCell);
            for (int i = 0; i < Width / cellsize; i++)
            {
                for (int j = 0; j < Heigh / cellsize; j++)
                {
                    if (setka.grid[i, j] == 0)
                    {
                        g.FillRectangle(voidcell, i * cellsize, j * cellsize, cellsize, cellsize);
                    }
                    else if (setka.grid[i, j] == 1)
                    {
                        g.FillRectangle(wire, i * cellsize, j * cellsize, cellsize, cellsize);
                    }
                    else if (setka.grid[i, j] == 2)
                    {
                        g.FillRectangle(tail, i * cellsize, j * cellsize, cellsize, cellsize);
                    }
                    else if (setka.grid[i, j] == 3)
                    {
                        g.FillRectangle(head, i * cellsize, j * cellsize, cellsize, cellsize);
                    }

                }
            }

            pictureBox1.Image = bmp;


        }
        public void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            Reset();
            this.Close();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X / cellsize > 0 && e.X/cellsize < setka.Widht && e.Y / cellsize > 0 && e.Y / cellsize < setka.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    setka.grid[e.X / cellsize, e.Y / cellsize] = index;
                }
                Draw();

            }
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X / cellsize >0 && e.X / cellsize < pictureBox1.Width && e.Y / cellsize > 0 && e.Y / cellsize < pictureBox1.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    setka.grid[e.X / cellsize, e.Y / cellsize] = index;
                }
                Draw();

            }
        }


        public void Root()
        {

            for (int i = 0; i < Width / cellsize; i++)
            {
                for (int j = 0; j < Heigh / cellsize; j++)
                {
                    if (setka.grid[i, j] == 1)
                    {
                        if (Counter(i, j) == 2 || Counter(i, j) == 1)
                        {
                            nextstep.grid[i, j] = 3;
                        }
                        else
                        {
                            nextstep.grid[i, j] = 1;

                        }
                    }
                    else if (setka.grid[i, j] == 2)
                    {
                        nextstep.grid[i, j] = 1;
                    }
                    else if (setka.grid[i, j] == 3)
                    {
                        nextstep.grid[i, j] = 2;
                    }
                    else if(setka.grid[i, j] == 0)
                    {
                        nextstep.grid[i, j] = 0;
                    }

                }
            }
            for (int i = 0; i < Width / cellsize; i++)
            {
                for (int j = 0; j < Heigh / cellsize; j++)
                {
                    setka.grid[i, j] = nextstep.grid[i, j];
                }
            }
        }

        public int Counter(int x, int y)
        {
            int sum = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i == 0 && j == 0) continue;
                    if (x + i <= 0 || y + j <= 0 || x + i >= setka.Widht || y + j >= setka.Height)
                    {
                        continue;
                    }
                    else
                    {
                        if (setka.grid[x + i, y + j] == 3) { sum += 1; }
                    }
                }
            }
            return sum;
        }

        public void Reset()
        {
            setka = new Setka(Width / cellsize, Heigh / cellsize);
            nextstep = new Setka(Width / cellsize, Heigh / cellsize);
            Draw();
        }

        private void button_void_Click(object sender, EventArgs e)
        {
            ButtonRes();
            index = 0;
            button_void.FlatStyle = FlatStyle.Flat;
        }

        private void button_wire_Click(object sender, EventArgs e)
        {
            ButtonRes();
            index = 1;
            button_wire.FlatStyle = FlatStyle.Flat;
        }

        private void button_head_Click(object sender, EventArgs e)
        {
            ButtonRes();
            index = 2;
            button_head.FlatStyle = FlatStyle.Flat;
        }

        private void button_tail_Click(object sender, EventArgs e)
        {
            ButtonRes();
            index = 3;
            button_tail.FlatStyle = FlatStyle.Flat;
        }


        public void ButtonRes()
        {
            button_head.FlatStyle = FlatStyle.Popup;
            button_tail.FlatStyle = FlatStyle.Popup;
            button_wire.FlatStyle = FlatStyle.Popup;
            button_void.FlatStyle = FlatStyle.Popup;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Root();
            Draw();
        }
    }
}
