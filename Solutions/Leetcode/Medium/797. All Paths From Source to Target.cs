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

            /**
             * Change method and inputs here, possible values:
             * • Int
             * • IntGrid
             * • IntArray
             * • AllIntArray
             * • StringArray
             * • String
             * **/

            AllPathsSourceTarget(IntGrid()));
        }

        #region Solution

        public class Solution
        {
            public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
            {
                var adjacencyList = new List<List<int>>();

                // Connect all nodes
                for (int i = 0; i < graph.Length; i++)
                {
                    var directions = graph[i];

                    adjacencyList.Add(new List<int>());

                    for (int j = 0; j < directions.Length; j++)
                    {
                        adjacencyList[i].Add(directions[j]);
                    }
                }

                var stack = new Stack<(int, List<int>)>();
                var possiblePaths = new List<IList<int>>();

                stack.Push((0, new List<int>() { 0 }));

                while (stack.Count != 0)
                {
                    var (node, path) = stack.Pop();

                    if (node == graph.Length - 1)
                        possiblePaths.Add(path);

                    for (int i = 0; i < adjacencyList[node].Count; i++)
                    {
                        var adjacentNode = adjacencyList[node][i];

                        var pathCopy = path.ToList();
                        pathCopy.Add(adjacentNode);
                        stack.Push((adjacentNode, pathCopy));
                    }
                }

                return possiblePaths;
            }
        }
    }

    #endregion Solution
}