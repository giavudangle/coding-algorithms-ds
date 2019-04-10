using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_02
{
    class LAB_02
    {
        static int n, x;
        static int []a;
        static string line;
        static string[] tokens;
        static void Input()
        {
            using (StreamReader iFile = new StreamReader("D:\\INP.txt"))
            {
                line = iFile.ReadLine();
                tokens = line.Split(' ');
                n = Convert.ToInt32(tokens[0]);
                x = Convert.ToInt32(tokens[1]);
                line = iFile.ReadLine();
                tokens = line.Split(' ');
                a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = Convert.ToInt32(tokens[i]);
                }
                iFile.Close();
            }
        }

        static bool Checking()
        {
            for(int i=0;i<n; i++)       
                if (a[i] == x)
                    return true;           
            return false;
        }

        static void Output()
        {
            using (StreamWriter oFile = new StreamWriter("D:\\OUT.txt"))
            {
                oFile.Write(Checking() ? "YES" : "NO");             
            }
        }
        static void Main(string[]args)
        {
            Input();
            Checking();
            Output();
        }
    }
}
