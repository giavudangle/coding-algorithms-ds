using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Math;

namespace DOTPRODUCT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int[,] b;
            //int size, size;
            int size;
            string input;
            string[] tokens;

            using (StreamReader myFile = new StreamReader("D:\\18DH110138\\ConsoleApplication1\\INP.txt"))
            {
                input = myFile.ReadLine();
                tokens = input.Split(' ');
                size = int.Parse(tokens[0]);
                //size = int.Parse(tokens[1]);
                a = new int[size, size];
                b = new int[size, size];

                for (int i = 0; i < size; i++)
                {
                    input = myFile.ReadLine();
                    tokens = input.Split(' ');
                    for (int j = 0; j < size; j++)
                    {
                        a[i, j] = int.Parse(tokens[j]);
                    }
                }

                for (int i = 0; i < size; i++)
                {
                    input = myFile.ReadLine();
                    tokens = input.Split(' ');
                    for (int j = 0; j < size; j++)
                    {
                        b[i, j] = int.Parse(tokens[j]);
                    }
                }

                int dotProduct = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        dotProduct += a[i, j] * b[i, j];
                    }
                }
                
                //Console.Write("{0}", dotProduct);
                //using (StreamWriter outFile = new StreamWriter("D:\\18DH110138\\ConsoleApplication1\\OUT.txt"))
                //{
                    outFile.Write("{0}", dotProduct);
                //}
            }

        }
    }
}
