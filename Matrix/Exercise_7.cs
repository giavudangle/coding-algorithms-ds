using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Math;

namespace DISMATRIX
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int[,] b;
            int row, col;
            string input;
            string[] tokens;

            using (StreamReader myFile=new StreamReader("D:\\18DH110138\\ConsoleApplication1\\INP.txt"))
            {
                input = myFile.ReadLine();
                tokens = input.Split(' ');
                row = int.Parse(tokens[0]);
                col = int.Parse(tokens[1]);
                a = new int[row, col];
                b = new int[row, col];

                for (int i = 0; i < row; i++)
                {
                    input = myFile.ReadLine();
                    tokens = input.Split(' ');
                    for (int j = 0; j < col; j++)
                    {
                        a[i, j] = int.Parse(tokens[j]);
                    }
                }

                for (int i = 0; i < row; i++)
                {
                    input = myFile.ReadLine();
                    tokens = input.Split(' ');
                    for (int j = 0; j < col; j++)
                    {
                        b[i, j] = int.Parse(tokens[j]);
                    }
                }
                int temp = 0;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        temp += ((a[i, j] - b[i, j]) * (a[i, j] - b[i, j]));
                    }
                }
                double dist = Sqrt(temp);
                //Console.Write("{0:0.00}", dist);
                using (StreamWriter outFile=new StreamWriter("D:\\18DH110138\\ConsoleApplication1\\OUT.txt"))
                {
                    outFile.Write("{0:0.00}",dist);
                }
            }

        }
    }
}
