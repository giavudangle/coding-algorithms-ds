using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Created by Chicken_Coder

namespace LAB9
{
    class Program
    {
        static string fileInput = @"E:\INP.txt";
        static string fileOutput = @"E:\INP.txt";
        static string[] tokens;
        static string line;
        static int m, n, k;
        static int[,] a;
        static int[,] b;
        static double[,] c;
     
        static void Input()
        {
            using (StreamReader myFile = new StreamReader(fileInput))
            {
                line = myFile.ReadLine();
                tokens = line.Split(' ');
                m = int.Parse(tokens[0]);
                n = int.Parse(tokens[1]);
                k = int.Parse(tokens[2]);

                a = new int[m, n];
                b = new int[k, k];

                for (int i = 0; i < m; i++)
                {
                    line = myFile.ReadLine();
                    tokens = line.Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        a[i, j] = int.Parse(tokens[j]);
                    }
                }

                for (int i = 0; i < k; i++)
                {
                    line = myFile.ReadLine();
                    tokens = line.Split(' ');
                    for (int j = 0; j < k; j++)
                    {
                        b[i, j] = int.Parse(tokens[j]);
                    }
                }
            }
        }
      
        static void Convolution()
        {
            int rowC = m - k + 1;
            int colC = n - k + 1;
            c = new double[rowC, colC];

            for (int h = 0; h < rowC; h++)
            {
                for (int l = 0; l < colC; l++)
                {
                    c[h, l] = 0;
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            c[h,l] += a[h + l, l + j] * b[i, j];
                        }
                    }
                }
            }
        }

        static void Output()
        {
            using (StreamWriter outFile=new StreamWriter(fileOutput))
            {
                for (int i = 0; i < m - k + 1; i++)
                {
                    for (int j = 0; j < n - k + 1; j++)
                    {
                        outFile.Write(c[i, j] + " ");
                    }
                    outFile.WriteLine();
                }
            }        
        }
         
        static void Main(string[] args)
        {
            Input();
            Convolution();
            Output();
        }
    }
}
