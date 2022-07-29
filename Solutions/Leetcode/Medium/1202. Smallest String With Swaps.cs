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

            SmallestStringWithSwaps(String(), IntGrid()));
        }

        #region Solution

        public class Solution
        {
            public string SmallestStringWithSwaps(string s, int[][] pairs)
            {
                Init(s);

                for (int i = 0; i < pairs.Length; i++)
                {
                    Union(pairs[i][0], pairs[i][1]);
                }

                var map = new Dictionary<int, List<KeyValuePair<char, int>>>();

                for (int i = 0; i < s.Length; i++)
                {
                    var root = Find(_root[i]);

                    if (!map.ContainsKey(root))
                        map[root] = new List<KeyValuePair<char, int>>();

                    map[root].Add(new KeyValuePair<char, int>(s[i], i));
                }

                char[] result = new char[s.Length];
                foreach (var list in map.Values)
                {
                    var charArray = list.Select(x => x.Key).ToArray();
                    var indexArray = list.Select(x => x.Value).ToArray();
                    Array.Sort(charArray);

                    for (int i = 0; i < indexArray.Length; i++)
                        result[indexArray[i]] = charArray[i];
                }

                return new String(result);
            }

            private int[] _root;
            private int[] _rank;

            public void Init(string s)
            {
                var size = s.Length;

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