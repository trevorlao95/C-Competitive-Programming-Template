using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCompProgrammingTemplate.Theory.Graph_Theory.DepthFirstSearch
{
    public class DepthFirstSearch
    {
        public void Standard(int n, int[][] edges)
        {
            var adjacencyList = new List<List<int>>();

            // Constructing adjacency list
            for (int i = 0; i < n; i++)
            {
                adjacencyList.Add(new List<int>());
            }

            // Connect all nodes
            for (int i = 0; i < edges.Length; i++)
            {
                adjacencyList[edges[i][0]].Add(edges[i][1]);
                adjacencyList[edges[i][1]].Add(edges[i][0]);
            }

            var stack = new Stack<int>();
            // Need to track seen only in an undirected graph
            // if it is directed, then there is only ever one valid direction
            var seen = new bool[n];

            stack.Push(0);

            while (stack.Count != 0)
            {
                int node = stack.Pop();

                // Items can appear in seen multiple times in a stack
                // Seen makes sure we do not act on a duplicate
                // This is not needed for a DAG - infact, it's counterintuitive
                if (seen[node])
                    continue;

                seen[node] = true;

                // Add all neighbours
                for (int i = 0; i < adjacencyList[node].Count; i++)
                {
                    stack.Push(adjacencyList[node][i]);
                }
            }
        }

        // To find paths
        public void Recursive(int[][] graph, int node, List<int> path)
        {
            path.Add(node);

            for (int i = 0; i < graph[node].Length; i++)
            {
                Recursive(graph, graph[node][i], path);
                path.Remove(path.Count - 1);
            }
        }
    }
}