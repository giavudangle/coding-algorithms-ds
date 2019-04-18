using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
// Created by Chicken_Coder
namespace ConsoleApp1
{
    class Program
    {
        
        static string RemoveAccents(string input)
        {
            var temp = input.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();
            foreach (var c in temp)
            {
                var category = char.GetUnicodeCategory(c);
                if (category != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }
            string output = stringBuilder.ToString();
            output = output.Normalize(NormalizationForm.FormC);
            return output;
        }

        static void Main(string[] args)
        {
            string input;
            string fileInput = @"E:INP.txt";
            string fileOutput = @"E:OUT.txt";

            using (StreamReader myFile = new StreamReader(fileInput))
            {
                input = myFile.ReadLine();
            }

            using (StreamWriter outFile = new StreamWriter(fileOutput))
            {
                outFile.Write(RemoveAccents(input));
            }

        }
    }
}
