using CSharpCompProgrammingTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCompProgrammingTemplate
{
    public class CountVowelStrings
    {
        #region Main

        private static void Main(string[] args)
        {
            var solution = new Solution();

            while (LeetCode.MoreColumns())
                QuestionHelpers.Time(() => solution.MaxProfit(LeetCode.Int(), LeetCode.IntArray()));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            public int MaxProfit(int k, int[] prices)
            {
                if (k == 0 || prices.Length < 2)
                    return 0;

                if (k > prices.Length / 2)
                    return NoLimit(prices);

                int[,] hold = new int[k + 1, prices.Length];
                int[,] sell = new int[k + 1, prices.Length];

                for (int i = 1; i <= k; i++)
                {
                    hold[i, 0] = -prices[0];
                    sell[i, 0] = 0;

                    for (int j = 1; j < prices.Length; j++)
                    {
                        hold[i, j] = Math.Max(-prices[j] + sell[i - 1, j], hold[i, j - 1]);
                        sell[i, j] = Math.Max(prices[j] + hold[i, j - 1], sell[i, j - 1]);
                    }
                }

                return sell[k, prices.Length - 1];
            }

            public int NoLimit(int[] prices)
            {
                int max = 0;

                for (int i = 0; i < prices.Length - 1; i++)
                {
                    if (prices[i + 1] > prices[i])
                        max += prices[i + 1] - prices[i];
                }

                return max;
            }
        }

        #endregion Solution
    }
}