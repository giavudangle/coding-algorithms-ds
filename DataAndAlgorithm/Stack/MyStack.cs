using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class MyStack
    {
        // Declare member fields
        private int stkMax;
        private int stkTop;
        private string[] stkArray;

        // Constructor : Default-Parameter-Copy

        public MyStack(int MaxItems=0)
        {
            stkArray = new string[MaxItems];
            stkMax = MaxItems;
            stkTop = -1;
        }


        // Properties 
        public int Stack_Max
        {
            get => stkMax;
            set => stkMax = value;
        }

        public int Stack_Top
        {
            get => stkTop;
            set => stkTop = value;
        }

        public string[] Stack_Array
        {
            get => stkArray;
            set => stkArray = value;
        }

        public int Count
        {
            get => stkArray.Length;
        }

        public bool IsEmpty()
        {
            if (stkTop == -1)  
                return true;
            return false;
        }

        public bool IsFull()
        {
            if (stkTop == stkMax - 1) 
                return true;
            return false;
        }

        public string Pop()
        {
            
            if (IsEmpty())
                return "Nothing to Pop";
            string outItem = stkArray[stkTop];
            stkTop--;
            return outItem;
        }

        public bool Push(string newItem)
        {
            if (IsFull())
                return false;
            stkTop++;          
            stkArray[stkTop] = newItem;
            return true;
        }

        public string Peek()
        {
            return stkArray[stkTop];
        }

        public void Clear()
        {
            for (int i = 0; i < stkArray.Length; i++)
            {
                Pop();
            }
        }

        public bool Contains(string x)
        {
            for (int i = 0; i < stkArray.Length; i++)
                if (Peek() == x)
                    return true;
            return false;
        }

    }
}
