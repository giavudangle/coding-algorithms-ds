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
        static void QuickSort(int[] a, int L, int R)
        {
            int i, j, x;
            i = L;
            j = R;
            x = a[(L + R) / 2];
            while (i < j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (L < j)
                QuickSort(a, L, j);
            if (R > i)
                QuickSort(a, i, R);
        }
        
        static void Main(string[] args)
        {
            string[] tokens;
            string line;         
            int[] a;
            int n;
            using (StreamReader myFile = new StreamReader("E:\\INP.txt"))
            {
                line = myFile.ReadLine();
                n = Convert.ToInt32(line);
                a = new int[n];
                line = myFile.ReadLine();
                tokens = line.Split(' ');
                for (int i = 0; i < n; i++) a[i] = Convert.ToInt32(tokens[i]);
               
               
            }
            QuickSort(a, 0, a.Length - 1);

            using (StreamWriter outFile = new StreamWriter("E:\\OUT.txt"))
            {
                for (int i = 0; i < n; i++) outFile.Write("{0} ", a[i]);
            }

        }
    }
}
