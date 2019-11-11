/*
 * Title: AVL  Tree C# Implementation ( Int Version ) - Class Progam
 * Author : Dang Le Gia Vu
 * Generics Version available on -> https://github.com/giavudangle
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAVLTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAVLTree tree = new MyAVLTree();
            tree.Add(9);
            tree.Add(5);
            tree.Add(10);
            tree.Add(0);
            tree.Add(6);
            tree.Add(11);
            tree.Add(-1);
            tree.Add(1);
            tree.Add(2);

            //tree.Input();
            Console.WriteLine("Height of Tree: " + tree.Height);

            /* The constructed AVL Tree would be  
                                     9
                                   /   \
                                  1     10
                                 / \      \
                                0   5      11
                               /   / \
                             -1   2   6

             */

            tree.Delete(5);

            Console.Write("LNR:");
            tree.LNR();
            Console.WriteLine();

            Console.Write("NLR:");
            tree.NLR();
            Console.WriteLine();

            Console.Write("LRN:");
            tree.LRN();
            Console.WriteLine();




        }
    }
}
