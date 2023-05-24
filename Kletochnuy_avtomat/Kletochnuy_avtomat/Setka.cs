using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kletochnuy_avtomat
{
    class Setka
    {
        public Byte[,] grid;
        public int Widht;
        public int Height;
        public Setka(int width,int heigh)
        {
            Widht = width;
            Height = heigh;
            grid = new Byte[width, heigh];
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < heigh; j++)
                {
                    grid[i, j] = 0;
                }
            }
        }
    }
}
