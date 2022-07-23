using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCompProgrammingTemplate.Snippets.Graph_Theory.DisjointSet
{
    public class QuickFind
    {
        private readonly int[] _root;

        // O(N)
        public QuickFind(int size)
        {
            _root = new int[size];

            for (int i = 0; i < size; i++)
            {
                _root[i] = i;
            }
        }

        // O(1)
        public int Find(int x)
        {
            return _root[x];
        }

        // O(N)
        public void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);

            if (rootX != rootY)
            {
                for (int i = 0; i < _root.Length; i++)
                {
                    if (_root[i] == rootY)
                        _root[i] = rootX;
                }
            }
        }

        // O(1)
        public bool Connected(int x, int y)
        {
            return Find(x) == Find(y);
        }
    }
}