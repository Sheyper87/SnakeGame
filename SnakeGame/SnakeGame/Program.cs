using System;
using System.Collections;
using System.Collections.Generic;

namespace SnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');


            p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 4, '+');
            line.Drow();


            Console.ReadLine();
        }
    }
}
