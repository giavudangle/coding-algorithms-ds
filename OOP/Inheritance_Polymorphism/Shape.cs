using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Created by Chicken_Coder
namespace ConsoleApp2
{
    abstract class Shape
    {
        protected string color;
        protected bool filled;

        public Shape()
        {

        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public bool isFilled()
        {
            if (filled) return true;
            return false;
        }

        public void setFilled(bool filled)
        {
            if (!filled) filled = true;
        }
        
        public abstract double getArea();
        public abstract double getPerimeter();
        public abstract string toString();

    }
}
