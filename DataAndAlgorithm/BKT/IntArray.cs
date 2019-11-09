using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKT
{
    class IntArray
    {
        // Declare all variables member
        private int[] a;
        private int n;

        // Constructor
        public IntArray()
        {

        }

        // Method
        public void Input()
        {
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());                
        }

        // Output
        public void Output()
        {
            foreach(int x in a) Console.Write(x + " ");          
        }

        public void QuickSort()
        {
            void Sort(int[] arr, int L, int R)
            {
                int i, j, x;
                i = L;
                j = R;
                x = arr[(L + R) / 2];
                while (i < j)
                {
                    while (arr[i] < x) i++;
                    while (arr[j] > x) j--;
                    if (i <= j)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        i++;
                        j--;
                    }
                    if (L < j)
                        Sort(arr, L, j);
                    if (R > i)
                        Sort(arr, i, R);
                }

            }
            Sort(a, 0, a.Length - 1);
        }





    }
}
