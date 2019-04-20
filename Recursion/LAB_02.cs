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

        public static int Power(int a,int n)
        {
            if (n == 0) return 1;
            if (n % 2 == 0) return Power(a,n / 2) * Power(a,n / 2);    
            return a* Power(a, (n - 1) / 2) * Power(a, (n - 1) / 2);
        }

        static void Main(string[] args)
        {
            string fileInput = @"e:inp.txt";
            string fileOutput = @"e:out.txt";
            string line;
            string[] tokens;
        
            using (StreamReader myFile = new StreamReader(fileInput))
            {
                line = myFile.ReadLine();
                tokens = line.Split(' ');
                int a = int.Parse(tokens[0]);
                int n = int.Parse(tokens[1]);
                using (StreamWriter outFile = new StreamWriter(fileOutput))
                {
                    outFile.WriteLine(Power(a,n));
                }
            }
        }
    }
}

