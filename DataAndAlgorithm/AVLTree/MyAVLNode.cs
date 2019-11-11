using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAVLTree
{
    class MyAVLNode
    {
        public int data;
        public MyAVLNode left;
        public MyAVLNode right;

        public MyAVLNode leftChild { get => left; set => left = value; }
        public MyAVLNode rightChild { get => right; set => left = value; }
        public int Data { get => data; set => data = value; }
        public MyAVLNode(int x) { data = x; }
       
    }
}
