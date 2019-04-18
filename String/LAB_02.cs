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
        static string s;
        static List<String> result=new List<String>();
        public static bool Checking(string s)
        {
            if (s.Length<8) return false;
            bool isLower = false;
            bool isUpper = false;
            bool isDigit = false;
            for (int i = 0; i < s.Length; i++)
                if (char.IsLower(s[i])) isLower = true;
                    else if (char.IsUpper(s[i])) isUpper = true;
                        else if (char.IsDigit(s[i])) isDigit = true;         
            if (!isLower || !isUpper || !isDigit) return false;
            return true;
        }
    
        public static void Processing(string s)
        {
            using (StreamWriter outFile=new StreamWriter(@"E:OUT.txt"))
            {
                if (Checking(s) == true)
                    result.Add("Yes\n");
                else result.Add("No\n");

                
                //outFile.Close();
            }
           
        }

        public static int Password(string s)
        {
            string line;
            string filePath = @"E:INP.txt";
          
            if (File.Exists(filePath))
            {
                StreamReader file = null;
                try
                {
                    file = new StreamReader(filePath);
                    while ((line = file.ReadLine()) != null)
                    {                     
                        
                        if (line == "-1") return 0;
                        Processing(line);
                    }
                }
                finally
                {                 
                    if (file != null)
                        file.Close();
                }
            }
           
            return 1;
        }

        static void Main(string[] args)
        {
            Password(s);
            
                using (StreamWriter outFile=new StreamWriter("E:\\OUT.txt"))
                {
                    foreach (string e in result)
                    outFile.WriteLine(e);
                }       
        }
    }
}

