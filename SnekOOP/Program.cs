using System;
using System.Collections.Generic;
using System.Threading;

namespace SnekOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int score = 0;
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point snakeTail = new Point(15, 15, 'E');
            Snek snake = new Snek(snakeTail, 4, Direction.RIGHT);
            snake.Draw();

            FoodGenerator foodGenerator = new FoodGenerator(80, 25, '/');
            Point food = foodGenerator.GenerateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {    
                        break;
                }
                if(snake.Eat(food))
                {
                    food = foodGenerator.GenerateFood();
                    food.Draw();
                    score++;
                }
                else
                {
                    snake.Move();
                }
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKeys(key.Key);
                }

                Thread.Sleep(300);
                
            }
            string str_score = Convert.ToString(score);
            WriteGameOver(str_score);
            Console.ReadLine();
        }
        public static void WriteGameOver(string score)
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("======TRY AGAIN LOL=======", xOffset, yOffset++);
            WriteText("     LMAOOOOO YOU DIED    ", xOffset+1, yOffset++);
            yOffset++;
            WriteText($"Covid Vaccines Taken: {score}", xOffset+2, yOffset++);
            WriteText("", xOffset+1, yOffset++);
            WriteText("===========================", xOffset, yOffset++);
        }              
                       
        public static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
