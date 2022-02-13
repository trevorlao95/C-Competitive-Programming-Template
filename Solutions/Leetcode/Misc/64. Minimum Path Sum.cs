using CSharpCompProgrammingTemplate.Helpers;
using System;
using System.Collections.Generic;

namespace CSharpCompProgrammingTemplate
{
    public class MinPathSum
    {
        #region Main

        private static void Main(string[] args)
        {
            QuestionHelpers.Time(() => new Solution().MinPathSum(LeetCode.IntGrid()));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            public int MinPathSum(int[][] grid)
            {
                List<List<int>> shortestPathGrid = new List<List<int>>();

                for (int i = 0; i < grid.Length; i++)
                {
                    var row = new List<int>();

                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (i == 0 && j == 0)
                            row.Add(grid[i][j]);
                        else if (i == 0)
                            row.Add(grid[i][j] + row[j - 1]);
                        else if (j == 0)
                            row.Add(grid[i][j] + shortestPathGrid[i - 1][j]);
                        else
                            row.Add(Math.Min(grid[i][j] + shortestPathGrid[i - 1][j], grid[i][j] + row[j - 1]));
                    }

                    shortestPathGrid.Add(row);
                }

                return shortestPathGrid[grid.Length - 1][grid[0].Length - 1];
            }
        }

        #endregion Solution
    }
}