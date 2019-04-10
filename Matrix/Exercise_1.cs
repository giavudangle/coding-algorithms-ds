using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Created by Chicken_Coder
namespace Exercise_1
{
    class Exercise_1
    {
        static void Main(string[] args)
        {
            int row, col;
            int[,] arr;
            string input;
            string[] tokens;

            using (StreamReader myFile = new StreamReader("D:\\inp.txt"))
            {
                input = myFile.ReadLine();
                tokens = input.Split(' ');
                row = int.Parse(tokens[0]);
                col = int.Parse(tokens[1]);
                arr = new int[row, col];

                for (int i = 0; i < row; i++)
                {
                    input = myFile.ReadLine();
                    tokens = input.Split(' ');
                    for (int j = 0; j < col; j++)
                    {
                        arr[i, j] = int.Parse(tokens[j]);
                    }
                }
                myFile.Close();
            }

            using (StreamWriter outFile = new StreamWriter("D:\\out.txt"))
            {
                for (int i = 0; i < row; i++)
                {
                    outFile.Write("Row {0}: ", i);
                    for (int j = 0; j < col; j++)
                    {
                        outFile.Write("{0} ", arr[i, j]);
                    }
                    outFile.WriteLine();
                }

                outFile.WriteLine();

                for (int j = 0; j < col; j++)
                {
                    outFile.Write("Col {0}: ", j);
                    for (int i = 0; i < row; i++)
                    {
                        outFile.Write("{0} ", arr[i, j]);
                    }
                    outFile.WriteLine();
                }
                outFile.Close();
            }
        }
    }
}
