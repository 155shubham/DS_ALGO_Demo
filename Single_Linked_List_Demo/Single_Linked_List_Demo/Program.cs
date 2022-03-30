using System;

namespace Single_Linked_List_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the no of nodes you want the single linked list to have: ");
            int noOfNodes = int.Parse(Console.ReadLine());
            int[] arrNodes = new int[noOfNodes];
            for (int i =0; i<noOfNodes; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                arrNodes[i] = int.Parse(Console.ReadLine());
            }

            SingleLinkedList sll = new SingleLinkedList();
            sll.CreateSingleLinkedList(arrNodes);            

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter you choice of number for the functionalities given below:");
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Search for an element");
                Console.WriteLine("3. Count Number of Nodes");
                Console.WriteLine("4. Insert item(s) at the begining in the list");
                Console.WriteLine("5. Insert at the end of the list");
                Console.WriteLine("6. Insert in between the list nodes");

                Console.WriteLine();
                Console.Write("Enter Your choice here: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    // Display List
                    case 1:
                        sll.DisplaySingleLinkedList();
                        break;

                    //Search for an element
                    case 2:
                        Console.Write("Enter integer value to be searched: ");
                        var item_for_search = int.Parse(Console.ReadLine());
                        var result = sll.SearchSingleLinkedList(item_for_search);
                        var str = result == 0 ? "Not Found" : $"Positional value is {result.ToString()}";
                        Console.WriteLine($"Searching integer {item_for_search.ToString()} in the singlelinkedlist...Search over. {str}");
                        break;

                    // Count Number of Nodes
                    case 3:
                        var no = sll.CountNodes();
                        Console.WriteLine("No of Nodes is " + no.ToString());
                        break;

                    // Insert item(s) at the begining in the list
                    case 4:
                        Console.Write("Insert no of value(s) to be inserted at the begining: ");
                        int noOfValues_to_be_inserted = int.Parse(Console.ReadLine());
                        int inserted_position = 0;

                        // Insert single item at the begining in the list
                        if (noOfValues_to_be_inserted == 1)
                        {
                            Console.Write("Enter the value to be inserted: ");
                            var value_to_be_inserted = int.Parse(Console.ReadLine());
                            var res = sll.InsertItemAtBegining(value_to_be_inserted);
                            if (res == true)
                            {
                                inserted_position = sll.SearchSingleLinkedList(value_to_be_inserted);
                            }
                            else
                            {
                                inserted_position = 0;
                            }
                            Console.WriteLine("New Node inserted at position " + inserted_position.ToString());
                        }
                        // Insert multiple items at the begining in the list
                        else if (noOfValues_to_be_inserted > 1)
                        {
                            int[] intArr_Of_noOfValues_to_be_inserted = new int[noOfValues_to_be_inserted];
                            for (int i = 0; i < noOfValues_to_be_inserted; i++)
                            {
                                Console.Write("Enter the value to be inserted: ");
                                intArr_Of_noOfValues_to_be_inserted[i] = int.Parse(Console.ReadLine());
                            }
                            var res = sll.InsertItemsAtBegining(intArr_Of_noOfValues_to_be_inserted);
                            if (res == true)
                            {
                                var arrRes = sll.SearchSingleLinkedList(intArr_Of_noOfValues_to_be_inserted);
                                string inserted_position_str = "";
                                for (int i = 0; i < arrRes.Length; i++)
                                {
                                    inserted_position_str += $"{arrRes[i].ToString()} ," ;
                                }
                                Console.WriteLine($"New Node inserted at positions {inserted_position_str.ToString()}");
                            }                            
                        }                   
                        sll.DisplaySingleLinkedList();
                        break;
                    case 5:
                        Console.Write("Insert no of value(s) to be inserted at the end: ");
                        int noOfValues_to_be_inserted_atEnd = int.Parse(Console.ReadLine());                    
                        if (noOfValues_to_be_inserted_atEnd == 1)
                        {
                            Console.Write("Enter value to be inserted");
                            int val_tobe_inserted_atEnd = int.Parse(Console.ReadLine());
                            sll.InsertItemAtTheEnd(val_tobe_inserted_atEnd);
                        }
                        sll.DisplaySingleLinkedList();
                        break;
                    default:
                        break;

                }
            }       

            //int k;
            //Node currNode = sll;
            //for (int j = 0; j< intArr.Length; j++)
            //{
            //    k = currNode.info;
            //    Console.WriteLine(k.ToString());
            //    currNode = currNode.link;
            //}
            //SingleLinkedList_V2 obSll_V2 = new SingleLinkedList_V2();
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //obSll_V2.CreateSingleLinkedList_V2(arr);

            Console.ReadLine();
        }
    }
}
