namespace Kletochnuy_avtomat
{
    class Ant
    {
        public int x = 0;
        public int y = 0;
        int side = 1;
        int b = 0;
        public Ant(int startX, int startY, int Size, int startside)
        {
            x = startX;
            y = startY;
            b = Size;
            side = startside;
        }
        public void LetsGoAnt(Setka we)
        {


            switch (side)
            {
                case 1:
                    {
                        if (y < we.Height && y > 0)
                        {
                            //we.grid[x, y] = 1;
                            y--;
                            //we.grid[x, y] = 2;
                        }
                        else
                        {
                            Right();
                        }

                        break;
                    }
                case 2:
                    {
                        if (x < we.Widht - 1)
                        {
                            //we.grid[x, y] = 1;
                            x++;
                            //we.grid[x, y] = 2;
                        }
                        else
                        {
                            Right();
                        }
                        break;
                    }
                case 3:
                    {
                        if (y < we.Height - 1)
                        {
                            //we.grid[x, y] = 1;
                            y++;
                            //we.grid[x, y] = 2;
                        }
                        else
                        {
                            Right();
                        }
                        break;

                    }
                case 4:
                    {
                        if (x > 0)
                        {
                            // we.grid[x, y] = 1;
                            x--;
                            //we.grid[x, y] = 2;
                        }
                        else
                        {
                            Right();
                        }
                        break;
                    }
            }


        }
        public void Right()
        {
            side++;
            if (side > 4)
            {
                side = 1;
            }
        }
        public void Left()
        {
            side--;
            if (side < 1)
            {
                side = 4;
            }
        }

    }
}
