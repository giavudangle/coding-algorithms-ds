using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Circle : Shape
    {
        private double radius;

        public Circle()
        {

        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.radius = radius;
            this.color = color;
            this.filled = filled;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public override double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double getPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string toString()
        {
            return "Area of Circle is " + getArea() + "\n" + "Perimeter of Circle is" + getPerimeter() + "\n";
        }
    }
}
