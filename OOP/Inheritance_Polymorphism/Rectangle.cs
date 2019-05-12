using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rectangle:Shape
    {
        private double width;
        private double length;

        public Rectangle()
        {

        }

        public Rectangle(string color,bool filled) : base(color, filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public Rectangle(double width,double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width,double length,string color,bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
            this.color = color;
            this.filled = filled;
        }

        public double getWidth()
        {
            return width;
        }

        public virtual void setWidth(double width)
        {
            this.width = width;
        }

        public  double getLength()
        {
            return length;
        }

        public virtual void setLength(double length)
        {
            this.length = length;
        }

        public  override double getArea()
        {
            return width * length;
        }

        public override double getPerimeter()
        {
            return (width + length) * 2;
        }

        public override string toString()
        {
            return "Area of Rectangle is " + getArea() + "\n" + "Perimeter of Rectangle is " + getPerimeter() + "\n";
        }

    }
}
