using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCompProgrammingTemplate.Snippets.Graph_Theory.DisjointSet
{
    public class UnionByRank
    {
        private readonly int[] _root;
        private readonly int[] _rank;

        // O(N)
        public UnionByRank(int size)
        {
            _root = new int[size];
            _rank = new int[size];

            for (int i = 0; i < size; i++)
            {
                _root[i] = i;
                _rank[i] = 1;
            }
        }

        // O(LogN)
        public int Find(int x)
        {
            while (x != _root[x])
            {
                x = _root[x];
            }

            return x;
        }

        // O(LogN)
        public void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);

            if (rootX != rootY)
            {
                if (_rank[rootX] > _rank[rootY])
                    _root[rootY] = rootX;
                else if (_rank[rootX] < _rank[rootY])
                    _root[rootX] = rootY;
                else
                {
                    _root[rootY] = rootX;
                    _rank[rootX] += 1;
                }
            }
        }

        // O(LogN)
        public bool Connected(int x, int y)
        {
            return Find(x) == Find(y);
        }
    }
}