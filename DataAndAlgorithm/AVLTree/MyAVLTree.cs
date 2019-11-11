using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAVLTree
{
    class MyAVLTree
    {
        public MyAVLNode root;
        public int count;
        public int height;

        public int Count { get => count; set => count = value; }
        public int Height { get => height=getHeight(root); set => height = value; }
        public MyAVLNode Root { get => root; set => root = value; }

        public void Add(int data)
        {
            
            MyAVLNode newItem = new MyAVLNode(data);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                root = RecursiveInsert(root, newItem);
            }
        }

        public void Input()
        {
            Console.Write("Enter number nodes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int e = int.Parse(Console.ReadLine());
                Add(e);

            }
        }

        private MyAVLNode RecursiveInsert(MyAVLNode current, MyAVLNode n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (n.data < current.data)
            {
                current.left = RecursiveInsert(current.left, n);
                current = balance_tree(current);
            }
            else if (n.data > current.data)
            {
                current.right = RecursiveInsert(current.right, n);
                current = balance_tree(current);
            }
            return current;
        }
        private MyAVLNode balance_tree(MyAVLNode current)
        {
            int b_factor = balance_factor(current);
            if (b_factor > 1)
            {
                if (balance_factor(current.left) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (balance_factor(current.right) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }
        public void Delete(int target)
        {
            root = Delete(root, target);
        }
        private MyAVLNode Delete(MyAVLNode current, int target)
        {
            MyAVLNode parent;
            if (current == null)
            { return null; }
            else
            {
                //left subtree
                if (target < current.data)
                {
                    current.left = Delete(current.left, target);
                    if (balance_factor(current) == -2)//here
                    {
                        if (balance_factor(current.right) <= 0)
                        {
                            current = RotateRR(current);
                        }
                        else
                        {
                            current = RotateRL(current);
                        }
                    }
                }
                //right subtree
                else if (target > current.data)
                {
                    current.right = Delete(current.right, target);
                    if (balance_factor(current) == 2)
                    {
                        if (balance_factor(current.left) >= 0)
                        {
                            current = RotateLL(current);
                        }
                        else
                        {
                            current = RotateLR(current);
                        }
                    }
                }
                //if target is found
                else
                {
                    if (current.right != null)
                    {
                        //delete its inorder successor
                        parent = current.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        current.data = parent.data;
                        current.right = Delete(current.right, parent.data);
                        if (balance_factor(current) == 2)//rebalancing
                        {
                            if (balance_factor(current.left) >= 0)
                            {
                                current = RotateLL(current);
                            }
                            else { current = RotateLR(current); }
                        }
                    }
                    else
                    {   //if current.left != null
                        return current.left;
                    }
                }
            }
            return current;
        }
        public void Find(int key)
        {
            if (Find(key, root).data == key)
            {
                Console.WriteLine("{0} was found!", key);
            }
            else
            {
                Console.WriteLine("Nothing found!");
            }
        }
        private MyAVLNode Find(int target, MyAVLNode current)
        {

            if (target < current.data)
            {
                if (target == current.data)
                {
                    return current;
                }
                else
                    return Find(target, current.left);
            }
            else
            {
                if (target == current.data)
                {
                    return current;
                }
                else
                    return Find(target, current.right);
            }

        }
        public void LNR()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            InOrderDisplayTree(root);
            Console.WriteLine();
        }

        public void NLR()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            PreOrderDisplayTree(root);
            Console.WriteLine();
        }

        public void LRN()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            PostOrderDisplayTree(root);
            Console.WriteLine();
        }


        private void InOrderDisplayTree(MyAVLNode current)
        {
            if (current != null)
            {
                InOrderDisplayTree(current.left);
                Console.Write("{0} ", current.data);
                InOrderDisplayTree(current.right);
            }
        }

        private void PreOrderDisplayTree(MyAVLNode current)
        {
            if (current != null)
            {
                Console.Write("{0} ", current.data);
                PreOrderDisplayTree(current.left);
                PreOrderDisplayTree(current.right);
            }
        }

        private void PostOrderDisplayTree(MyAVLNode current)
        {
            if (current != null)
            {             
                PostOrderDisplayTree(current.left);
                PostOrderDisplayTree(current.right);
                Console.Write("{0} ", current.data);
            }
        }


        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        private int getHeight(MyAVLNode current)
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }
        private int balance_factor(MyAVLNode current)
        {
            int l = getHeight(current.left);
            int r = getHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }
        private MyAVLNode RotateRR(MyAVLNode parent)
        {
            MyAVLNode pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }
        private MyAVLNode RotateLL(MyAVLNode parent)
        {
            MyAVLNode pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }
        private MyAVLNode RotateLR(MyAVLNode parent)
        {
            MyAVLNode pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private MyAVLNode RotateRL(MyAVLNode parent)
        {
            MyAVLNode pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }
    }

}
