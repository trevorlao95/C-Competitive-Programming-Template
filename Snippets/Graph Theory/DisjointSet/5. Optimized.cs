using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCompProgrammingTemplate.Snippets.Graph_Theory.DisjointSet
{
    public class Optimized
    {
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

            // Combine two separate groups
            if (rootX != rootY)
            {
                if (_rank[rootX] > _rank[rootY])
                    _root[rootY] = rootX;
                else if (_rank[rootX] < _rank[rootY])
                    _root[rootX] = _root[rootY];
                else
                {
                    // Groups have identical rank
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