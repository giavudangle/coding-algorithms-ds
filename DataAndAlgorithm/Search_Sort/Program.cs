using System;
using System.Collections.Generic;

namespace Structures
{
    class Program
    {
        static void TestInterchangeSort(IntArray obj)
        {
            IntArray objTest = new IntArray(obj);
            Console.WriteLine("Before Array: ");
            objTest.Xuat();
            objTest.InterchangeSort();
            Console.WriteLine("Interchange Sort: ");
            objTest.Xuat();
        }

        static void TestInsertionSort(IntArray obj)
        {
            IntArray objTest = new IntArray(obj);
            Console.WriteLine("Before Array: ");
            objTest.Xuat();
            objTest.InsertionSort();
            Console.WriteLine("InsertionSort Sort: ");
            objTest.Xuat();
        }

        static void TestQuickSort(IntArray obj)
        {
            IntArray objTest = new IntArray(obj);
            Console.WriteLine("Before Array: ");
            objTest.Xuat();
            objTest.QuickSort();
            Console.WriteLine("Quick Sort: ");      
            objTest.Xuat();
        }

        static void TestShellSort(IntArray obj)
        {
            IntArray objTest = new IntArray(obj);
            Console.WriteLine("Before Array: ");
            objTest.Xuat();
            objTest.ShellSort();
            Console.WriteLine("ShellSort Sort: ");
            objTest.Xuat();
        }
        static void TestShakerSort(IntArray obj)
        {
            IntArray objTest = new IntArray(obj);
            Console.WriteLine("Before Array: ");
            objTest.Xuat();
            objTest.ShakerSort();
            Console.WriteLine("ShakerSort Sort: ");
            objTest.Xuat();
        }

        static void TestMergeSort(IntArray obj)
        {
            IntArray objTest = new IntArray(obj);
            Console.WriteLine("Before Array: ");
            objTest.Xuat();
            objTest.MergeSort();
            Console.WriteLine("MergeSort Sort: ");
            objTest.Xuat();
        }
        static void Main(string[] args)
        {
            /* BUOI 1-2 

            // 1
            IntArray objA = new IntArray(10);
            // 2
            objA.Xuat();
            // 3
            int x = int.Parse(Console.ReadLine());
            if (objA.LinearSearch(x) != -1)
                Console.WriteLine("Found");
            else Console.WriteLine("Not Found");
            // 4
            IntArray objB = new IntArray(8);
            // 5
            //int x = int.Parse(Console.ReadLine());
            if (objA.BinarySearch(x) != -1)
                Console.WriteLine("Found");
            else Console.WriteLine("Not Found");
            // 6 On paper 

            */

            /* Buoi 3 */
            IntArray obj = new IntArray(10);

            //TestInterchangeSort(obj);
            //TestInsertionSort(obj);
            //TestQuickSort(obj);
            //TestShellSort(obj);
            //TestShakerSort(obj);
            TestMergeSort(obj);
        }     
    }
}
