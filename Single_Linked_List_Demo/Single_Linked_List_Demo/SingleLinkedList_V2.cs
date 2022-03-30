using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Linked_List_Demo
{
    class SingleLinkedList_V2
    {
        public Node_V2 start_V2 = null;
        public SingleLinkedList_V2()
        {
            start_V2 = new Node_V2(null);
        }

        public Node_V2 CreateSingleLinkedList_V2(int[] intItems)
        {
            var len = intItems.Length;
            Node_V2 tempNode =  new Node_V2(null);
            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                {
                    start_V2.link_V2 = new Node_V2(intItems[i]);
                    tempNode = start_V2.link_V2;
                }
                else
                {
                    tempNode.link_V2 = new Node_V2(intItems[i]);
                    tempNode = tempNode.link_V2;
                }

            }
            return start_V2;
        }
    }
}
