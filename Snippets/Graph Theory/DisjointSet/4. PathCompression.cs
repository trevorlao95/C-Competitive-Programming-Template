using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCompProgrammingTemplate.Snippets.Graph_Theory.DisjointSet
{
    public class PathCompression
    {
        private readonly int[] _root;

        // O(N)
        public PathCompression(int size)
        {
            _root = new int[size];

            for (int i = 0; i < size; i++)
            {
                _root[i] = i;
            }
        }

        // O(LogN)
        public int Find(int x)
        {
            if (x == _root[x])
                return x;

            return _root[x] = Find(_root[x]);
        }

        // O(LogN)
        public void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);

            if (rootX != rootY)
                _root[rootY] = rootX;
        }

        // O(LogN)
        public bool Connected(int x, int y)
        {
            return Find(x) == Find(y);
        }
    }
}