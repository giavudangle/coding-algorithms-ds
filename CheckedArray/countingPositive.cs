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
            int[] visited = new int[1000000];
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
                for (int i = 0; i < visited.Length; i++) visited[i] = 0;
                for (int i = 0; i < n; i++) visited[a[i]]++;
            }

            using (StreamWriter outFile = new StreamWriter("E:\\OUT.txt"))
            {
                for (int i = 0; i < n; i++)
                    if (visited[i] > 0) outFile.WriteLine("{0}:{1}\n", i, visited[i]);
            }

        }
    }
}