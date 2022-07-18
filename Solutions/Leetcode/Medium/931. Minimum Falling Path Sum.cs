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

            MinFallingPathSum(IntGrid()));
        }

        #region Solution

        public class Solution
        {
            public int MinFallingPathSum(int[][] grid)
            {
                var dp = new int[grid.Length, grid[0].Length];
                var lowest = int.MaxValue;

                if (grid.Length == 1 || grid[0].Length == 1)
                    return grid.SelectMany(x => x).Min();

                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (i == 0)
                            dp[i, j] = grid[i][j];
                        else if (j == 0)
                            dp[i, j] = Math.Min(dp[i - 1, j], dp[i - 1, j + 1]) + grid[i][j];
                        else if (j == grid[i].Length - 1)
                            dp[i, j] = Math.Min(dp[i - 1, j], dp[i - 1, j - 1]) + grid[i][j];
                        else
                            dp[i, j] = Math.Min(Math.Min(dp[i - 1, j - 1], dp[i - 1, j]), dp[i - 1, j + 1]) + grid[i][j];

                        if (i == grid.Length - 1)
                            lowest = Math.Min(lowest, dp[i, j]);
                    }
                }

                return lowest;
            }
        }
    }

    #endregion Solution
}