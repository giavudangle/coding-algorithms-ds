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
            string s;
            string fileInput = @"E:INP.txt";
            string fileOutput = @"E:OUT.txt";
            string[] tokens;

            using (StreamReader myFile=new StreamReader(fileInput))
            {

                s = myFile.ReadLine();
                tokens = s.Split(' ');
                using (StreamWriter outFile = new StreamWriter(fileOutput))
                {                                    
                    outFile.WriteLine(tokens[0]);
                    for (int i = 1; i < tokens.Length - 1; i++) outFile.Write(tokens[i]+" ");
                    outFile.WriteLine();
                    outFile.Write(tokens[tokens.Length-1]);
                }

            }           
        }
    }
}
