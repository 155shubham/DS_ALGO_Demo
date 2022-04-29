using System;
using System.Collections;

namespace Prims_MinCost_SPT
{
    // Program to find minimum cost spanning tree uisng Prims Algorithm
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[,]
            {
                {0,  25, 0,  0,  0,  8,  0},
                {25, 0,  9,  0,  0,  0,  6},
                {0,  9,  0,  10, 0,  0,  0},
                {0,  0,  10, 0,  12, 0,  11},
                {0,  0,  0,  12, 0,  18, 16},
                {8,  0,  0,  0,  18, 0,  0},
                {0,  6,  0,  11, 16, 0,  0},
            };

            int n = 7;

            FindPrimsMinimumCost(m, n);

            Console.ReadLine();
        }

        static void FindPrimsMinimumCost(int[,] m, int v)
        {
            ArrayList visitedEdges = new ArrayList();
            int min = 0;

            for (int i = 0; i < v; i++)
            {
                for (int j = i+1; j < v; j++)
                {
                    if (min != 0 && m[i, j] != 0 && m[i, j] < min)
                    {
                        min = m[i, j];
                        visitedEdges.Clear();
                        visitedEdges.Add(i);
                        visitedEdges.Add(j);
                    }
                    else if (min == 0 && m[i, j] != 0)
                    {
                        min = m[i, j];
                        visitedEdges.Clear();
                        visitedEdges.Add(i);
                        visitedEdges.Add(j);
                    }
                }
            }

            Console.WriteLine("Minimum Cost: {0}", min.ToString());

            min = 0;

            ////To test the first edges
            //for (int k = 0; k < visitedEdges.Count; k++)
            //{
            //    Console.WriteLine("Visited Edge: {0}", visitedEdges[k].ToString());
            //}

            bool treeCompleted = false;

            ArrayList nextVisitedEdges = new ArrayList();

            while (!treeCompleted)
            {
                for (int i = 0; i < visitedEdges.Count; i++)
                {
                    for (int j = 0; j < v; j++)
                    {
                        if(!visitedEdges.Contains(j))
                        {
                            if (min != 0 && m[(int)visitedEdges[i], j] != 0 && m[(int)visitedEdges[i], j] < min)
                            {
                                min = m[(int)visitedEdges[i], j];
                                nextVisitedEdges.Clear();
                                nextVisitedEdges.Add(j);
                            }
                            else if (min == 0 && m[(int)visitedEdges[i], j] != 0)
                            {
                                min = m[(int)visitedEdges[i], j];
                                nextVisitedEdges.Clear();
                                nextVisitedEdges.Add(j);
                            }
                        }                        
                    }
                }
                if (nextVisitedEdges.Count == 0)
                {
                    treeCompleted = true;
                }
                else
                {
                    min = 0;
                    visitedEdges.Add(nextVisitedEdges[0]);
                    nextVisitedEdges.Clear();
                }
            }

            for (int k = 0; k < visitedEdges.Count; k++)
            {
                Console.WriteLine("Visited Edge: {0}", visitedEdges[k].ToString());
            }
        }
    }
}
