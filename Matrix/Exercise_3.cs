using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Created by Chicken_Coder
namespace Exercise_3
{
    class Exercise_3
    {
        static void Main(string[] args)
        {
            int row, col;
            int[,] amount;
            int[] price;
            int[] sumEveryDay;

            string input;
            string money;
            string count;
            
            string[] tokens;
            string[] child;
            string[] matrix;

            

            using (StreamReader myFile = new StreamReader("D:\\inp.txt"))
            {
                input = myFile.ReadLine();
                tokens = input.Split(' ');

                row = int.Parse(tokens[0]);
                col = int.Parse(tokens[1]);

                amount = new int[row, col];
                price = new int[row];
                

                money = myFile.ReadLine();              
                for (int i = 0; i < price.Length; i++)
                {             
                    child = money.Split(' ');        
                    price[i] = int.Parse(child[i]);                                                      
                }

                for (int i = 0; i < row; i++)
                {
                    count = myFile.ReadLine();
                    matrix = count.Split(' ');
                    for (int j = 0; j < col; j++)
                    {
                        amount[i, j] = int.Parse(matrix[j]);
                    }
                }

                sumEveryDay = new int[col];
                for (int j = 0; j < col; j++)                              
                    for (int i = 0; i < row; i++)            
                        sumEveryDay[j] += price[i] * amount[i, j];
                myFile.Close();
            }

            using (StreamWriter outFile = new StreamWriter("D:\\out.txt"))
            {
                for (int k = 0; k < col; k++)               
                    outFile.Write("{0} ",sumEveryDay[k]);
                outFile.Close();
            }
        }
    }
}
