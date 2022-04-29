using System;
using System.Collections;
namespace CodeFiles
{
    public class Queue_using_Array
    {
        ArrayList arr = new ArrayList();
        int front = -1;
        int rear = -1;
        int size { get; set; }

        public bool ENQUEUE(int item)
        {
            if (arr.Count == 10)
            {
                return false;
            }
            arr.Insert(rear + 1, item);
            rear++;
            return true;
        }

        public int DEQUEUE()
        {
            if (arr.Count != 0)
            {
                int value = (int)arr[front + 1];
                arr.RemoveAt(front + 1);
                front++;
                return value;
            }
            else
            {
                return -1;
            }
        }

        public int GetSize()
        {
            return arr.Count;
        }
    }
}