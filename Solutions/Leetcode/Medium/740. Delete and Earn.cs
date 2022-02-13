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
            QuestionHelpers.Time(() => Solution.DeleteAndEarn(LeetCode.Array()));
        }

        #endregion Main

        #region Solution

        public static class Solution
        {
            public static int DeleteAndEarn(int[] nums)
            {
                var values = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (values.ContainsKey(nums[i]))
                        values[nums[i]] += nums[i];
                    else
                        values.Add(nums[i], nums[i]);
                }

                var orderedDistinctNums = nums.Distinct().OrderBy(x => x).ToArray();

                var memo = new int[orderedDistinctNums.Length];
                memo[0] = values[orderedDistinctNums[0]];

                for (int i = 1; i < orderedDistinctNums.Length; i++)
                {
                    if (orderedDistinctNums[i] - 1 != orderedDistinctNums[i - 1])
                        memo[i] = memo[i - 1] + values[orderedDistinctNums[i]];
                    else 
                        memo[i] = Math.Max(values[orderedDistinctNums[i]] + memo.ElementAtOrDefault(i - 2), memo[i - 1]);
                }

                return memo.Last();
            }
        }

        #endregion Solution
    }
}