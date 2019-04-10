using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise_6
{
    class Exercise_6
    {
        static void Main(string[] args)
        {
            int row, col;
            int[,] a;
            int[,] result;


            string input;
            string[] tokens;

            string array;
            string[] saveArray;



            using (StreamReader myFile = new StreamReader("E:\\inp.txt"))
            {
                input = myFile.ReadLine();
                tokens = input.Split(' ');
                row = int.Parse(tokens[0]);
                col = int.Parse(tokens[1]);

                a = new int[row, col];
                result = new int[row, col];
                //result = new int[row, temp];

                for (int i = 0; i < row; i++)
                {
                    array = myFile.ReadLine();
                    saveArray = array.Split(' ');
                    for (int j = 0; j < col; j++)
                    {
                        a[i, j] = int.Parse(saveArray[j]);
                    }
                }

             
            }


            using (StreamWriter outFile = new StreamWriter("E:\\out.txt"))
            {

                for (int i = 0; i < col; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        outFile.Write("{0} ", a[j, i]);
                    }
                    outFile.WriteLine();
                }
                outFile.Close();
            }
        }
    }
    
}
