using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CSharpCompProgrammingTemplate.Helpers
{
    public static class LeetCode
    {
        #region Fields

        private static string[] _inputRows = GetInput();

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// e.g. [[1,3,1],[1,5,1],[4,2,1]]
        /// </summary>
        /// <param name="row">Input row line</param>
        /// <returns></returns>
        public static int[][] Grid(int row = 0)
        {
            var result = new List<int[]>();
            var currentRow = new List<int>();
            var currentNumber = string.Empty;

            foreach (var c in _inputRows[row])
            {
                if (char.IsDigit(c))
                    currentNumber += c;
                else if (c == ',' && currentNumber != string.Empty)
                {
                    currentRow.Add(int.Parse(currentNumber));
                    currentNumber = string.Empty;
                }
                else if (c == ']' && currentNumber != string.Empty)
                {
                    currentRow.Add(int.Parse(currentNumber));
                    currentNumber = string.Empty;
                    result.Add(currentRow.ToArray());
                    currentRow = new List<int>();
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// e.g. [2,1,6,4]
        /// </summary>
        /// <param name="row">Input row line</param>
        /// <returns></returns>
        public static int[] Array(int row = 0)
        {
            var result = new List<int>();
            var currentNumber = string.Empty;

            foreach (var c in _inputRows[row])
            {
                if (char.IsDigit(c))
                    currentNumber += c;
                else if (c == ',' && currentNumber != string.Empty)
                {
                    result.Add(int.Parse(currentNumber));
                    currentNumber = string.Empty;
                }
                else if (c == ']' && currentNumber != string.Empty)
                {
                    result.Add(int.Parse(currentNumber));
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// e.g. 3
        /// </summary>
        /// <param name="row">Input row line</param>
        /// <returns></returns>
        public static int Int(int row = 0)
        {
            return int.Parse(_inputRows[row]);
        }

        /// <summary>
        /// e.g. "word"
        /// </summary>
        /// <param name="row">Input row line</param>
        /// <returns></returns>
        public static string String(int row = 0)
        {
            return _inputRows[row].Trim('"');
        }

        /// <summary>
        /// e.g. 3
        ///      4
        /// </summary>
        /// <returns></returns>
        public static int[] IntArray()
        {
            var result = new List<int>();

            foreach (var c in _inputRows)
            {
                result.Add(int.Parse(c));
            }

            return result.ToArray();
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Gets input from input.txt as a string array
        /// </summary>
        /// <returns></returns>
        private static string[] GetInput()
        {
            return File.ReadAllLines("../../../input.txt");
        }

        #endregion Private Methods
    }
}