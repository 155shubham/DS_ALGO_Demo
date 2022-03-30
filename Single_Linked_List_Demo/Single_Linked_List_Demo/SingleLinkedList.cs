using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Linked_List_Demo
{
    class SingleLinkedList
    {
        private Node start;
        public SingleLinkedList()
        {
            start = null;
        }

        #region Creating single linked list object

        /// <summary>
        /// This function is used to create singlelinkedlist with single integer item.
        /// </summary>
        /// <param name="item">Integer</param>
        /// <returns>Node object</returns>
        public Node CreateSingleLinkedList(int item)
        {
            start = new Node(item);
            return start;
        }

        /// <summary>
        /// This function is used to create singlelinkedlist with multiple integer items.
        /// </summary>
        /// <param name="items">Integer Array</param>
        /// <returns>Node object</returns>
        public Node CreateSingleLinkedList(int[] intArr)
        {
            var len = intArr.Length;
            Node tempNode = new Node(0); ;

            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                {
                    start = new Node(intArr[i]);
                    tempNode = start;
                }
                else
                {
                    tempNode.link = new Node(intArr[i]);
                    tempNode = tempNode.link;
                }

            }
            return start;
        }

        #endregion

        #region Displaying items of single linked list

        /// <summary>
        /// This function is used to display single or mutiple items of the single linked list.
        /// </summary>
        /// <param name="sll">Node object</param>
        public void DisplaySingleLinkedList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            Console.WriteLine("Items of SingleLinkedList are displayed here: ");
            p = start;
            while (p != null)
            {
                Console.WriteLine(p.info);
                p = p.link;
            }
        }

        #endregion

        #region Searching items of single linked list

        /// <summary>
        /// This function is used to search any item in the existing singlelinkedlist and returns its position.
        /// </summary>
        /// <returns>Returns positional value as 1 if found otherwise 0</returns>
        public int SearchSingleLinkedList(int intItem)
        {
            int position = 1;
            if (start == null)
            {
                return 0;
            }

            Node p = start;
            while (p != null)
            {
                if (p.info == intItem) return position;
                position++;
                p = p.link;
            }

            return position = 0;
        }

        /// <summary>
        /// This function is used to search and return node positions for multiple items within an existing singlelinkedlist.
        /// </summary>
        /// <param name="arrItem">Integer Array</param>
        /// <returns>Positional values of the nodes</returns>
        public int[] SearchSingleLinkedList(int[] arrItem)
        {
            int[] positions = new int[arrItem.Length];
            int cnt = 0, i =0;
            if (start == null)
            {
                return positions;
            }

            Node p = start;
            while (p != null)
            {
                foreach (int item in arrItem)
                {
                    if (p.info == item)
                    {
                        positions[i] = cnt;
                        i++;
                    }
                }
                cnt++;
                p = p.link;
            }
            return positions;
        }

        #endregion

        #region Node Count within a single linked list

        /// <summary>
        /// This function is used to count no of nodes in single linked list
        /// </summary>
        /// <returns>Count of nodes</returns>
        public int CountNodes()
        {
            int count = 0;
            Node p;
            //if (start == null) return count;

            p = start;
            while (p != null)
            {
                count++;
                p = p.link;
            }

            return count;
        }

        #endregion

        #region Insertion of a item in a existing single linked list

        /// <summary>
        /// This function is used to insert a single item at the begining of the node
        /// </summary>
        /// <param name="intItem">Integer</param>
        /// <returns>Positional value of the node</returns>
        public bool InsertItemAtBegining(int intItem)
        {
            bool isInserted = false;
            try
            {
                Node p = new Node(intItem);
                p.link = start;
                start = p;
                isInserted = true;
            }
            catch (Exception ex)
            {
                isInserted = false;
            }
            return isInserted;
        }

        /// <summary>
        /// This function is used to insert a multiple items at the begining of the node.
        /// </summary>
        /// <param name="arrItem">Integer Array</param>
        /// <returns>Positions of the node</returns>
        public bool InsertItemsAtBegining(int[] intArr)
        {
            bool isInserted = false;
            Node temp = start;
            Node p;
            try
            {
                p = new Node(intArr[intArr.Length - 1]);
                p.link = start;
                for (int i = intArr.Length - 2; i >= 0; i--)
                {        
                    var x = new Node(intArr[i]);
                    x.link = p;
                    p = x;
                }
                start = p;
                isInserted = true;
            }
            catch
            {
                isInserted = false;
            }
            return isInserted;
        }

        /// <summary>
        /// This function is used to insert a single item at the end of the node.
        /// </summary>
        /// <param name="intItem">Integer</param>
        /// <returns></returns>
        public bool InsertItemAtTheEnd(int intItem)
        {
            bool isInserted = false;
            Node newItem = new Node(intItem);
            Node p = start;
            while (p != null)
            {
                if(p.link == null)
                {
                    p.link = newItem;
                    isInserted = true;
                    return isInserted;
                }
                p = p.link;
            }
            return isInserted;
        }

        public bool InsertItemsAtTheEnd(int[] intArr)
        {
            bool isInserted = false;
            //Node newItem = new Node(intArr);
            Node p = start;
            while (p != null)
            {
                if (p.link == null)
                {
                    p.link = newItem;
                    isInserted = true;
                    return isInserted;
                }
                p = p.link;
            }
            return isInserted;
        }
        #endregion

    }
}
