using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int y1 = 1;
            char sim1 = '*';
            Draw(x1,y1,sim1);

            int x2 = 4;
            int y2 = 5;
            char sim2 = '*';
             Draw(x2,y2,sim2);

          
           
        }
        static void Draw(int x, int y, char sim)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sim);
        }
        Console.ReadLine();
    }

