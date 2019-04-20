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
        static string fileInput = @"e:inp.txt";
        static string fileOutput = @"e:out.txt";
        static string line;
        static string[] tokens;
        static List<string> res = new List<string>();
        public static void TowerOfHanoi(int n,char a,char b,char c)
        {
            if (n == 1)
            {           
                line="Chuy?n ??a t? c?t " + a + " sang c?t " + c;                
                res.Add(line);                  
                return;               
            }
            TowerOfHanoi(n - 1, a, c, b);
            TowerOfHanoi(1, a, b, c);
            TowerOfHanoi(n - 1, b, a, c);
        }
        

        static void Main(string[] args)
        {
           
        
            using (StreamReader myFile = new StreamReader(fileInput))
            {
                line = myFile.ReadLine();           
                int n = int.Parse(line);
                char a = 'A', b = 'B', c = 'C';
                TowerOfHanoi(n, a, b, c);
                using (StreamWriter outFile=new StreamWriter(fileOutput))
                {
                    foreach (string step in res)
                    {
                        outFile.WriteLine(step);
                    }
                }
              
            }
        }
    }
}

