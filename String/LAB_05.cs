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
            string line;
            string fileInput = @"E:INP.txt";
            string fileOutput = @"E:OUT.txt";
            string[] tokens;
            int count;
            int pick;
            Console.OutputEncoding = Encoding.Unicode;       
            List<String> name = new List<String>();

            using (StreamReader myFile = new StreamReader(fileInput))
            {
                
                line = myFile.ReadLine();
                tokens = line.Split(' ');
                count= Convert.ToInt32(tokens[0]);
                pick = Convert.ToInt32(tokens[1]);
                
                for (int i = 0; i < count; i++)
                {
                    line = myFile.ReadLine();
                    name.Add(line);                             
                }

                using (StreamWriter outFile=new StreamWriter(fileOutput))
                {
                    switch (pick)
                    {
                        case 1:
                            name.Sort();
                            foreach (string x in name)
                                outFile.WriteLine(x);
                            break;

                        case 2:
                            var orderedList = name.OrderBy(item => item.Split(' ').Last());
                            foreach (string x in orderedList)
                                outFile.WriteLine(x);
                            break;

                        default:
                            outFile.Write("Try Again");
                            break;
                    }
                }             
            }
        }
    }
}

    