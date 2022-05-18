using System;

namespace Linked_List
{
    class LinkedList_Demo
    {
        private Node firstNode;
        public LinkedList_Demo()
        {
            firstNode = null;
        }
        public Node createLinkedList(int[] arr, int length)
        {
            Node tempNode = new Node(null);

            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    firstNode = new Node(arr[i]);
                    tempNode = firstNode;
                }
                else
                {
                    tempNode.node = new Node(arr[i]);
                    tempNode = tempNode.node;
                }
            }
            return firstNode;
        }

        public int countNodes(Node node)
        {
            int count = 0;

            while (node != null)
            {
                count++;
                node = node.node;
            }
            return count;
        }

        public int countNodesRecursively(Node node)
        {
            if (node != null)
            {
                return 1 + countNodesRecursively(node.node);
            }
            else
            {
                return 0;
            }
        }

        public Node searchNode(int nodeNum, Node node)
        {
            Node nth_node = new Node(null);
            int count = 0;

            while (node != null)
            {
                node = node.node;
                count++;
                if (count == nodeNum)
                {
                    nth_node = node;
                    break;
                }
            }
            return nth_node;
        }

        public void displayLinkedList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.node;
            }
        }

        public void displayLinkedListRecursively(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.data);
                node = node.node;
                displayLinkedListRecursively(node);
            }
            else
            {
                return;
            }

        }

        public int? findSumOfAllElements(Node node)
        {
            if (node != null)
                return node.data + findSumOfAllElements(node.node);
            else
                return 0;
        }

        public int? findMax(Node node)
        {
            Node temp = node;
            int? x = node.data;
            while (node != null)
            {
                temp = temp.node;
                if (x < temp.data)
                {
                    x = temp.data;
                }
            }
            return x;
        }

        public int findMaxRecursively(Node node)
        {
            
        }
    }
}