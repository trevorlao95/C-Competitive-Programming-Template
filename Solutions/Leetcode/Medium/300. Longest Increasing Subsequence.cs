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
                QuestionHelpers.Time(() => solution.LengthOfLIS(LeetCode.IntArray()));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            public int LengthOfLIS(int[] nums)
            {
                var dp = Enumerable.Repeat(1, nums.Length).ToArray();
                var maxSoFar = 0;

                for (int i = 1; i < dp.Length; i++)
                {
                    var j = i;
                    while (j > 0)
                    {
                        j--;

                        if (nums[i] > nums[j])
                        {
                            dp[i] = Math.Max(dp[i], dp[j] + 1);
                            maxSoFar = Math.Max(dp[i], maxSoFar);
                        }
                    }
                }

                return maxSoFar;
            }
        }

        #endregion Solution
    }
}