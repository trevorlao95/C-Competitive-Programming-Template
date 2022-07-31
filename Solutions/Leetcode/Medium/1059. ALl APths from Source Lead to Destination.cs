using CSharpCompProgrammingTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCompProgrammingTemplate
{
    public class LeetCodeConsole : LeetCode
    {
        private static void Main(string[] args)
        {
            #region Main

            var solution = new Solution();
            while (MoreColumns()) QuestionHelpers.Time(() => solution.

            #endregion Main

            LeadsToDestination(Int(), IntGridArray(), Int(), Int()));
        }

        #region Solution

        public class Solution
        {
            private Dictionary<int, List<int>> _adjacencyList;

            public bool LeadsToDestination(int n, int[][] edges, int source, int destination)
            {
                _adjacencyList = new Dictionary<int, List<int>>();

                for (int i = 0; i < edges.Length; i++)
                {
                    if (!_adjacencyList.ContainsKey(edges[i][0]))
                        _adjacencyList[edges[i][0]] = new List<int>();

                    _adjacencyList[edges[i][0]].Add(edges[i][1]);
                }

                if (_adjacencyList.ContainsKey(source))
                    return false;

                return DFS(source, destination, new bool[n]);
            }

            private bool DFS(int node, int destination, bool[] seen)
            {
                if (node == destination)
                    return true;

                seen[node] = true;

                if (!_adjacencyList.ContainsKey(node))
                    return false;

                for (int i = 0; i < _adjacencyList[node].Count; i++)
                {
                    // Detect cycle
                    if (seen[_adjacencyList[node][i]] || !DFS(_adjacencyList[node][i], destination, seen))
                        return false;
                }

                seen[node] = false;

                return true;
            }
        }
    }
}

#endregion Solution