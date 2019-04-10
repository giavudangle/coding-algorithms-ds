using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        
        static string[] tokens;
        static string line;


        public static int Checking(int[] a,int n)
        {
            bool[] mark = new bool[n + 2];
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0 || a[i] > n + 1) continue;
                mark[a[i]] = true;
            }
            for (int i = 1; i < mark.Length; i++)           
                if (!mark[i]) return i;         
            return 0;
        }

        static void Main(string[] args)
        {
            using (StreamReader myFile=new StreamReader("E:\\INP.txt"))
            {
                
                line = myFile.ReadLine();
                int n = Convert.ToInt32(line);
                int[] a = new int[n];
                line = myFile.ReadLine();
                tokens = line.Split(' ');
                for (int i = 0; i < n; i++)
                    a[i] = Convert.ToInt32(tokens[i]);
                using (StreamWriter outFile = new StreamWriter("E:\\OUT.txt"))
                {
                    outFile.WriteLine(Checking(a, n));
                }
            }                 
        }
    }
}
