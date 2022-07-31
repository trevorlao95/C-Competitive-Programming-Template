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

            FindItinerary(StringGridList()));
        }

        #region Solution

        public class Solution
        {
            private LinkedList<string> _routes;
            private Dictionary<string, PriorityQueue<string, string>> _adjacencyList;

            public IList<string> FindItinerary(IList<IList<string>> tickets)
            {
                _routes = new LinkedList<string>();
                _adjacencyList = new Dictionary<string, PriorityQueue<string, string>>();

                for (int i = 0; i < tickets.Count; i++)
                {
                    if (!_adjacencyList.ContainsKey(tickets[i][0]))
                        _adjacencyList.Add(tickets[i][0], new PriorityQueue<string, string>());

                    _adjacencyList[tickets[i][0]].Enqueue(tickets[i][1], tickets[i][1]);
                }

                Visit("JFK");

                return new List<string>(_routes);
            }

            public void Visit(string airport)
            {
                while (_adjacencyList.ContainsKey(airport) && _adjacencyList[airport].Count != 0)
                {
                    Visit(_adjacencyList[airport].Dequeue());
                }

                _routes.AddFirst(airport);
            }
        }
    }

    #endregion Solution
}