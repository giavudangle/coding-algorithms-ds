using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Point2D
    {
        private int x;
        private int y;

        public Point2D()
        {
            x = 0;
            y = 0;
        }

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point2D(Point2D p)
        {
            x = p.x;
            y = p.y;
        }

        public void Input()
        {
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
        }

        public string TOString()
        {
            return "(" + x + "," + y + ")";
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsOrigin(int x, int y)
        {
            return x == 0 && y == 0;
        }

        public double Distance(Point2D p)
        {
            return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
        }

        public static double Distance(Point2D p1, Point2D p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }
    }
}