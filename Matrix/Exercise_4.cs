using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Created by Chicken_Coder
namespace Exercise_4
{
    class Exercise_4
    {
        static void Main(string[] args)
        {
            int row, col;
            int[,] a;
            int[,] b;
            int[,] result;

            string input;
            string[] tokens;

            string arrayA;
            string[] saveArrayA;

            string arrayB;
            string[] saveArrayB;

            using (StreamReader myFile = new StreamReader("D:\\inp.txt"))
            {
                input = myFile.ReadLine();
                tokens = input.Split(' ');

                row = int.Parse(tokens[0]);
                col = int.Parse(tokens[1]);

                a = new int[row, col];
                b = new int[row, col];
                result = new int[row, col];

                for (int i = 0; i < row; i++)
                {
                    arrayA = myFile.ReadLine();
                    saveArrayA = arrayA.Split(' ');
                    for (int j = 0; j < col; j++)
                        a[i, j] = int.Parse(saveArrayA[j]);
                }

                for (int i = 0; i < row; i++)
                {
                    arrayB = myFile.ReadLine();
                    saveArrayB = arrayB.Split(' ');

                    for (int j = 0; j < col; j++)
                        b[i, j] = int.Parse(saveArrayB[j]);
                    

                }

                for (int i = 0; i < row; i++)              
                    for (int j = 0; j < col; j++)                
                        result[i, j] += a[i, j] + b[i, j];
		myFile.Close();
            }

            using (StreamWriter outFile=new StreamWriter("D:\\out.txt"))
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
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
