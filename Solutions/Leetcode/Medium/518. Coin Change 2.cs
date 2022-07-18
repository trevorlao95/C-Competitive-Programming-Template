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

            Change(Int(), IntArray()));
        }

        #region Solution

        public class Solution
        {
            public int Change(int amount, int[] coins)
            {
                var dp = new int[amount + 1];

                dp[0] = 1;
                for (int i = 0; i < coins.Length; i++)
                {
                    for (int j = 0; j < dp.Length; j++)
                    {
                        if (coins[i] <= j)
                            dp[j] = dp[j - coins[i]] + dp[j];
                    }
                }

                return dp[amount];
            }
        }
    }

    #endregion Solution
}