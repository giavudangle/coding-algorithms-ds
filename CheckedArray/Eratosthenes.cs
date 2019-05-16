using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Created by Chicken_Coder

namespace LAB03_Eratosthenes
{
    class Eratosthenes
    {
        static int n;
        static string line;
      
        public static bool[] Eratos()
        {
            bool[] status = new bool[n + 1];
            for (int i = 0; i < status.Length; i++) status[i] = true;
            status[0] = status[1] = false;
            for (int i = 2; i * i <= n; i++)
            {
                if (status[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        status[j] = false;
                    }
                }
            }
            return status;    
        }

        static void Main(string[] args)
        {
            using (StreamReader myFile = new StreamReader("E:\\INP.txt"))
            {
                line = myFile.ReadLine();
                n = Convert.ToInt32(line);              
            }

            bool[] status = Eratos();
      
            using (StreamWriter outFile = new StreamWriter("E:\\OUT.txt"))
            {   
                for (int i=2;i<=n;i++)
                    outFile.Write((status[i]) ? (i + " ") : "");
            }
        }
    }
}
