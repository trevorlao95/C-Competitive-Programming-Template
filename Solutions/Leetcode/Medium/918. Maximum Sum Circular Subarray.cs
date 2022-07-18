using CSharpCompProgrammingTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

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

            /**
             * Change method and inputs here, possible values:
             * • Int
             * • IntGrid
             * • IntArray
             * • AllIntArray
             * • StringArray
             * • String
             * **/

            MaxSubarraySumCircular(IntArray()));
        }

        #region Solution

        public class Solution
        {
            public int MaxSubarraySumCircular(int[] nums)
            {
                var currentMax = 0;
                var bestMax = int.MinValue;
                var currentMin = 0;
                var bestMin = int.MaxValue;
                var total = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    currentMax = Math.Max(nums[i], currentMax + nums[i]);
                    bestMax = Math.Max(currentMax, bestMax);

                    currentMin = Math.Min(nums[i], currentMin + nums[i]);
                    bestMin = Math.Min(currentMin, bestMin);
                    total += nums[i];
                }

                return bestMax > 0 ? Math.Max(bestMax, total - bestMin) : bestMax;
            }
        }
    }

    #endregion Solution
}