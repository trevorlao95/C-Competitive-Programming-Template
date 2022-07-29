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

            CloneGraph());
        }

        #region Solution

        public class Solution
        {
            private Dictionary<Node, Node> visited = new Dictionary<Node, Node>();

            public Node CloneGraph(Node node)
            {
                if (node == null)
                    return node;

                if (visited.ContainsKey(node))
                    return visited[node];

                var cloneNode = new Node(node.val, new List<Node>());
                visited.Add(node, cloneNode);

                for (int i = 0; i < node.neighbors.Count; i++)
                {
                    cloneNode.neighbors.Add(CloneGraph(node.neighbors[i]));
                }

                return cloneNode;
            }
        }
    }

    #endregion Solution
}