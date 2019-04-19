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
            
            string fileInput = @"E:INP.txt";
            string fileOutput = @"E:OUT.txt";
            string line;
            string path;
            string[] tokens;
            int x, y;
            

            using (StreamReader myFile=new StreamReader(fileInput))
            {
                line = myFile.ReadLine();
                tokens = line.Split(' ');
                x = int.Parse(tokens[0]);
                y = int.Parse(tokens[1]);

                path = myFile.ReadLine();
                
                foreach(char step in path)
                {                
                    switch (step)
                    {
                        case 'B':
                            y++;
                            break;
                        case 'N':
                            y--;
                            break;
                        case 'T':
                            x--;
                            break;
                        case 'D':
                            x++;
                            break;
                    }
                }

                using(StreamWriter outFile=new StreamWriter(fileOutput))
                {
                    outFile.Write("{0} {1}", x, y);
                }
            }                                    
        }
    }
}

    