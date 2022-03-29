using System;
using System.Collections.Generic;
using System.Linq;

namespace BreadthFirstSearch
{
    //Breadth first search program
    class Program
    {
        static void Main(string[] args)
        {
            //Adjacency input matrix
            int[,] m =
                {
                    { 0, 1, 1, 1, 0, 0, 0 },
                    { 1, 0, 1, 0, 0, 0, 0 },
                    { 1, 1, 0, 1, 1, 0, 0 },
                    { 1, 0, 1, 0, 1, 0, 0 },
                    { 0, 0, 1, 1, 0, 1, 1 },
                    { 0, 1, 1, 1, 0, 0, 0 },
                    { 0, 1, 1, 1, 0, 0, 0 }
                };

            //Lets find the bfs for vertex 1
            Console.WriteLine("Vertex-1");
            Result.BFS(1, m, 7);

            //Lets find the bfs for vertex 4
            Console.WriteLine("Vertex-4");
            Result.BFS(4, m, 7);

            Console.ReadLine();
        }
    }
    class Result    {
        static public void BFS(int v, int[,] m, int n)
        {
            //initialise the visited array to store the vertices which have been already visited
            int[] visited = new int[n];

            //Initialise the queue to store the visited ones
            Queue<int> q = new Queue<int>();

            //Visited the input
            Console.WriteLine(v);

            //Add to the visited array
            visited[v] = 1; 

            //Drop into q
            q.Enqueue(v);

            //Loop till q count gets emptied
            while(q.Count > 0)
            {
                //Take out the vertex from the queue and delete the vertex from q.
                var u = q.Dequeue();

                //Loop till column ends to complete one row check
                for (int i = 0; i < n; i++) // Adjacent vertices of vertex u
                {                    
                    if (m[u, i] == 1 && visited[i] == 0) // Adjacent vertices and not visited
                    {
                        Console.WriteLine(i);
                        visited[i] = 1;
                        q.Enqueue(i);
                    }
                }
            }
        }
    }
}
