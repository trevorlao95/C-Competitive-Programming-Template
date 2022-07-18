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
                QuestionHelpers.Time(() => solution.MaxProfit(LeetCode.IntArray()));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                var dp = new int[prices.Length];

                for (int i = 1; i < prices.Length; i++)
                {
                    if (prices[i] < prices[i - 1])
                        dp[i] = dp[i - 1];
                    else
                    {
                        var j = i - 1;

                        while (j >= 0)
                        {
                            dp[i] = Math.Max(prices[i] - prices[j] + dp[j], dp[i]);

                            j--;
                        }
                    }
                }

                return dp[prices.Length - 1];
            }
        }

        #endregion Solution
    }
}