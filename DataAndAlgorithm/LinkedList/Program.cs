using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create Instance
            // Create instance mylist for class MyList
            MyList mylist = new MyList();
            // Create a node for 2 methods: Add First & Add Last
            IntNode node = new IntNode(100);
            // Create a nodeX for  method : FindX()
            IntNode nodeX = new IntNode(20);
            // Methods Implementation
            #endregion

            #region Methods Implementation Linked List Part 1
            /*

            mylist.AddFirst(node);
            mylist.AddLast(node);
            mylist.Input();
            mylist.ShowList();
            if (mylist.FindX(nodeX))
                Console.WriteLine("X in list");
            else
                Console.WriteLine("X not in list");

            mylist.FindX(nodeX);

            IntNode x = myList.GetMax();
            IntNode y = myList.GetMin();
            Console.WriteLine(x.Data);
            Console.WriteLine(y.Data);

            mylist.GetOddList();
            mylist.GetEvenList();
            mylist.Input();
            mylist.Sort();
            mylist.ShowList();
            */


            #endregion

            #region Linked List Part 2
            MyList myList = new MyList();
            myList.Input();
            myList.ShowList();
            //myList.InsertAfterMin(100);
            myList.InsertXAfterY(99,4);
            //myList.InsertBeforeMax(55);
            myList.ShowList();
            ////myList.RemoveAt(3);
            //// myList.RemoveX(5);
            //myList.InsertAt(100, 2);
            //myList.ShowList();




            #endregion




        }
    }
}
