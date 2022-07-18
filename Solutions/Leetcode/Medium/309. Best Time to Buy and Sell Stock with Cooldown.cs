using CSharpCompProgrammingTemplate.Helpers;
using System;

namespace CSharpCompProgrammingTemplate
{
    public class LeetCodeConsole : LeetCode
    {
        private static void Main(string[] args)
        {
            var solution = new Solution();
            while (MoreColumns()) QuestionHelpers.Time(() => solution.

            // Change method and inputs here:
            MaxProfit(IntArray()));
        }

        #region Solution

        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                int sold = 0;
                int hold = int.MinValue;
                int rest = 0;

                for (int i = 0; i < prices.Length; i++)
                {
                    hold = Math.Max(hold, rest - prices[i]);
                    rest = Math.Max(rest, sold);
                    sold = hold + prices[i];
                }

                return Math.Max(sold, rest);
            }
        }

        #endregion Solution
    }
}