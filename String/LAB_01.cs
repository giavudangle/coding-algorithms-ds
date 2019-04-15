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
            int type = 0;
            int visited = 0;
            char save = ' ';

            int[] count = new int[1000];
            using (StreamReader myFile=new StreamReader("E:\\INP.txt"))
            {
                s = myFile.ReadLine();            
                for (int i = 0; i < s.Length; i++)
                    if (char.IsLower(s[i]))
                        count[s[i]]++;            
                for (int i = 0; i < count.Length; i++)
                {
                    if (count[i] > 0)
                    {
                        type++;
                        if (count[i] > visited)
                        {
                            visited = count[i];
                            save = (char)i;
                        }
                    }
                }
               using (StreamWriter outFile=new StreamWriter("E:\\OUT.txt"))
                {
                    outFile.WriteLine(type);
                    outFile.WriteLine(save);
                }
            }
        }
    }
}