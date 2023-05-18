using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR10
{
    public partial class Form1 : Form
    {
        Rectangle rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle circle = new Rectangle(220, 10, 150, 150);
        Rectangle square = new Rectangle(380, 10, 150, 150);
        bool rect = false;
        bool circ = false;
        bool sqr = false;
        int rectX = 0;
        int rectY = 0;
        int circX = 0;
        int circY = 0;
        int sqrX = 0;
        int sqrY = 0;
        int x, y, dx, dy;
        int LastClicked = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, circle);
            e.Graphics.FillRectangle(Brushes.Blue, square);
            e.Graphics.FillRectangle(Brushes.Yellow, rectangle);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < rectangle.X + rectangle.Width) && (e.X > rectangle.X) && (e.Y < rectangle.Y + rectangle.Height) && (e.Y > rectangle.Y))
            {
               // if ((e.Y < rectangle.Y + rectangle.Height) && (e.Y > rectangle.Y))
               // {
                    rect = true;
                    LastClicked = 3;
                    rectX = e.X - rectangle.X;
                    rectY = e.Y - rectangle.Y;
               // }
            }
            else if ((e.X < square.X + square.Width) && (e.X > square.X) && (e.Y < square.Y + square.Height) && (e.Y > square.Y))
            {
                //if ((e.Y < square.Y + square.Height) && (e.Y > square.Y))
                //{
                    sqr = true;
                    LastClicked = 1;
                    sqrX = e.X - square.X;
                    sqrY = e.Y - square.Y;
               // }
            }
            else if ((e.X < circle.X + circle.Width) && (e.X > circle.X) && (e.Y < circle.Y + circle.Height) && (e.Y > circle.Y))
            {
                //if ((e.Y < circle.Y + circle.Height) && (e.Y > circle.Y))
                //{
                    circ = true;
                    LastClicked = 2;
                    circX = e.X - circle.X;
                    circY = e.Y - circle.Y;
                //}
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            sqr = false;
            circ = false;
            rect = false;
            if (LastClicked == 1)
            {
                if ((label2.Location.X < square.X + square.Width) && (label2.Location.X > square.X))
                {
                    if ((label2.Location.Y < square.Y + square.Height) && (label2.Location.Y > square.Y))
                    {
                        x = square.X;
                        y = square.Y;
                        dx = sqrX;
                        dy = sqrY;
                        square.X = rectangle.X;
                        square.Y = rectangle.Y;
                        sqrX = rectX;
                        sqrY = rectY;

                        rectangle.X = x;
                        rectangle.Y = y;
                        rectX = dx;
                        rectY = dy;
                    }
                }
            }
            if (LastClicked == 3)
            {
                if ((label2.Location.X < rectangle.X + rectangle.Width) && (label2.Location.X > rectangle.X))
                {
                    if ((label2.Location.Y < rectangle.Y + rectangle.Height) && (label2.Location.Y > rectangle.Y))
                    {
                        x = rectangle.X;
                        y = rectangle.Y;
                        dx = rectX;
                        dy = rectY;
                        rectangle.X = circle.X;
                        rectangle.Y = circle.Y;
                        rectX = circX;
                        rectY = circY;

                        circle.X = x;
                        circle.Y = y;
                        circX = dx;
                        circY = dy;


                    }
                }
            }
            if (LastClicked==2)
            {
                if ((label2.Location.X < circle.X + circle.Width) && (label2.Location.X > circle.X))
                {
                    if ((label2.Location.Y < circle.Y + circle.Height) && (label2.Location.Y > circle.Y))
                    {
                        x = circle.X;
                        y = circle.Y;
                        dx = circX;
                        dy = circY;
                        circle.X = square.X;
                        circle.Y = square.Y;
                        circX = sqrX;
                        circY = sqrY;

                        square.X = x;
                        square.Y = y;
                        sqrX = dx;
                        sqrY = dy;


                    }
                }
            }


        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (circ)
            {
                circle.X = e.X - circX;
                circle.Y = e.Y - circY;
            }
            if (rect)
            {
                rectangle.X = e.X - rectX;
                rectangle.Y = e.Y - rectY;
            }
            if (sqr)
            {
                square.X = e.X - sqrX;
                square.Y = e.Y - sqrY;
            }
            if ((label1.Location.X < square.X + square.Width) && (label1.Location.X > square.X))
            {
                if ((label1.Location.Y < square.Y + square.Height) && (label1.Location.Y > square.Y))
                {
                    label3.Text = "Синий квадрат";
                }
            }
            if ((label1.Location.X < circle.X + circle.Width) && (label1.Location.X > circle.X))
            {
                if ((label1.Location.Y < circle.Y + circle.Height) && (label1.Location.Y > circle.Y))
                {
                    label3.Text = "Красный круг";
                }
            }
            if ((label1.Location.X < rectangle.X + rectangle.Width) && (label1.Location.X > rectangle.X))
            {
                if ((label1.Location.Y < rectangle.Y + rectangle.Height) && (label1.Location.Y > rectangle.Y))
                {
                    label3.Text = "Желтый прямоугольник";
                }
            }

            pictureBox1.Invalidate();
        }
    }
}
