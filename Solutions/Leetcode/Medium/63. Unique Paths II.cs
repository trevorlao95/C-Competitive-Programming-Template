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

            UniquePathsWithObstacles(IntGrid()));
        }

        #region Solution

        public class Solution
        {
            public int UniquePathsWithObstacles(int[][] obstacleGrid)
            {
                var dp = new int[obstacleGrid.Length, obstacleGrid[0].Length];

                if (obstacleGrid[0][0] == 1)
                    return 0;

                for (int i = 0; i < obstacleGrid.Length; i++)
                {
                    for (int j = 0; j < obstacleGrid[i].Length; j++)
                    {
                        if (obstacleGrid[i][j] == 1)
                            dp[i, j] = 0;
                        else if (i == 0 && j == 0)
                            dp[i, j] = 1;
                        else if (i == 0)
                            dp[i, j] = dp[i, j - 1];
                        else if (j == 0)
                            dp[i, j] = dp[i - 1, j];
                        else
                            dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                    }
                }

                return dp[obstacleGrid.Length - 1, obstacleGrid[0].Length - 1];
            }
        }
    }

    #endregion Solution
}