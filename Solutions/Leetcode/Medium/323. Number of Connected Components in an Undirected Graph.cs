using CSharpCompProgrammingTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

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

            CountComponents(Int(), IntGrid()));
        }

        #region Solution

        public class Solution
        {
            public int CountComponents(int n, int[][] edges)
            {
                _connected = n;

                Init(n);

                for (int i = 0; i < edges.Length; i++)
                {
                    Union(edges[i][0], edges[i][1]);
                }

                return _connected;
            }

            private int _connected;
            private int[] _root;
            private int[] _rank;

            public void Init(int size)
            {
                _root = new int[size];
                _rank = new int[size];

                for (int i = 0; i < size; i++)
                {
                    _root[i] = i;
                    _rank[i] = 1;
                }
            }

            public int Find(int x)
            {
                if (x == _root[x])
                    return x;

                return _root[x] = Find(_root[x]);
            }

            public void Union(int x, int y)
            {
                int rootX = Find(x);
                int rootY = Find(y);

                if (rootX != rootY)
                {
                    _connected--;

                    if (_rank[rootX] > _rank[rootY])
                        _root[rootY] = rootX;
                    else if (_rank[rootX] < _rank[rootY])
                        _root[rootX] = _root[rootY];
                    else
                    {
                        _root[rootY] = rootX;
                        _rank[rootX] += 1;
                    }
                }
            }

            public bool Connected(int x, int y)
            {
                return Find(x) == Find(y);
            }
        }
    }

    #endregion Solution
}