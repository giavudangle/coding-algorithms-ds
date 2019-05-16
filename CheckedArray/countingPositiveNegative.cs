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
        static void Main(string[] args)
        {
            string[] tokens;
            string line;         
            int[] a;
            int n;
            
            using (StreamReader myFile = new StreamReader("E:\\INP.txt"))
            {
                line = myFile.ReadLine();
                n = Convert.ToInt32(line);
                a = new int[n];
                line = myFile.ReadLine();
                tokens = line.Split(' ');
                for (int i = 0; i < n; i++) a[i] = Convert.ToInt32(tokens[i]);
                Array.Sort(a);
                
            }

            using (StreamWriter outFile = new StreamWriter("E:\\OUT.txt"))
            {
                int count = 1;
                for (int i = 1; i < n; i++)
                {
                    if (a[i] == a[i - 1]) count++;
                    else
                    {
                        outFile.WriteLine("{0}:{1}", a[i - 1], count);
                        count = 1;
                    }
                }
                outFile.WriteLine("{0}:{1}", a[n - 1], count);
            }

        }
    }
}
