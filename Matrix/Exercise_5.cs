using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Created by Chicken_Coder
namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col, temp;
            int[,] a;
            int[,] b;
            int[,] result;
            int save = 0;

            string input;
            string[] tokens;

            string arrayA;
            string[] saveA;

            string arrayB;
            string[] saveB;


            using (StreamReader myFile = new StreamReader("D:\\18DH110138\\ConsoleApplication1\\INP.txt"))
            {
                input = myFile.ReadLine();
                tokens = input.Split(' ');
                row = int.Parse(tokens[0]);
                col = int.Parse(tokens[1]);
                temp = int.Parse(tokens[2]);
                a = new int[row, col];
                b = new int[col, temp];
                result = new int[col, temp];

                for (int i = 0; i < row; i++)
                {
                    arrayA = myFile.ReadLine();
                    saveA = arrayA.Split(' ');
                    for (int j = 0; j < col; j++)
                    {
                        a[i, j] = int.Parse(saveA[j]);
                    }
                }

                for (int i = 0; i < col; i++)
                {
                    arrayB = myFile.ReadLine();
                    saveB = arrayB.Split(' ');
                    for (int j = 0; j < temp; j++)
                    {
                        b[i, j] = int.Parse(saveB[j]);
                    }
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < temp; j++)
                    {
                        save = 0;
                        for (int k = 0; k < col; k++)
                        {
                            save += a[i, k] * b[k, j];
                        }
                        result[i, j] = save;
                    }
                }
                myFile.Close();
            }

            using (StreamWriter outFile = new StreamWriter("D:\\18DH110138\\ConsoleApplication1\\OUT.txt"))
            {

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < temp; j++)
                    {
                        outFile.Write("{0} ", result[i, j]);
                    }
                    outFile.WriteLine();
                }
                outFile.Close();
            }
        }
    }
}
