/*
 * Title: Binary Search Stree C# Implementation - Class MyBinaryTree
 * Author : Dang Le Gia Vu
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create Binary Tree
            Console.ForegroundColor = ConsoleColor.Green;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            MyBinaryTree<int> myTree = new MyBinaryTree<int>();
            //MyBinaryTree<char> myTree = new MyBinaryTree<char>();
            //MyBinaryTree<string> myTree = new MyBinaryTree<string>();
            //MyBinaryTree<double> myTree = new MyBinaryTree<double>();
            #endregion

            #region Insert Mock Data


            //myTree.Insert(25);
            //myTree.Insert(19);
            //myTree.Insert(29);
            //myTree.Insert(17);
            //myTree.Insert(20);
            //myTree.Insert(27);
            //myTree.Insert(55);


            //myTree.Insert(1);
            //myTree.Insert(2);
            //myTree.Insert(3);
            //myTree.Insert(4);
            //myTree.Insert(5);
            //myTree.Insert(6);

            //myTree.Insert('H');
            //myTree.Insert('B');
            //myTree.Insert('C');
            //myTree.Insert('A');
            //myTree.Insert('E');
            //myTree.Insert('D');
            //myTree.Insert('Z');
            //myTree.Insert('M');
            //myTree.Insert('P');
            //myTree.Insert('T');

            //myTree.Insert("Huế");
            //myTree.Insert("Đà Nẵng");
            //myTree.Insert("Hà Nội");
            //myTree.Insert("Vĩnh Long");
            //myTree.Insert("Cần Thơ");
            //myTree.Insert("Sóc Trăng");
            //myTree.Insert("Nha Trang");
            //myTree.Insert("Đồng Nai");
            //myTree.Insert("Vũng Tàu");
            //myTree.Insert("An Giang");
            //myTree.Insert("Tiền Giang");
            //myTree.Insert("Bình Dương");
            //myTree.Insert("Hải Dương");


            //myTree.Insert(1.5);
            //myTree.Insert(1.1); 
            //myTree.Insert(2.1);
            //myTree.Insert(2.2);
            //myTree.Insert(1.4);
            #endregion

            #region Properties Call
            //Console.WriteLine(myTree.LeafCount);
            //Console.WriteLine(myTree.Height);
            #endregion

            #region Method On Binary Search Tree
            /* Thêm Node vào Cây */
            myTree.Insert(25);
            myTree.Insert(15);
            myTree.Insert(50);
            myTree.Insert(10);
            myTree.Insert(22);
            myTree.Insert(35);
            myTree.Insert(70);
            myTree.Insert(4);
            myTree.Insert(12);
            myTree.Insert(18);
            myTree.Insert(24);
            myTree.Insert(31);
            myTree.Insert(44);
            myTree.Insert(66);
            myTree.Insert(90);


            /* Duyệt cây */
            //Console.Write("NLR: ");
            //myTree.PreOrder();
            //Console.WriteLine();

            //Console.Write("LNR: ");
            //myTree.InOrder();
            //Console.WriteLine();

            //Console.Write("LRN: ");
            //myTree.PostOrder();
            //Console.WriteLine();

            /* Tìm Node có trong cây không ? */
            //MyTNode<int> node = new MyTNode<int>(15);
            //node = myTree.SearchNode(15);
            //if (node != null)
            //{
            //    Console.WriteLine("FOUND");
            //    Console.WriteLine(node.Data);
            //}
            //else
            //    Console.WriteLine("NOT FOUND");

            /* Min Max Node của cây */
            //MyTNode<int> maxNode = new MyTNode<int>();
            //MyTNode<int> minNode = new MyTNode<int>();
            //maxNode = myTree.MaxNode();
            //minNode = myTree.MinNode();
            //if (maxNode != null)
            //    Console.WriteLine("Max Node -> " + maxNode.Data);
            //else
            //    Console.WriteLine("Node is NULL");

            //if (minNode != null)
            //    Console.WriteLine("Min Node -> " + minNode.Data);
            //else
            //    Console.WriteLine("Node is NULL");

            /* Xóa Node trong cây */
            //myTree.Remove(90);
            //Console.Write("NLR: ");
            //myTree.PreOrder();
            //Console.WriteLine();

            /* 2 */
            //myTree.printGivenLevel(myTree.Root,3); // template
            //myTree.ListByLevel();
            //myTree.ListLastLevel();
            #endregion
        }
    }
}
