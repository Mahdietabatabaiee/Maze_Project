namespace maze_2
{ 
    //  |  = دیوار ها با  
    //  مسیر خالی = راه بازی 
    // X = راه حل بازی 
    // شروع و پایان مسیر = 0
    // مهدیه سادات طباطبایی - ماز 50 در 50 رندوم
    class Program
    {
        static int x= 50;
        static int y = 50;
        static char[,] maze = new char[x, y];
        static bool[,] check = new bool[x, y];
        static int startx = 0;
        static int starty = 0;
        static int endx = x - 1;
        static int endy = y - 1;

        static void Main(string[] args)
        {
            GrMaze();
            var maz = new maze1(x,y,maze);
            maz.ShowMaze();

           
            if (Findway(startx, starty))
            {
                Console.WriteLine("\n\n The soloution found  :) !! \n\n");
                var m=new maze1(x,y,maze);
                m.ShowMaze();
               
            }
            else
            {
                Console.WriteLine("No soloution found :(");
            }

            Console.ReadLine();
        }

        static void GrMaze()
        {
            Random random = new Random();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (random.Next(0, 100) < 30) 
                    {
                        maze[i, j] = '|';
                    }
                    else
                    {
                        maze[i, j] = ' ';
                    }
                }
            }

            maze[startx, starty] = '0';
            maze[endx, endy] = '0';
        }

 

        static bool Findway(int row, int col)
        {
            if (row < 0 || row >= x || col < 0 || col >= y || maze[row, col] == '|' || check[row, col])
            {
                return false;
            }

            check[row, col] = true;

            if (row == endx && col == endy)
            {
                return true;
            }

            if (Findway(row - 1, col)) 
            {
                maze[row, col] = 'X';
                return true;
            }

            if (Findway(row + 1, col)) 
            {
                maze[row, col] = 'X';
                return true;
            }

            if (Findway(row, col - 1)) 
            {
                maze[row, col] = 'X';
                return true;
            }

            if (Findway(row, col + 1))
            {
                maze[row, col] = 'X';
                return true;
            }

            return false;
        }
    }
}
    
