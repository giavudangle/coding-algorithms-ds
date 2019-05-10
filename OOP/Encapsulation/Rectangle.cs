using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rectangle
    {
        // Declare member varriables.
        private double height;
        private double width;
      
        // Constructor about Rectangle. 
        public Rectangle()
        {
        }

        public Rectangle(double height,double width)
        {
            this.height = height;
            this.width = width;
        }

        public void Input()
        {
            height = double.Parse(Console.ReadLine());
            width = double.Parse(Console.ReadLine());
        }

        public String Output()
        {
            return "Rectangle[length=" + height + "," + "width=" + width + "]";
        }

        public double Perimeter()
        {
            return (width + height) * 2;
        }

        public double Area()
        {
            return width * height;
        }

        public double Axios()
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
        }

    }
}
