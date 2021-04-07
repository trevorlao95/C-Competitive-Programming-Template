using CSharpCompProgrammingTemplate.Helpers;
using System;
using System.IO;

namespace CSharpCompProgrammingTemplate
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var input = LeetCode.Grid();

            QuestionHelpers.Time(() => MinPathSum(input));
        }

        public static int MinPathSum(int[][] grid)
        {
            return 5;
        }
    }
}