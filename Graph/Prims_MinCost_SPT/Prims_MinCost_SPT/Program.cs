using System;
using System.Collections.Generic;
using System.Linq;

namespace Prims_MinCost_SPT
{
    // Program to find minimum cost spanning tree uisng Prims and Kruskal
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[,]
            {
                {0,  25, 0,  0,  0,  5,  0},
                {25, 0,  9,  0,  0,  0,  6},
                {0,  9,  0,  10, 0,  0,  0},
                {0,  0,  10, 0,  12, 0,  11},
                {0,  0,  0,  12, 0,  18, 16},
                {5,  0,  0,  0,  18, 0,  0},
                {0,  6,  0,  11, 16, 0,  0},
            };

            int n = 7;

            FindPrimsMinimumCost(m, n);

            Console.ReadLine();
        }

        static void FindPrimsMinimumCost(int[,] m, int v)
        {
            int min = 0;
            int[] rc = new int[2];
            int[] visited = new int[v];
            int[] minimum = new int[v];

            Stack<int> s = new Stack<int>(); 

            for (int i = 0; i < v; i++)
            {
                for (int j = i; j < v; j++)
                {
                    if (m[i, j] != 0 && min != 0 && m[i, j] < min)
                    {
                        min = m[i, j];
                        rc[0] = i;
                        rc[1] = j;
                    }
                    else if (min == 0 && m[i, j] != 0)
                    {
                        min = m[i, j];
                        rc[0] = i;
                        rc[1] = j;
                    }

                }
            }
            s.Push(rc[0]);
            s.Push(rc[1]);

            while(s.Count() > 0)
            {
                var u1 = s.Pop();
                var u2 = s.Pop();
                int min_col_val = 0;

                for (int i = 0; i > v; i++)
                {
                    if (i != u2)
                    {
                        if (u1 == 0 && i == 0)
                        {
                            min_col_val = m[u1, i];
                        }
                        else
                        {
                            if (min_col_val != 0 && m[u1, i] != 0 && m[u1, i] < min)
                            {
                                min_col_val = m[u1, i];
                                rc[0] = u1;
                                rc[1] = i;
                            }
                            if (min_col_val == 0 && m[u1, i] != 0)
                            {
                                min_col_val = m[u1, i];
                                rc[0] = u1;
                                rc[1] = i;
                            }
                        }
                    }                                 
                }
                s.Push(u2);
            }
            Console.WriteLine("Min Val: " + min.ToString() + " Row No: " + rc[0].ToString() + " Col no: " + rc[1].ToString());
        }
    }
}
