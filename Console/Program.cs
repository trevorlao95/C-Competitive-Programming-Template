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
            }
        }

        #endregion Solution
    }
}