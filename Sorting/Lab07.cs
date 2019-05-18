using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Created by Chicken_Coder
namespace ConsoleApp3
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

        static int BinarySearch(int[]a,int l,int r,int key)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (a[mid] == key) return mid;
                if (a[mid] > key) BinarySearch(a, l, mid - 1, key);
                return BinarySearch(a, mid + 1, r, key);
            }

            return -1;
        }

        static bool Processing(int[]a)
        {
            QuickSort(a, 0, a.Length - 1);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0) return false;
                if (BinarySearch(a, i, a.Length-1, -a[i]) != -1) return true;  
            }
            return false;
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

            using (StreamWriter outFile=new StreamWriter("E:\\OUT.txt"))
            {
                if (Processing(a)) outFile.Write("Yes");
                else outFile.Write("No");
            }
        }
    }
}
