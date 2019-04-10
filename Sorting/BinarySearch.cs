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

        public static object BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])               
                    return ++mid;              
                else if (key < inputArray[mid])              
                    max = mid - 1;               
                else             
                    min = mid + 1;              
            }
            return -1;
        }

   
        static void Main(string[] args)
        {
            string[] tokens;
            string line;
            int[] inputArray;
            int n;
            int key;

            using (StreamReader myFile = new StreamReader("E:\\INP.txt"))
            {
                line = myFile.ReadLine();
                tokens = line.Split(' ');
                n = Convert.ToInt32(tokens[0]);
                key = Convert.ToInt32(tokens[1]);

                inputArray = new int[n];
                line = myFile.ReadLine();
                tokens = line.Split(' ');
                for (int i = 0; i < n; i++) inputArray[i] = Convert.ToInt32(tokens[i]);                          
            }

            using (StreamWriter outFile = new StreamWriter("E:\\OUT.txt"))
            {
               outFile.Write(BinarySearchIterative(inputArray,key));
            }

        }
    }
}
