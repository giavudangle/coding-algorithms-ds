using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Created by Chicken_Coder
namespace ConsoleApp2
{
    class Square:Rectangle
    {
        private double side;

        public Square()
        {

        }

        public Square(double side)
        {
            this.side = side;
        }

        public Square(double side,string color,bool filled):base(color,filled)
        {
            this.side = side;
        }

        public double getSide()
        {
            return side;
        }

        public void setSide(double side)
        {
            this.side = side;
        }

        public override void setWidth(double side)
        {
             base.setWidth(side);
        }

        public override void setLength(double side)
        {
            base.setLength(side);
        }

        public override string toString()
        {
            return "I'm a Square";
        }

    }
}
