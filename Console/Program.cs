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
                QuestionHelpers.Time(() => solution.CoinChange(LeetCode.Array(), LeetCode.Int()));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            public int CoinChange(int[] coins, int amount)
            {
                if (amount == 0)
                    return 0;

                var dp = Enumerable.Repeat(amount + 1, amount + 1).ToArray();
                dp[0] = 0;

                for (int i = 0; i < coins.Length; i++)
                {
                    for (int j = 0; j < dp.Length; j++)
                    {
                        if (coins[i] <= j)
                            dp[j] = Math.Min(dp[j], dp[j - coins[i]] + 1);
                    }
                }

                return dp[amount] > amount ? -1 : dp[amount];
            }
        }

        #endregion Solution
    }
}