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
    public partial class Form3 : Form
    {
        //мертвая 0, живая 1
        Setka setka;
        int step = 0;
        int Heigh;
        int Width;
        Setka nextDay;
        int cellsize;
        Color kletkatyt = Color.DarkGreen;
        Graphics g;
        Bitmap bmp;
        public Form3()
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
        private void Form3_Load(object sender, EventArgs e)
        {
            Heigh = pictureBox1.Height;
            Width = pictureBox1.Width;
            SetCellSize();
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            g = Graphics.FromImage(bmp);
            step = 0;
            label2.Text = "0";
            nextDay = new Setka(Width / cellsize, Heigh / cellsize);
            setka = new Setka(Width / cellsize, Heigh / cellsize);
            CompleteTheSetka();
            
        }

        public void Draw()
        {
            g = Graphics.FromImage(bmp);
            g.Clear(pictureBox1.BackColor);

            Brush kletka = new SolidBrush(kletkatyt);
            Brush voidcel = new SolidBrush(pictureBox1.BackColor);

            for (int i = 0; i < setka.Widht; i++)
            {
                for (int j = 0; j < setka.Height; j++)
                {
                    if (setka.grid[i, j] == 1)
                    {
                        g.FillRectangle(kletka, i * cellsize, j * cellsize, cellsize, cellsize);
                    }
                    if (setka.grid[i, j] == 0)
                    {
                        g.FillRectangle(voidcel, i * cellsize, j * cellsize, cellsize, cellsize);
                    }
                }
            }
            pictureBox1.Image = bmp;
        }
        public void CompleteTheSetka()
        {
            Random r = new Random();
            for (int i = 0; i < setka.Height; i++)
            {
                for(int j=0; j<setka.Widht; j++)
                {
                    setka.grid[j,i] = (byte)r.Next(0,2);
                    
                }
                
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
            {
                button2.Text = "Стоп";
            }
            else
            {
                button2.Text = "Начать";
            }
            
        }

        public void Life_Run()
        {
            for (int j = 0; j < setka.Height; j++)
            {
                for (int i = 0; i < setka.Widht; i++)
                {

                    if (setka.grid[i, j] == 1)
                    {
                        if (Counter(i, j) >= 2 && Counter(i, j) <= 3)
                        {
                            nextDay.grid[i, j] = 1;
                        }
                        else
                        {
                            nextDay.grid[i, j] = 0;
                        }
                    }
                    else
                    {
                        if (Counter(i, j) >= 3 && Counter(i, j) <= 3)
                        {
                            nextDay.grid[i, j] = 1;
                        }
                        else
                        {
                            nextDay.grid[i, j] = 0;
                        }
                    }


                }
            }

            //
            //       
            //  * * *
            // 


        }
        public void NextGenerate()
        {
            for (int j = 0; j < setka.Height; j++)
            {
                for (int i = 0; i < setka.Widht; i++)
                {
                    setka.grid[i, j] = nextDay.grid[i, j];
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
                    if (i == 0 && j==0) continue;
                    if (x + i <= 0 || y + j <= 0 || x + i >= setka.Widht || y + j >= setka.Height)
                    {
                        continue;
                    }
                    else
                    {
                        if (setka.grid[x + i, y + j] == 1) { sum += 1; }
                    }
                }
            }


            return sum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Life_Run();
            NextGenerate();
            Draw();
            step += 1;
            label2.Text = $"{step}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            button2.Text = "Начать";
            step = 0;
            label2.Text = "0";
            timer1.Enabled = false;
            numericUpDown1.Value = 50;
            SetCellSize();
            setka = new Setka(Width / cellsize, Heigh / cellsize);
            CompleteTheSetka();
            Draw();
        }
    }

}
