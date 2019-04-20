using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Created by Chicken_Coder
namespace ConsoleApp1
{
    class Program
    {

        public static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);      
        }

        static void Main(string[] args)
        {
            string fileInput = @"e:inp.txt";
            string fileOutput = @"e:out.txt";
            string line;
            int n;
          
            using (StreamReader myFile = new StreamReader(fileInput))
            {
                line = myFile.ReadLine();
                n = int.Parse(line);
                using (StreamWriter outFile = new StreamWriter(fileOutput))
                {
                    outFile.WriteLine(Factorial(n));
                }
            }
        }
    }
}

