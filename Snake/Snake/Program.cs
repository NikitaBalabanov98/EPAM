using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();
            Point p3 = new Point(6, 2, '&');

            Point p4 = new Point(3, 5, '%');
            List<Point> Plist = new List<Point>();
            Plist.Add(p1);
            Plist.Add(p2);
            Plist.Add(p3);
            Plist.Add(p4);

            List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];
            Console.WriteLine();
            foreach (int i in numlist)
            {
            Console.WriteLine(i);


            numlist.Remove(0);
            Console.ReadLine();
        }
        
    }
}
