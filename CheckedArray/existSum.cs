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

        public static bool[] existSum(int[]a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++) sum += a[i];

            bool[] status = new bool[sum +1];
            status[a[0]] = true;
       

            for (int i = 1; i < a.Length; i++)
            {
                for (int j = sum; j >= 0; j--)
                    if (status[j] == true)
                        if (j + a[i] <= sum && status[j + a[i]] == false)                     
                            status[j + a[i]] = true;                                           
                if (status[a[i]] == false)
                    status[a[i]] = true;
                
               // 2 3 4 
              // 11 10 9 8 7 6 5 4 3 2 1
            }           
            return status;
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

                bool[] status = existSum(a);

                int count = 0;

                for (int i = 0; i < status.Length; i++)
                    if (status[i] == true) count++;

                using (StreamWriter outFile=new StreamWriter("E:\\OUT.txt"))
                {
                    outFile.WriteLine(count);
                    for (int i = 0; i < status.Length; i++)
                        if (status[i] == true) outFile.Write(i + " ");
                }
                

            }                 
        }
    }
}
