using CSharpCompProgrammingTemplate.Helpers;
using System;

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

            MaxProfit(IntArray()));
        }

        #region Solution

        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                var lowest = prices[0];
                var best = 0;

                for (int i = 1; i < prices.Length; i++)
                {
                    lowest = Math.Min(prices[i], lowest);
                    best = Math.Max(best, prices[i] - lowest);
                }

                return best;
            }
        }
    }

    #endregion Solution
}