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
                QuestionHelpers.Time(() => solution.MaximalSquare(new char[][] { new char[] { '1', '1', '1', '1', '0' }, new char[] { '1', '1', '1', '1', '0' }, new char[] { '1', '1', '1', '1', '1' }, new char[] { '0', '0', '1', '1', '1' } }));
        }

        #endregion Main

        #region Solution

        public class Solution
        {
            public int MaximalSquare(char[][] matrix)
            {
                var dpMatrix = new int[matrix.Length + 1, matrix[0].Length + 1];
                var maxMatrixValue = 0;

                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == '1')
                        {
                            var matrixValue = Math.Min(Math.Min(dpMatrix[i, j], dpMatrix[i, j + 1]), dpMatrix[i + 1, j]) + 1;

                            dpMatrix[i + 1, j + 1] = matrixValue;

                            if (matrixValue > maxMatrixValue)
                                maxMatrixValue = matrixValue;
                        }
                        else
                            dpMatrix[i + 1, j + 1] = 0;
                    }
                }

                return maxMatrixValue * maxMatrixValue;
            }
        }

        #endregion Solution
    }
}