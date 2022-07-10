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
                QuestionHelpers.Time(() => solution.LongestCommonSubsequence(LeetCode.String(), LeetCode.String()));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            public int LongestCommonSubsequence(string text1, string text2)
            {
                var memo = new int[text1.Length + 1, text2.Length + 1];

                for (int i = 1; i < text1.Length + 1; i++)
                {
                    for (int j = 1; j < text2.Length + 1; j++)
                    {
                        if (text1[i - 1] == text2[j - 1])
                            memo[i, j] = memo[i - 1, j - 1] + 1;
                        else
                            memo[i, j] = Math.Max(memo[i - 1, j], memo[i, j - 1]);
                    }
                }

                return memo[text1.Length, text2.Length];
            }
        }

        #endregion Solution
    }
}