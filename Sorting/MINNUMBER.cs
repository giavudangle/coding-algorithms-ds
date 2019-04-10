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
        

        public static int Processing(int[]a,int n)
        {
            Array.Sort(a);             
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == a[i + 1]) continue;
                if (a[i] + 1 != a[i + 1])
                    return (a[i]+1);
            }
            return 0;
        }

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
            }

            using (StreamWriter outFile = new StreamWriter("E:\\OUT.txt"))
            {
               outFile.Write(Processing(a,n));
            }

        }
    }
}
