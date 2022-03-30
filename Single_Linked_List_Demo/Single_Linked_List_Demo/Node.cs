using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Linked_List_Demo
{
    class Node
    {
        // Here we are considering integer for the info part. 
        // It can take any other data types also.
        public int info;
        public Node link;
        public Node(int i)
        {
            info = i;
            link = null;
        }
    }
}
