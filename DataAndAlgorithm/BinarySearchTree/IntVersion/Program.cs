/*
 * Title: Binary Search Stree C# Implementation ( Int Version ) - Class Program
 * Author : Dang Le Gia Vu
 * Generics Version available on -> https://github.com/giavudangle
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create Instance - Input - Insert - Properties
            // Create New Instace of Class MyBinaryTree
            MyBinaryTree myTree = new MyBinaryTree();

            //Input
            //myTree.Input();
            //Insert 
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

            // Test 2 properties
            Console.WriteLine("Count: {0} ", myTree.Count);
            Console.WriteLine("Height: {0}", myTree.Height);

            #endregion

            #region Method - Exer 4 & 5

            /* Duyệt cây */
            //Console.Write("LNR: ");
            //myTree.InOrder();
            //Console.WriteLine();

            //Console.Write("NLR: ");
            //myTree.PreOrder();
            //Console.WriteLine();

            //Console.Write("LRN: ");
            //myTree.PostOrder();
            //Console.WriteLine();

            //// Số lượng lá trong cây
            //Console.WriteLine("Number Of Leafs In Tree: {0}",myTree.CountLeaf(myTree.Root));
            //// In ra các giá trị của node theo từng mức
            //myTree.ListByLevel();
            //// In ra các giá trị của node ở mức cuối cùng của cây
            //myTree.ListLastLevel();

            /* _________________________BUỔI 5 ___________________*/

            /*Tìm Node có trong cây không ? */
            //MyNode node = new MyNode(10);
            //MyNode temp = new MyNode();
            //temp = myTree.SearchNode(node.Data);
            //if (temp!=null )
            //    Console.WriteLine("FOUND " + temp.Data);
            //else
            //    Console.WriteLine("NOT FOUND");

            /* Min-Max Node của cây */
            //MyNode maxNode = new MyNode();
            //MyNode minNode = new MyNode();
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
            //myTree.Remove(25);
            //Console.Write("NLR: ");
            //myTree.PreOrder();
            //Console.WriteLine();

            #endregion
        }
    }
}
