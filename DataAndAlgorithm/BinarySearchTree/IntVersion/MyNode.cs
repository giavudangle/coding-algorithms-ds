/*
 * Title: Binary Search Stree C# Implementation ( Int Version ) - Class MyNode
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
    class MyNode
    {
        // Fiedls
        private int data;
        private MyNode pLeft = null;
        private MyNode pRight = null;

        // Properties
        public int Data
        {
            get => data; 
            set => data = value; 
        }
     
        public MyNode leftChild
        {
            get => pLeft;
            set => pLeft = value; 
        }
    
        public MyNode rightChild
        {
            get => pRight; 
            set => pRight = value; 
        }

        // Constructor
        public MyNode(int x)
        {
            data = x;
            pLeft = null;
            pRight = null;
        }

        public MyNode()
        {

        }

        public int TreeHeight()
        {
            return 1 + Math.Max(
                pLeft != null ? pLeft.TreeHeight() : 0,
                pRight != null ? pRight.TreeHeight() : 0
            );
        }

        public bool InsertData(int x)
        {
            if (x.CompareTo(data) == 0)
                return false;
            if (x.CompareTo(data) < 0)
            {
                if (pLeft == null)
                    pLeft = new MyNode(x);
                else return pLeft.InsertData(x);
            }
            else
            {
                if (pRight == null)
                    pRight = new MyNode(x);
                else return pRight.InsertData(x);
            }
            return true;
        }

        public void NLR()
        {
            Console.Write(Data + " -> ");
            if (pLeft != null)
                pLeft.NLR();
            if (pRight != null)
                pRight.NLR();
        }

        public void LNR()
        {
            if (pLeft != null)
                pLeft.LNR();
            Console.Write(Data + " -> ");
            if (pRight != null)
                pRight.LNR();
        }

        public void LRN()
        {
            if (pLeft != null)
                pLeft.LRN();
            if (pRight != null)
                pRight.LRN();
            Console.Write(Data + " -> ");
        }

        public MyNode SearchX(int x)
        {
            if (x.CompareTo(data) == 0)
                return this;
            if (x.CompareTo(data) < 0)
            {
                if (pLeft == null)
                    return null;
                return pLeft.SearchX(x);
            }
            else
            {
                if (pRight == null)
                    return null;
                return pRight.SearchX(x);
            }
        }

        public MyNode RightMost()
        {
            if (pRight == null)
                return this;
            return pRight.RightMost();
        }

        public MyNode LeftLeast()
        {
            if (pLeft == null)
                return this;
            return pLeft.LeftLeast();
        }

        public int MinValue()
        {
            if (pLeft == null)
                return data;
            return pLeft.MinValue();
        }

        public bool Remove(int x, MyNode parent)
        {
            if (x.CompareTo(data) < 0)
            {
                if (pLeft != null)
                    return pLeft.Remove(x, this);
                else
                    return false;
            }
            else if (x.CompareTo(data) > 0)
            {
                if (pRight != null)
                    return pRight.Remove(x, this);
                else
                    return false;
            }
            else
            {
                if (pLeft != null && pRight != null)
                {
                    this.Data = pRight.MinValue();
                    pRight.Remove(this.Data, this);
                }
                else if (parent.pLeft == this)
                    parent.pLeft = (pLeft != null) ? pLeft : pRight;
                else if (parent.pRight == this)
                    parent.pRight = (pLeft != null) ? pLeft : pRight;
            }
            return true;
        }
    }
}
