using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kletochnuy_avtomat
{
    public partial class Form2 : Form
    {
        int x;
        int y;
        int step = 0;
        Color voidCell = Color.Black;
        Color visitedCell = Color.Cyan;
        Color iatyt = Color.LimeGreen;
        Setka setka;
        int Heigh;
        int Width;
        int cellsize;
        Pen pen = new Pen(Color.Red);
        List<Ant> ants;
        Graphics g;
        Bitmap bmp;
        public Form2()
        {

            InitializeComponent();

        }
        public void SetCellSize()
        {
            if (Width >= Heigh)
            {
                cellsize = Heigh / (int)numericUpDown1.Value;
            }
            else
            {
                cellsize = Width / (int)numericUpDown1.Value;
            }

        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            Heigh = pictureBox1.Height;
            Width = pictureBox1.Width;
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            g = Graphics.FromImage(bmp);
            SetCellSize();
            setka = new Setka(Width / cellsize, Heigh / cellsize);
            ants = new List<Ant>();
            Draw();
            step = 0;
            label4.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)//главная
        {
            Reset();
            this.Close();

        }

        //private void panel1_Paint(object sender, PaintEventArgs e)//ставим точки
        //{
        //    Graphics g = panel1.CreateGraphics();
        //    Pen pen = new Pen(Color.Coral);
        //    g.DrawRectangle(pen, x, y, 2, 2);

        //}

        private void Draw() //отрисовка кадров
        {
            g = Graphics.FromImage(bmp);
            g.Clear(pictureBox1.BackColor);
            Brush visited = new SolidBrush(visitedCell);
            Brush iatut = new SolidBrush(iatyt);
            Brush voidcel = new SolidBrush(voidCell);

            for (int i = 0; i < Width / cellsize; i++)
            {
                for (int j = 0; j < Heigh / cellsize; j++)
                {
                    if (setka.grid[i, j] == 1)
                    {
                        g.FillRectangle(visited, i * cellsize, j * cellsize, cellsize, cellsize);
                    }
                    if (setka.grid[i, j] == 0)
                    {
                        g.FillRectangle(voidcel, i * cellsize, j * cellsize, cellsize, cellsize);
                    }
                }
            }

            for (int i = 0; i < ants.Count; i++)
            {
                g.FillRectangle(iatut, ants[i].x * cellsize, ants[i].y * cellsize, cellsize, cellsize);
            }
            pictureBox1.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
            {
                button1.Text = "Стоп";
            }
            else
            {
                button1.Text = "Начать";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ants.Count; i++)
            {
                if (setka.grid[ants[i].x, ants[i].y] == 0 || setka.grid[ants[i].x, ants[i].y] == 2)
                {
                    setka.grid[ants[i].x, ants[i].y] = 1;
                    ants[i].Left();
                }
                else
                {
                    setka.grid[ants[i].x, ants[i].y] = 0;
                    ants[i].Right();
                }
                ants[i].LetsGoAnt(setka);
            }
            step += 1;
            label4.Text =$"{step}";
            Draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
            
        }

        public void Reset()
        {
            button1.Text = "Начать";
            step = 0;
            label4.Text = "0";
            timer1.Enabled = false;
            numericUpDown1.Value = 50;
            SetCellSize();
            setka = new Setka(Width / cellsize, Heigh / cellsize);
            ants = new List<Ant>();
            Draw();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            if (setka.grid[e.X / cellsize, e.Y / cellsize] == 0)
            {
                setka.grid[e.X / cellsize, e.Y / cellsize] = 2;
                ants.Add(new Ant(e.X / cellsize, e.Y / cellsize, cellsize, rnd.Next(1, 5)));
            }
            Draw();
        }
    }
}
