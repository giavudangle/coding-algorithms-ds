using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            c1.Input();
            c2.Input();
            Console.WriteLine(c1.Output());
            Console.WriteLine(c2.Output());
            Complex sum = c1.Sum(c2);
            Complex minus = c1.Minus(c2);
            Complex product = c1.Product(c2);
            Complex divide = c1.Divide(c2);
            Console.WriteLine(minus.Output());
            Console.WriteLine(sum.Output());
            Console.WriteLine(product.Output());
            Console.WriteLine(divide.Output());




        }
    }
}
