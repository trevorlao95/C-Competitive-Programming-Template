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

            // Change method and inputs here:
            MinCostClimbingStairs(IntArray()));
        }

        #region Solution

        public class Solution
        {
            public int MinCostClimbingStairs(int[] cost)
            {
                if (cost.Length == 1)
                    return cost[0];

                var j = cost[0];
                var k = cost[1];

                for (int l = 2; l < cost.Length; l++)
                {
                    int i = j;
                    j = k;
                    k = cost[l] + Math.Min(i, k);
                }

                return Math.Min(j, k);
            }
        }

        #endregion Solution
    }
}