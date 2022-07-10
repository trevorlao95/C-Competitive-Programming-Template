using CSharpCompProgrammingTemplate.Helpers;
using Newtonsoft.Json;
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
                QuestionHelpers.Time(() => solution.MaximumScoreFromPerformingMultiplicationOperations(LeetCode.Array(), LeetCode.Array()));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            private int[] nums, muls;
            private int?[,] memo;

            public int MaximumScoreFromPerformingMultiplicationOperations(int[] nums, int[] muls)
            {
                this.nums = nums;
                this.muls = muls;
                memo = new int?[muls.Length, muls.Length];

                return dp(0, nums.Length - 1, 0);
            }

            public int dp(int l, int r, int i)
            {
                if (i == muls.Length)
                    return 0;

                if (memo[l, i] != null)
                    return memo[l, i].Value;

                var pickLeft = dp(l + 1, r, i + 1) + nums[l] * muls[i];
                var pickRight = dp(l, r - 1, i + 1) + nums[r] * muls[i];

                memo[l, i] = Math.Max(pickLeft, pickRight);

                return memo[l, i].Value;
            }
        }

        #endregion Solution
    }
}