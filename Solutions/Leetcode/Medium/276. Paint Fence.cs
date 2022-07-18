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

            NumWays(Int(), Int()));
        }

        #region Solution

        public class Solution
        {
            public int NumWays(int n, int k)
            {
                if (n == 0)
                    return 0;

                if (n == 1)
                    return k;

                if (n == 2)
                    return k * k;

                var dp = new int[n + 1];

                dp[0] = 0;
                dp[1] = k;
                dp[2] = k * k;

                for (int i = 3; i < n + 1; i++)
                {
                    dp[i] = (dp[i - 1] + dp[i - 2]) * (k - 1);
                }

                return dp[n];
            }
        }

        #endregion Solution
    }
}