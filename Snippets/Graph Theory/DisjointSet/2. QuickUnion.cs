using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCompProgrammingTemplate.Snippets.Graph_Theory.DisjointSet
{
    public class QuickUnion
    {
        private readonly int[] _root;

        // O(N)
        public QuickUnion(int size)
        {
            _root = new int[size];

            for (int i = 0; i < size; i++)
            {
                _root[i] = i;
            }
        }

        // O(N) Worse case
        public int Find(int x)
        {
            while (x != _root[x])
            {
                x = _root[x];
            }

            return x;
        }

        // O(N) Worse case
        public void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);

            if (rootX != rootY)
                _root[rootY] = rootX;
        }

        // O(N)
        public bool Connected(int x, int y)
        {
            return Find(x) == Find(y);
        }
    }
}