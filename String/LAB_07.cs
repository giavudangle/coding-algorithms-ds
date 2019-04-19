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
                char mat = 'R';

                foreach(char step in path)
                {
                    if (mat == 'R')
                    {
                        if (step == 'F')
                        {
                            x++;
                            mat = 'R';                           
                        }
                        if (step == 'L')
                        {
                            y++;
                            mat = 'F';                           
                        }
                        if (step == 'R')
                        {
                            y--;
                            mat = 'B';                            
                        }
                        if (step == 'B')
                        {
                            x--;
                            mat = 'L';                           
                        }
                    }
                    else 
                    if (mat == 'L')
                    {
                        if (step == 'F')
                        {
                            x--;
                            mat = 'L';                           
                        } 
                        if (step == 'L')
                        {
                            y--;
                            mat = 'B';                            
                        }
                        if (step == 'R')
                        {
                            y++;
                            mat = 'F';                           
                        }
                        if (step == 'B')
                        {
                            x++;
                            mat = 'R';                            
                        }
                    }
                    else
                    if (mat == 'F')
                    {
                        if (step == 'F')
                        {
                            y++;
                            mat = 'F';                          
                        }
                        if (step == 'L')
                        {
                            x--;
                            mat = 'L';                         
                        }
                        if (step == 'R')
                        {
                            x++;
                            mat = 'R';                           
                        }
                        if (step == 'B')
                        {
                            y--;
                            mat = 'B';                           
                        }
                    }
                    else 
                    if (mat == 'B')
                    {
                        if (step == 'F')
                        {
                            y--;
                            mat = 'B';                           
                        }
                        if (step == 'L')
                        {
                            x++;
                            mat = 'R';                        
                        }
                        if (step == 'R')
                        {
                            x--;
                            mat = 'L';                            
                        }
                        if (step == 'B')
                        {
                            y++;
                            mat = 'F';                         
                        }
                    }
                }          
                using (StreamWriter outFile=new StreamWriter(fileOutput))
                {
                    outFile.Write("{0} {1}", x, y);
                }
            }                                    
        }
    }
}

