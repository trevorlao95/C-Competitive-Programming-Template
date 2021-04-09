using CSharpCompProgrammingTemplate.Helpers;
using System.Collections.Generic;

namespace CSharpCompProgrammingTemplate
{
    public class Program
    {
        #region Main

        private static void Main(string[] args)
        {
            QuestionHelpers.Time(() => new Solution().UniquePaths(LeetCode.Int(), LeetCode.Int(1)));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            public int UniquePaths(int m, int n)
            {
                var uniqueWays = new List<List<int>>();

                for (int i = 0; i < m; i++)
                {
                    var uniqueWaysRow = new List<int>();

                    for (int j = 0; j < n; j++)
                    {
                        if (i == 0)
                            uniqueWaysRow.Add(1);
                        else if (j == 0)
                            uniqueWaysRow.Add(1);
                        else
                            uniqueWaysRow.Add(uniqueWaysRow[j - 1] + uniqueWays[i - 1][j]);
                    }

                    uniqueWays.Add(uniqueWaysRow);
                }

                return uniqueWays[m - 1][n - 1];
            }
        }

        #endregion Solution
    }
}