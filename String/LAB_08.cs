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
        static string AddingBigNumber(string s1, string s2)
        {
            string n1 = s1.Length >= s2.Length ? s1 : s2;
            string n2 = s1.Length >= s2.Length ? s2 : s1;

            int l1 = n1.Length - 1;
            int l2 = n2.Length - 1;
            int x2 = l1 - l2;
            int carry = 0;

            string reference = "01234567890123456789";
            string result = "";

            for (int i = l1; i >= 0; i--)
            {
                int ix = reference.IndexOf(n1[i]);
                if (i <= l2 + x2 && l1 - i <= l2)
                    ix += reference.IndexOf(n2[i - x2]);
                ix += carry;
                carry = ix > 9 ? 1 : 0;

                result = reference[ix] + result;
            }
            return carry > 0 ? result = '1' + result : result;
        }

        static void Main(string[] args)
        {
            string fileInput = @"e:inp.txt";
            string fileOutput = @"e:out.txt";
            string line;
            string x = "", y = "";


            using (StreamReader myFile=new StreamReader(fileInput))
            {
                line = myFile.ReadLine();
                x = line.ToString();
                line = myFile.ReadLine();
                y = line.ToString();
                using (StreamWriter outFile = new StreamWriter(fileOutput))
                {
                    outFile.Write(AddingBigNumber(x,y));
                }
            }                                                              
        }
    }
}

