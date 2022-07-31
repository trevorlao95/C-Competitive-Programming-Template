using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCompProgrammingTemplate.Theory.Graph_Theory.DepthFirstSearch
{
    public class DepthFirstSearch
    {
        /// <summary>
        /// Standard with size given
        /// </summary>
        /// <param name="n">Number of vertices</param>
        /// <param name="edges">Edges</param>
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

        /// <summary>
        /// Recursive to trace a path w/o seen list (directed graph)
        /// </summary>
        /// <param name="graph">Adjacency list</param>
        /// <param name="node">current node</param>
        /// <param name="path">path so far</param>
        public void Recursive(int[][] graph, int node, List<int> path)
        {
            path.Add(node);

            for (int i = 0; i < graph[node].Length; i++)
            {
                Recursive(graph, graph[node][i], path);
                path.Remove(path.Count - 1);
            }
        }

        /// <summary>
        /// Backtracking
        /// </summary>

        #region Backtracking variables

        private List<List<string>> _tickets;
        private List<string> _results;
        private Dictionary<string, List<string>> _adjacencyList;
        private Dictionary<string, bool[]> _visited;

        #endregion Backtracking variables

        public bool Backtracking(string origin, LinkedList<string> route)
        {
            // Reached the end
            if (route.Count == _tickets.Count + 1)
            {
                _results = new List<string>(route);
                return true;
            }

            if (!_adjacencyList.ContainsKey(origin))
                return false;

            var visited = _visited[origin];

            for (int i = 0; i < _adjacencyList[origin].Count; i++)
            {
                var destination = _adjacencyList[origin][i];

                if (!visited[i])
                {
                    visited[i] = true;
                    route.AddLast(destination);

                    var backtrack = Backtracking(destination, route);
                    route.RemoveLast();
                    visited[i] = false;

                    if (backtrack)
                        return true;
                }
            }

            return false;
        }
    }
}