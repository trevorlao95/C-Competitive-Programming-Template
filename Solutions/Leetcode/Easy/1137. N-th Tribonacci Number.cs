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
            QuestionHelpers.Time(() => Solution.NthTribonacciNumber(LeetCode.Int()));
        }

        #endregion Main

        #region Solution

        public static class Solution
        {
            public static int NthTribonacciNumber(int n)
            {
                var memo = new int[n];

                memo[0] = 1;
                memo[1] = 1;
                memo[2] = 2;

                for (int i = 3; i < n; i++)
                {
                    memo[i] = memo[i - 3] + memo[i - 2] + memo[i - 1];
                }

                return memo[n - 1];
            }
        }

        #endregion Solution
    }
}