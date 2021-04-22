using CSharpCompProgrammingTemplate.Helpers;
using System.Linq;

namespace CSharpCompProgrammingTemplate
{
    public class SplitArray
    {
        #region Main

        private static void Main(string[] args)
        {
            QuestionHelpers.Time(() => new Solution().SplitArray(LeetCode.Array(), LeetCode.Int()));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            public int SplitArray(int[] nums, int m)
            {
                var left = nums.Max();
                var right = nums.Sum();

                while (left < right)
                {
                    var mid = left + (right - left) / 2;
                    if (Feasible(mid, nums, m)) right = mid;
                    else left = mid + 1;
                }

                return left;
            }

            public bool Feasible(int sum, int[] nums, int maxSubaArrays)
            {
                var total = 0;
                var subArrays = 1;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (total + nums[i] > sum)
                    {
                        subArrays++;
                        total = nums[i];
                    }
                    else
                        total += nums[i];

                    if (subArrays > maxSubaArrays) return false;
                }
                return true;
            }
        }

        #endregion Solution
    }
}