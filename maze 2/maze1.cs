using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace maze_2
{
    internal class maze1
    {
         static private int x = 50;
       static private int y = 50;
       static private char[,] maze = new char[x,y];
        public maze1() { }
        public maze1(int X, int Y, char[,] Maze)
        {
            x= X;
            y = Y;
           maze = Maze;

        }
        public void ShowMaze()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(maze[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
