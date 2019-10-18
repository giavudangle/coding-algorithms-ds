using System;
using System.Collections.Generic;
using System.Text;

namespace Structures
{
    class IntArray
    {
        // Declare member fields
        private int[] arr;
        // Property

        public int Arr_Length
        {
            get { return arr.Length; }
        }

        // Constructor
        public IntArray()
        {
            
        }

        public IntArray(int k)
        {
            arr = new int[k];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)        
                arr[i] = random.Next(0,1000);
            //Array.Sort(arr); Use for Exercise 1 (Ascending Array for Search Mehthods)
            //If you want use it,delete top comment;
        }

        public IntArray(int[] b)
        {
            int b_size = b.Length;
            arr = new int[b_size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = b[i];
            }
        }

        public IntArray(IntArray obj)
        {
            // Arr_Length is properties for return length of array;
            int s = obj.arr.Length;        
            arr = new int[s];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = obj.arr[i];
        }

        public void Nhap()
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }



        // Searching 

        public int LinearSearch(int x)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == x)
                    return i;
            return -1;
        }

        public int BinarySearch(int x)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                if (arr[m] == x)
                    return m;
                if (arr[m] < x)
                    l = m + 1;
                else
                    r = m - 1;
            }           
            return -1;
        }

        // Sorting

        // Interchange Sort
        public void InterchangeSort()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        // Insertion Sort
        public void InsertionSort()
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        // Quick Sort
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
            Sort(arr,0,arr.Length-1);
        }      

        // Shell Sort
        public void ShellSort()
        {
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i+=1)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j-gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
        }

        // Shaker Sort
        public void ShakerSort()
        {
            int l = 0;
            int r = arr.Length - 1;
            int k = 0;
            while (l < r)
            {
                for (int i = l; i < r; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i + 1] = temp;
                        k = i;
                    }
                }
                r = k;
                for (int i = r; i > l; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        k = i;
                    }
                }
                l = k;
                           
            }
        }

        // Merge Sort
        public void MergeSort()
        {
            void Merge(int[] arr, int left, int middle, int right)
            {
                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(arr, left, leftArray, 0, middle - left + 1);
                Array.Copy(arr, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        arr[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        arr[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        arr[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = rightArray[j];
                        j++;
                    }
                }
            }

            void SortCon(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int middle = (left + right) / 2;

                    SortCon(arr, left, middle);
                    SortCon(arr, middle + 1, right);

                    Merge(arr, left, middle, right);
                }
            }
            SortCon(arr,0,arr.Length-1);
        }

    }
}
