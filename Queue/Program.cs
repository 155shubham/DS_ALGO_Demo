using System;
using CodeFiles;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Queue Data Structures !");

            Queue_using_Array objQueue = new Queue_using_Array();

            int active = 1;
            while (active == 1)
            {
                Console.WriteLine(
                    "Please Enter \n 1 To Enqueue ! \n 2 To Dequeue \n 3 To know the size of the Queue!");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Please enter the number to enqueue !");
                    bool res = objQueue.ENQUEUE(int.Parse(Console.ReadLine()));
                    if (res)
                        Console.WriteLine("Enqueue: {0}", res.ToString());
                    else
                        Console.WriteLine("Queue is full !");
                }
                else if (choice == 2)
                {
                    int item = objQueue.DEQUEUE();
                    if (item != -1)
                        Console.WriteLine("Dequeue Item: {0}", item.ToString());
                    else
                        Console.WriteLine("Queue is empty !");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Size of the queue: {0}", (objQueue.GetSize()).ToString());
                }

                Console.WriteLine("Please enter anything to exit and 1 to again perform some action !");
                active = int.Parse(Console.ReadLine());
            }
        }
    }
}
