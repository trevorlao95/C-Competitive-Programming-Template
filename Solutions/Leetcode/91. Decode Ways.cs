using CSharpCompProgrammingTemplate.Helpers;
using System.Collections.Generic;

namespace CSharpCompProgrammingTemplate
{
    public class Program
    {
        #region Main

        private static void Main(string[] args)
        {
            QuestionHelpers.Time(() => new Solution().NumDecodings(LeetCode.String()));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            public int NumDecodings(string s)
            {
                var dp = new int[s.Length + 1];

                dp[0] = 1;
                dp[1] = s[0] == '0' ? 0 : 1;

                for (int i = 2; i <= s.Length; i++)
                {
                    var firstDigit = s[i - 1];
                    var twoDigits = int.Parse(new string(new char[] { s[i - 2], s[i - 1] }));

                    if (char.GetNumericValue(firstDigit) > 0)
                        dp[i] += dp[i - 1];

                    if (twoDigits >= 10 && twoDigits <= 26)
                        dp[i] += dp[i - 2];
                }

                return dp[s.Length];
            }
        }

        #endregion Solution
    }
}