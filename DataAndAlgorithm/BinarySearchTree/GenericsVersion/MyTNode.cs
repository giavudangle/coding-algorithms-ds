using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Tree
{
    // Class MyTNote must inheritance Generics Interface for using CompareTo Methods.
    public class MyTNode<T> where T:IComparable<T>
    {
        T data;
        MyTNode<T> pLeft = null;
        MyTNode<T> pRight = null;

        public T Data
        {
            get => data;
            set => data = value;
        }

        public MyTNode<T> leftChild
        {
            get => pLeft;
            set => pLeft = value;
        }

        public MyTNode<T> rightChild
        {
            get => pRight;
            set => pRight = value;
        }

        public MyTNode(T x)
        {
            data = x;
            pLeft = null;
            pRight = null;
        }

        public int TreeHeight()
        {
            return 1 + Math.Max(
                pLeft != null ? pLeft.TreeHeight() : 0,
                pRight != null ? pRight.TreeHeight() : 0
            );
        }


        public bool InsertData(T x)
        {
            if (x.CompareTo(data) == 0)
                return false;
            if (x.CompareTo(data) < 0)
            {
                if (pLeft == null)
                    pLeft = new MyTNode<T>(x);
                else return pLeft.InsertData(x);
            }
            else
            {
                if (pRight == null)
                    pRight = new MyTNode<T>(x);
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

        public MyTNode<T> SearchX(T x) 
        {
            if (x.CompareTo(data)==0)
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

        

        public MyTNode<T> RightMost()
        {
            if (pRight == null)
                return this;
            return pRight.RightMost();
        }

        public MyTNode<T> LeftLeast()
        {
            if (pLeft == null)
                return this;
            return pLeft.LeftLeast();
        }

        public T MinValue()
        {
            if (pLeft == null)
                return data;
            return pLeft.MinValue();
        }


        public bool Remove(T x,MyTNode<T> parent)
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

