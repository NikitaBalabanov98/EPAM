using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80,25);
            Console.SetBufferSize(80,25);

            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);
            Point p = new Point(4,5, '*');
            Figure fSnake = new Snake(p,4,Direction.RIGHT);
            Draw(fSnake);
            Snake snake1 = (Snake)fSnake;

            HorizontalLine h1 = new HorizontalLine(0,5,5,'&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach(var f in figures)
            {
                f.Draw();
            }

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');      
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
            FoodCreater foodCreater = new FoodCreater(80,25, '$');
            Point food = foodCreater.CreateFood();
            food.Draw();
            Point p1 = new Point(5, 3, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreater.CreateFood();
                    food.Draw();
                }
                else snake.Move();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(200);

            }
            Console.ReadLine();
        }
        static void Draw(Figure figure)
        {
            figure.Draw();
        }
        
    }
}
