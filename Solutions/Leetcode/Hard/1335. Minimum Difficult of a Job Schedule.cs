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
                QuestionHelpers.Time(() => solution.MinDifficulty(LeetCode.Array(), LeetCode.Int()));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            public int MinDifficulty(int[] jobDifficulty, int d)
            {
                if (jobDifficulty.Length < d)
                    return -1;

                return dp(jobDifficulty, d, 0, new Dictionary<(int, int), int>());
            }

            private int dp(int[] jobDifficulty, int day, int cut, Dictionary<(int, int), int> memo)
            {
                if (memo.ContainsKey((day, cut)))
                    return memo[(day, cut)];

                if (day == 1)
                    return jobDifficulty.Skip(cut).Max();

                var maxSoFar = 0;
                var answer = int.MaxValue;

                for (int i = cut; i < jobDifficulty.Length - day + 1; i++)
                {
                    maxSoFar = Math.Max(maxSoFar, jobDifficulty[i]);
                    answer = Math.Min(answer, maxSoFar + dp(jobDifficulty, day - 1, i + 1, memo));
                }

                memo[(day, cut)] = answer;

                return answer;
            }
        }

        #endregion Solution
    }
}