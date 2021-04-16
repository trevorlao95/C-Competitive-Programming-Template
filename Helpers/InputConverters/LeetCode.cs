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

        private static readonly string[] _inputRows = GetInput();
        private static int _row = -1;

        private static int Row
        {
            get
            {
                _row++;
                return _row;
            }
        }

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// e.g. [[1,3,1],[1,5,1],[4,2,1]]
        /// </summary>
        public static int[][] Grid()
        {
            var result = new List<int[]>();
            var currentRow = new List<int>();
            var currentNumber = string.Empty;

            foreach (var c in _inputRows[Row])
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
        public static int[] Array()
        {
            var result = new List<int>();
            var currentNumber = string.Empty;

            foreach (var c in _inputRows[Row])
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
        public static int Int()
        {
            return int.Parse(_inputRows[Row]);
        }

        /// <summary>
        /// e.g. "word"
        /// </summary>
        public static string String()
        {
            return _inputRows[Row].Trim('"');
        }

        /// <summary>
        /// e.g. 3
        ///      4
        /// </summary>
        public static int[] AllIntArray()
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
        private static string[] GetInput()
        {
            return File.ReadAllLines("../../../input.txt");
        }

        #endregion Private Methods
    }
}