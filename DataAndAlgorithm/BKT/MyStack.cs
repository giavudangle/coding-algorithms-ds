using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKT
{
    class MyStack<T> where T : SinhVien
    {
        // Declare members variable
        private int stkMax;
        private int stkTop;
        private T[] myStack;

        // Generate all fields from Cosntructor;
       
        /* Constructor */
        // Parameters Contrusctor
        public MyStack(int maxItem)
        {
            myStack = new T[maxItem];
            stkMax = maxItem;
            stkTop=-1;
        }
        //Default Constructor
        public MyStack()
        {

        }

        // Copy Constructor
        public  MyStack(MyStack<T> tempStack)
        {
            myStack = tempStack.myStack;
            stkTop = tempStack.stkTop;
            stkMax = tempStack.stkMax;
        }   

        // Properties
        public int stackMax { get => stkMax; set => stkMax = value; }
        public int topStack { get => stkTop; set => stkTop = value; }
        public T[] Stack { get => myStack; set => myStack = value; }

        // Methods Require
        public bool IsEmpty()
        {
            if (stkTop == null)
                return true;
            return false;
        }

        public bool IsFull()
        {
            if (stkMax==0)
                return true;
            return false;
        }

        public T Pop()
        {

            if (IsEmpty())
                return null;
            T outItem = myStack[stkTop];
            stkTop--;
            return outItem;
        }

        public bool Push(T newItem)
        {
            if (IsFull())
                return false;
            stkTop++;
            myStack[stkTop] = newItem;
            return true;
        }

        public T Peek()
        {
            return myStack[stkTop];
        }

        public void Clear()
        {
            for (int i = 0; i < myStack.Length; i++)            
                Pop();        
        }

    }
}
