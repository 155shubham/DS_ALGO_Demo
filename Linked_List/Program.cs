using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo for Linked List Implementation! \n");

            // Input to create LinkedList"
            int[] arr = { 10, 30, 5, 8, 8 };

            LinkedList_Demo ll = new LinkedList_Demo();

            // Create linked list
            Node linked_list = ll.createLinkedList(arr, arr.Length);

            // Diplay linked list
            Console.WriteLine("Display LinkedList");
            ll.displayLinkedList(linked_list);

            // No of nodes in linked list
            int num_of_nodes = ll.countNodes(linked_list);
            Console.WriteLine("\nCount of nodes in linked list: {0} \n", num_of_nodes);

            // Couting of nodes from linked list using recursion 
            int num_of_nodes_r = ll.countNodesRecursively(linked_list);
            Console.WriteLine("Count of nodes from linked list using recursion: {0} \n", num_of_nodes);

            // Search for nth node in linked list
            int num = 2;
            Node nth_node = ll.searchNode(num, linked_list);
            Console.WriteLine($"Found Node no: {num} having data {nth_node.data} \n");

            // Display LinkedList recursively
            Console.WriteLine("Display LinkedList Recursively");
            ll.displayLinkedListRecursively(linked_list);

            // Sum of all elements in the linked list
            Console.WriteLine("\nSum of all elements in the LinkedList: {0}", ll.findSumOfAllElements(linked_list));
            ll.findSumOfAllElements(linked_list);

            // Finding Max in a linked list
            Console.WriteLine("Maximum value in the linked list: ");
            ll.findMax(linked_list);

            Console.WriteLine("\n");
        }
    }
}
