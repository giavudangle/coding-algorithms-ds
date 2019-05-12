using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Complex
    {
        private int real;
        private int mirage;
       

        public Complex()
        {

        }

        public Complex(int real,int mirage)
        {
            this.real = real;
            this.mirage = mirage;
        }

        public void Input()
        {
            real = int.Parse(Console.ReadLine());
            mirage = int.Parse(Console.ReadLine());
        }

        public string Output()
        {
            return "Complex(" + real + "," + mirage + ")";
        }

        public virtual Complex Sum(Complex complex)
        {
            int reality = real + complex.real;
            int miragelly = mirage + complex.mirage;
            return new Complex(reality, miragelly);
        }

        public virtual Complex Minus(Complex complex)
        {
            int reality = real - complex.real;
            int miragelly = mirage - complex.mirage;
            return new Complex(reality, miragelly);
        }

        public virtual Complex Product(Complex complex)
        {
            int reality = (real*complex.real)-(mirage*complex.mirage);
            int miragelly = (real * complex.mirage) + (mirage * complex.real);
            return new Complex(reality, miragelly);
        }

        public virtual Complex Divide(Complex complex)
        {
            int top = ((real * complex.real) + (mirage * complex.mirage));
            int down = ((complex.real * mirage) - (real * complex.mirage));
            int v2 = (int)(Math.Pow(complex.real, 2));
            int v3 = (int)(Math.Pow(complex.mirage, 2));

            int sub1 = v2 + v3;
            int sub2 = v2 + v3;

            int reality = top / sub1;
            int miragelly = down / sub2;
        
            return new Complex(reality, miragelly);
        }


    }
}
