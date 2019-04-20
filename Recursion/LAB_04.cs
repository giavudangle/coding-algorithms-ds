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

        #region ??c ti?n thành ch?
        public static String NumberToTextVN(decimal total)
        {
            try
            {
                string rs = "";
                total = Math.Round(total, 0);
                string[] ch = { "không", "m?t", "hai", "ba", "b?n", "n?m", "sáu", "b?y", "tám", "chín" };
                string[] rch = { "l?", "m?t", "", "", "", "l?m" };
                string[] u = { "", "m??i", "tr?m", "ngàn", "", "", "tri?u", "", "", "t?", "", "", "ngàn", "", "", "tri?u" };
                string nstr = total.ToString();

                int[] n = new int[nstr.Length];
                int len = n.Length;
                for (int i = 0; i < len; i++)
                {
                    n[len - 1 - i] = Convert.ToInt32(nstr.Substring(i, 1));
                }

                for (int i = len - 1; i >= 0; i--)
                {
                    if (i % 3 == 2)
                    {
                        if (n[i] == 0 && n[i - 1] == 0 && n[i - 2] == 0) continue;
                    }
                    else if (i % 3 == 1) 
                    {
                        if (n[i] == 0)
                        {
                            if (n[i - 1] == 0) { continue; }
                            else
                            {
                                rs += " " + rch[n[i]]; continue;
                            }
                        }
                        if (n[i] == 1)
                        {
                            rs += " m??i"; continue;
                        }
                    }
                    else if (i != len - 1)
                    {
                        if (n[i] == 0)
                        {
                            if (i + 2 <= len - 1 && n[i + 2] == 0 && n[i + 1] == 0) continue;
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 1)
                        {
                            rs += " " + ((n[i + 1] == 1 || n[i + 1] == 0) ? ch[n[i]] : rch[n[i]]);
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 5) 
                        {
                            if (n[i + 1] != 0) 
                            {
                                rs += " " + rch[n[i]];
                                rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                                continue;
                            }
                        }
                    }

                    rs += (rs == "" ? " " : ", ") + ch[n[i]];
                    rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                }
              
                if (rs.Length > 2)
                {
                    string rs1 = rs.Substring(0, 2);
                    rs1 = rs1.ToUpper();
                    rs = rs.Substring(2);
                    rs = rs1 + rs;
                }
                return rs.Trim().Replace("l?,", "l?").Replace("m??i,", "m??i").Replace("tr?m,", "tr?m").Replace("m??i,", "m??i");
            }
            catch
            {
                return "";
            }

        }
        #endregion

        static void Main(string[] args)
        {
           
        
            using (StreamReader myFile = new StreamReader(fileInput))
            {
               
                line = myFile.ReadLine();           
                int total = int.Parse(line);                               
                using (StreamWriter outFile=new StreamWriter(fileOutput))
                {                  
                        outFile.WriteLine(NumberToTextVN(total));                  
                }
              
            }
        }
    }
}

