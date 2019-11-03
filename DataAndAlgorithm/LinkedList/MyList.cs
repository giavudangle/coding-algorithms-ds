using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class MyList
    {
        private IntNode first = null;
        private IntNode last = null;
        private int Length = 0;
        public IntNode First
        {
            get => first;
            set => first = value;
        }

        public IntNode Last
        {
            get => last;
            set => last = value;
        }

        public int Count
        {
            get => Length;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
            {
                first = last = newNode;
            }
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }

        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
            {
                first = last = newNode;
            }
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }

        public void Input()
        {
            int x;
            do
            {
                Console.Write("Enter new Node: (-1 exit): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x < 0)
                    break;
                else
                {
                    IntNode newNode = new IntNode(x);
                    Length++;
                    //AddFirst(newNode); Delete comment if use want to list reverse
                    AddLast(newNode);

                }
            } while (true);
        }

        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write(p.Data + " -> ");
                p = p.Next;
            }
            Console.WriteLine("NULL");
        }

        public bool FindX(IntNode x)
        {

            for (IntNode temp = first; temp != null; temp = temp.Next)
            {
                if (temp.Data == x.Data)
                {
                    return true;
                }
            }
            return false;
        }

        public IntNode GetMax()
        {
            IntNode maxNode = new IntNode();
            maxNode = first;

            for (IntNode pointer = first; pointer != null; pointer = pointer.Next)
            {
                if (pointer.Data >= maxNode.Data)
                {
                    maxNode = pointer;
                }
            }
            return maxNode;
        }

        public IntNode GetMin()
        {
            IntNode minNode = new IntNode();
            minNode = first;

            for (IntNode pointer = first; pointer != null; pointer = pointer.Next)
            {
                if (pointer.Data <= minNode.Data)
                {
                    minNode = pointer;
                }
            }
            return minNode;
        }

        public void GetEvenList()
        {

            for (IntNode pointer = first; pointer != null; pointer = pointer.Next)
            {
                if (pointer.Data % 2 == 0)
                {
                    Console.Write(pointer.Data + " -> ");
                }
            }
            Console.WriteLine("NULL");
        }

        public void GetOddList()
        {
            for (IntNode pointer = first; pointer != null; pointer = pointer.Next)
            {
                if (pointer.Data % 2 != 0)
                {
                    Console.Write(pointer.Data + " -> ");
                }
            }
            Console.WriteLine("NULL");
        }

        public void Sort()
        {
            IntNode p = first;
            while (p != null)
            {
                if (p.Next == null)
                {
                    break;
                }

                else if (p.Data > p.Next.Data)
                {
                    int temp = p.Data;
                    p.Data = p.Next.Data;
                    p.Next.Data = temp;
                }

                p = p.Next;
            }

        }

        // Exercise 4 - Linked List Next
        public void RemoveAt(int position)
        {
            IntNode head = first;
            if (head == null)
                return;

            IntNode temp = head;

            if (position == 0)
            {
                head = temp.Next;
                return;
            }

            for (int i = 0; temp != null && i < position - 1; i++)
                temp = temp.Next;

            if (temp == null || temp.Next == null)
                return;
            IntNode next = temp.Next.Next;

            temp.Next = next;
        }

        public void RemoveX(int x)
        {
            IntNode temp = first, prev = null;

            if (temp != null && temp.Data == x)
            {
                first = temp.Next;
                return;
            }

            while (temp != null && temp.Data != x)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (temp == null) return;
            prev.Next = temp.Next;

        }


        public void InsertAt(int x, int pos)
        {
            IntNode node = new IntNode();
            node.Data = x;
            node.Next = null;


            if (first == null)
            {
                if (pos != 0)
                    return;
                else
                    first = node;
            }

            if (first != null && pos == 0)
            {
                node.Next = first;
                first = node;
                return;
            }

            IntNode current = first;
            IntNode previous = null;

            int i = 0;
            while (i < pos)
            {
                previous = current;
                current = current.Next;
                if (current == null)
                    break;
                i++;
            }

            node.Next = current;
            previous.Next = node;

        }

        public void InsertAfterMin(int z)
        {
           
            IntNode temp = GetMin();
            IntNode x = temp.Next;

            IntNode needInsert = new IntNode(z);

            temp.Next = needInsert;
            temp.Next.Next=x;
        }

        public void InsertXAfterY(int x,int y)
        {
            int pos = 0;
            for (IntNode temp = first; temp != null; temp = temp.Next)
            {
                pos++;
                if (temp.Data == y)
                {
                    break;
                }
            }
            InsertAt(x, pos);
        }

        public void InsertBeforeMax(int x)
        {

            IntNode maxNode = GetMax();
            IntNode prev = null;
            IntNode head = first;
            IntNode newNode = new IntNode(x);

            
            bool flag = false;
            while (head.Data != maxNode.Data)
            {
                flag = true;
                prev = head;
                head = head.Next;
            }
            if (flag)
            {
                prev.Next = newNode;
                prev.Next.Next = head;
            }
            else
                AddFirst(newNode);
                              
        }

        public void InsextXBeforeY(int x, int y)
        {
            int pos = 0;
            for (IntNode temp = first; temp != null; temp = temp.Next)
            {
                pos++;
                if (temp.Data == y)
                {
                    break;
                }
            }
            InsertAt(x, pos);
        }


    }
}
