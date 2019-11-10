/*
 * Title: Binary Search Stree C# Implementation ( Int Version ) - Class MyBinaryTree
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
    class MyBinaryTree
    {
        MyNode root = null;
        private int height = 0;
        private int length = 0;

        public int Count { get => length+1; }
        public int Height { get => height = HeightTree(); }
        public int LeafCount { get => CountLeaf(root); }
        public MyNode Root
        {
            get { return root; }
            set { root = value; }
        }
       
        public bool Insert(int x)
        {
            if (root == null)
            {
                root = new MyNode(x);
                return true;
            }
            else
            {
                if (root.InsertData(x))
                {
                    length++;
                    return true;

                }
            }
            return false;
        }

        public void Input()
        {
            Console.Write("Enter number of nodes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                bool flag = false;
                int x = int.Parse(Console.ReadLine());
                if (root == null)
                {
                    root = new MyNode(x);
                    flag = true;
                    continue;
                }
                else
                {
                    if (root.InsertData(x))
                    {
                        length++;
                        flag=true;
                    }
                }
            }
          
        }

        public void PreOrder()
        {
            if (root == null)
                return;
            root.NLR();
        }

        public void InOrder()
        {
            if (root == null)
                return;
            root.LNR();
        }

        public void PostOrder()
        {
            if (root == null)
                return;
            root.LRN();
        }

        public MyNode SearchNode(int x)
        {
            if (root == null)
                return null;
            return root.SearchX(x);
        }

        public MyNode MaxNode()
        {
            if (root == null)
                return null;
            return root.RightMost();
        }

        public MyNode MinNode()
        {
            if (root == null)
                return null;
            return root.LeftLeast();
        }

        public bool Remove(int x)
        {
            if (root == null)
                return false;

            if (x.CompareTo(root.Data) == 0)
            {
                MyNode tmp = new MyNode();
                tmp.leftChild = root;
                bool res = root.Remove(x, tmp);
                root = tmp.leftChild;
                return res;
            }
            return root.Remove(x, null);
        }

        public int HeightTree()
        {
            return root.TreeHeight();
        }

        public int CountLeaf(MyNode node)
        {
            if (node == null)
                return 0;
            if (node.leftChild == null && node.rightChild == null)
                return 1;
            else
                return CountLeaf(node.leftChild) + CountLeaf(node.rightChild);
        }

        // Template for 2 methods down.
        public int printGivenLevel(MyNode root, int level)
        {
            if (root == null)
                return 0;
            if (level == 1)
                Console.Write(root.Data + " ");
            else if (level > 1)
            {
                printGivenLevel(root.leftChild, level - 1);
                printGivenLevel(root.rightChild, level - 1);
            }
            return 0;
        }

        public void ListByLevel()
        {
            int h = Height;
            int i;
            for (i = 1; i <= h; i++)
            {
                Console.Write("Level {0} -> Data: ", i);
                printGivenLevel(root, i);
                Console.WriteLine();

            }
        }

        public void ListLastLevel()
        {
            Console.Write("List Last Level: ");
            printGivenLevel(root, Height);
        }
    }
}
