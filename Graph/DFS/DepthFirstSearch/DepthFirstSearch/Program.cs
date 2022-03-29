using System;
using System.Collections.Generic;
using System.Linq;

namespace DepthFirstSearch
{
    //Depth first search program
    class Program
    {
        static void Main(string[] args)
        {
            #region Common input

            //Adjacency input matrix
            int[,] m = new int[,]
            {
                { 0, 1, 1, 1, 0, 0, 0 },
                { 1, 0, 1, 0, 0, 0, 0 },
                { 1, 1, 0, 1, 0, 0, 0 },
                { 1, 0, 1, 0, 1, 0, 0 },
                { 0, 0, 1, 1, 0, 1, 1 },
                { 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0 }
            };

            //no of vertex
            int n = 7;

            #endregion

            #region Test DFS using normal way

            //Lets find the dfs for vertex 1
            Console.WriteLine("DFS for Vertex-1");
            Result.DFS(1, m, n);

            //Lets find the dfs for vertex 4
            Console.WriteLine("DFS for Vertex-4");
            Result.DFS(4, m, n);

            //Lets find the dfs for vertex 6
            Console.WriteLine("DFS for Vertex-6");
            Result.DFS(6, m, n);

            #endregion

            #region Test DFS using recursion

            int[] visited = new int[n];

            //Lets find the dfs for vertex 1
            Console.WriteLine("DFS for Vertex-1 using recursion");
            Result.DFS_Using_Recursion(1, m, n, visited);

            visited = new int[n];

            //Lets find the dfs for vertex 4
            Console.WriteLine("DFS for Vertex-4 using recursion");
            Result.DFS_Using_Recursion(4, m, n, visited);

            visited = new int[n];

            //Lets find the dfs for vertex 6
            Console.WriteLine("DFS for Vertex-6 using recursion");
            Result.DFS_Using_Recursion(6, m, n, visited);

            #endregion

            Console.ReadLine();
        }
    }

    class Result
    {
        // First way using normal approach
        static public void DFS(int v, int[,] m, int n)
        {
            //Initialise the stack to store suspended items
            Stack<int> s = new Stack<int>();

            //Initialise the visited array
            int[] visited = new int[n];

            //Visit the input vertex
            Console.WriteLine(v);

            //Add into visited array
            visited[v] = 1;

            //Suspend the verted and push it to stack
            s.Push(v);

            int u = 0;

            bool found = false;

            while(s.Count()>0)
            {
                // If no vertex found take it from queue as queue count is still greater than 0
                if(!found)
                {
                    u =  s.Pop();
                }

                for (int i = 0; i < n; i++) //Adjacent vertices
                {
                    found = false;
                    if (m[u, i] == 1 && visited[i] == 0) //Any Adjacent vertex if found
                    {
                        // Visit the vertex
                        Console.WriteLine(i);

                        //Mark it to visited
                        visited[i] = 1;

                        //Push it to stack
                        s.Push(u);

                        //Start loop from the vertex found
                        u = i;
                        
                        found = true;
                        break;
                    }
                }
            }
        }

        // Second way using recursion
        static public void DFS_Using_Recursion(int v, int[,] m, int n, int[] visited)
        {
            //int[] visited = new int[n];

            // If not visited
            if (visited[v] == 0)
            {
                // If not visited visit the node
                Console.WriteLine(v);

                // If not visited mark it as visited
                visited[v] = 1;

                for(int i =0; i < n; i++) //Check for adjacent vertices
                {
                    if(m[v,i] == 1 && visited[i] == 0)
                    {
                        DFS_Using_Recursion(i, m, n, visited);
                    }
                }

            }

        }
    }
}
