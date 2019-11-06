using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    // Create node need define what's T. T is ICompareble<T>
    public class MyBinaryTree<T> where T : IComparable<T>
    {
        MyTNode<T> root = null;

        private int length = 0;
        private int height = 0;

        public int Length { get => length+1; }   
        public int Height { get => height = HeightTree(); }
        public virtual int LeafCount { get => CountLeaf(root); }


        public int HeightTree()
        {
            return root.TreeHeight();
        }
        
        public MyTNode<T> Root
        {
            get => root;
            set => root = value;
        }
     
        public bool Insert(T x)
        {
            if (root == null)
            {
                root = new MyTNode<T>(x);
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
            // Chưa nghĩ ra cách Parse Data từ Generics
            // Chỉ định được kiểu dữ liệu làm dễ dàng.
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


        public MyTNode<T> SearchNode(T x)
        {
            if (root == null)
                return null;
            return root.SearchX(x);
        }

        public MyTNode<T> MaxNode()
        {
            if (root == null)
                return null;
            return root.RightMost();
        }

        public MyTNode<T> MinNode()
        {
            if (root == null)
                return null;
            return root.LeftLeast();
        }

        public bool Remove(T x)
        {
            if (root == null)
                return false;

            if (x.CompareTo(root.Data) == 0)
            {
                MyTNode<T> tmp = new MyTNode<T>();
                tmp.leftChild = root;           
                bool res = root.Remove(x, tmp);
                root = tmp.leftChild;
                return res;
            }                           
            return root.Remove(x, null);
        }

        public virtual int CountLeaf(MyTNode<T> node)
        {
            if (node == null)
                return 0;
            if (node.leftChild == null && node.rightChild == null)
                return 1;
            else
                return CountLeaf(node.leftChild) + CountLeaf(node.rightChild);
        }

       public void ListByLevel(MyTNode<T> node)
        {
           
            if (root == null)
                return;

            Queue<MyTNode<T>> q = new Queue<MyTNode<T>>(); 
            q.Enqueue(root);

            while (true)
            {             
                int nodeCount = q.Count;
                if (nodeCount == 0)
                    break;

                while (nodeCount > 0)
                {
                    MyTNode<T> e = q.Peek();
                    Console.Write(node.Data + " ");
                    q.Dequeue();
                    if (e.leftChild != null)
                        q.Enqueue(e.leftChild);
                    if (node.rightChild != null)
                        q.Enqueue(e.rightChild);
                    nodeCount--;
                }
                Console.WriteLine();
            }
        }

    }
}
