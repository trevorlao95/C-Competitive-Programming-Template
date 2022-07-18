using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CSharpCompProgrammingTemplate.Helpers
{
    public abstract class LeetCode
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

        public static bool MoreColumns()
        {
            return _row != _inputRows.Length - 1;
        }

        /// <summary>
        /// e.g. [[1,3,1],[1,5,1],[4,2,1]]
        /// </summary>
        public static int[][] IntGrid()
        {
            var result = new List<int[]>();
            var currentRow = new List<int>();
            StringBuilder sb = new StringBuilder();

            foreach (var c in _inputRows[Row])
            {
                if (char.IsDigit(c))
                    sb.Append(c);
                else if (c == ',' && sb.Length != 0)
                {
                    currentRow.Add(int.Parse(sb.ToString()));
                    sb.Clear();
                }
                else if (c == ']' && sb.Length != 0)
                {
                    currentRow.Add(int.Parse(sb.ToString()));
                    sb.Clear();

                    result.Add(currentRow.ToArray());
                    currentRow = new List<int>();
                }
                // Negative
                else if (c == '-' && sb.Length == 0)
                {
                    sb.Append('-');
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// e.g. [2,1,6,4]
        /// </summary>
        public static int[] IntArray()
        {
            var currentRow = Row;
            var result = new List<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _inputRows[currentRow].Length; i++)
            {
                var c = _inputRows[currentRow][i];

                if (char.IsDigit(c))
                {
                    sb.Append(c);
                }
                // Terminators
                else if ((c == ',' || c == ']' || i == _inputRows[currentRow].Length - 1) && sb.Length != 0)
                {
                    result.Add(int.Parse(sb.ToString()));
                    sb.Clear();
                }
                // Negative
                else if (c == '-' && sb.Length == 0)
                {
                    sb.Append('-');
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// e.g. ["leet", "code"]
        /// </summary>
        public static string[] StringArray()
        {
            var currentRow = Row;
            var result = new List<string>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _inputRows[currentRow].Length; i++)
            {
                var c = _inputRows[currentRow][i];

                if (char.IsLetter(c))
                {
                    sb.Append(c);
                }
                // Terminators
                else if ((c == ',' || c == ']' || i == _inputRows[currentRow].Length - 1) && sb.Length != 0)
                {
                    result.Add(sb.ToString());
                    sb.Clear();
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