﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace SnakeGame
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
            Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            Point p2 = new Point(4, 5, '#');


            //p2.Draw();

            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLines rightline = new VerticalLines(0, 0, 24, '+');
            VerticalLines leftline = new VerticalLines(78, 0, 24, '+');
            

            
            

            upline.Drow();
            downline.Drow();
            rightline.Drow();
            leftline.Drow();


            Point p = new Point( 2, 3, '*' );
            Snake snake = new Snake( p, 3, Direction.RIGHT );
            snake.Drow();
            snake.Move();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(300);
                snake.Move();




                
            }
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
            }
            
        }

    }
}
