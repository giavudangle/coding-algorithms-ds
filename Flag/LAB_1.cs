using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_1
{
    class LAB_1
    {

        static int[] a;
        static int count;
        static double avg;
        static int elements;

        static void Input()
        {
            using (StreamReader iFile = new StreamReader("D:\\INP.txt"))
            {
                count = 0;
                string line;      
                while ((line = iFile.ReadLine()) != null) count++;     
                iFile.Close();
            }
            using (StreamReader iFile = new StreamReader("D:\\OUT.txt"))
            {
                a = new int[t];
                string[] segment = new string[t];
                for (int i = 0; i < t; i++)
                {
                    segment[i] = iFile.ReadLine();
                }
                for (int i = 0; i < t; i++)
                {
                    a[i] = Convert.ToInt32(segment[i]);
                }
                iFile.Close();
            }
        }
        static void Processing()
        {
            elemetns = 0;
            int sum = 0;
            for (int i = 0; i < t; i++)
            {
                if (a[i] != -1)
                {
                    elemetns++;
                    sum += a[i];
                }
                else break;
            }

            avg = sum / elemetns;

        }
        static void Output()
        {
            using (StreamWriter oFile = new StreamWriter("D:\\OUT.txt"))
            {
                oFile.WriteLine(elements);
                oFile.WriteLine("{0:0.00}", avg);
                oFile.Close();
            }
        }
        static void Main(string[] args)
        {
            Input();
            Processing();
            Output();        
        }
    }
}

