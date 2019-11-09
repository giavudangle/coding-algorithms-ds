using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKT
{
    class Program
    {
        static void Main(string[] args)
        {
            // * Set 1:
            //SinhVien a = new SinhVien(1, "Gia Vu", 22, "Software", "IT");
            //SinhVien b = new SinhVien(1, "PMT", 12, "Hardware", "IT");
            //SinhVien c = new SinhVien(1, "Gia Vu", 2, "Embedded", "IT");

            //MyStack<SinhVien> myStack = new MyStack<SinhVien>(3);
            //myStack.Push(a);
            //myStack.Push(b);
            //myStack.Push(c);

            //SinhVien res = new SinhVien();
            //SinhVien temp = new SinhVien();
            //res = myStack.Pop();
            //temp = myStack.Peek();
            //res.Print();
            //Console.WriteLine("_______________________");
            //temp.Print();

            // * Set 2:
            IntArray a = new IntArray();
            a.Input();
            a.QuickSort();
            a.Output();

        }
    }
}
