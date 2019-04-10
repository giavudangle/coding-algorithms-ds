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
        public static void CountingSort(int[]a,int n)
        {
            int[] counting = new int[100000 + 10];
            
            for (int i = 0; i < counting.Length; i++) counting[i] = 0;

            for (int i = 0; i < n; i++) counting[a[i]]++;

            int outputIndex = 0;

            for (int i=0;i<counting.Length;i++)
                if (counting[i] > 0)
                {
                    while (counting[i]-- > 0)
                        a[outputIndex++] = i;
                }             
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
                CountingSort(a, n);         
            }

            using (StreamWriter outFile = new StreamWriter("E:\\OUT.txt"))
            {
                for (int i = 0; i < n; i++) outFile.Write("{0} ", a[i]);
            }

        }
    }
}
