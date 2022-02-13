using CSharpCompProgrammingTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCompProgrammingTemplate
{
    public class Program
    {
        #region Main

        private static void Main(string[] args)
        {
            QuestionHelpers.Time(() => new Solution().CountVowelStrings(LeetCode.Int()));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            public int CountVowelStrings(int n)
            {
                var dp = new List<int>() { 5 };

                for (int i = 1; i < n; i++)
                {
                    var newDp = new List<int>();
                    for (int j = 0; j < dp.Count; j++)
                    {
                        if (dp[j] == 5)
                            newDp.AddRange(new List<int> { 5, 4, 3, 2, 1 });
                        else if (dp[j] == 4)
                            newDp.AddRange(new List<int> { 4, 3, 2, 1 });
                        else if (dp[j] == 3)
                            newDp.AddRange(new List<int> { 3, 2, 1 });
                        else if (dp[j] == 2)
                            newDp.AddRange(new List<int> { 2, 1 });
                        else if (dp[j] == 1)
                            newDp.AddRange(new List<int> { 1 });
                    }
                    dp = newDp;
                }

                return dp.Sum();
            }
        }

        #endregion Solution
    }
}