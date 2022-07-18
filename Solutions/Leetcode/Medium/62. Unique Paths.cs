using CSharpCompProgrammingTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

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

            UniquePaths(Int(), Int()));
        }

        #region Solution

        public class Solution
        {
            public int UniquePaths(int m, int n)
            {
                var dp = new int[m, n];

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == 0)
                            dp[i, j] = 1;
                        else if (j == 0)
                            dp[i, j] = 1;
                        else
                            dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                    }
                }

                return dp[m - 1, n - 1];
            }
        }
    }

    #endregion Solution
}