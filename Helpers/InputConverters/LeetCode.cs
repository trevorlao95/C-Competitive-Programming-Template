using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharpCompProgrammingTemplate.Helpers
{
    public abstract class LeetCode
    {
        #region Private Fields

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

        #endregion Private Fields

        #region Public Methods

        public static bool MoreColumns()
        {
            return _row != _inputRows.Length - 1;
        }

        #endregion Public Methods

        #region LeetCode Methods

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
                    sb.Append(c);
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
                    sb.Append(c);
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
        /// e.g. [[1,3,1],[1,5,1],[4,2,1]]
        /// </summary>
        public static List<IList<int>> IntGridList()
        {
            return GetGrid().ConvertAll(x => (IList<int>)x);
        }

        /// <summary>
        /// e.g. [[1,3,1],[1,5,1],[4,2,1]]
        /// </summary>
        public static int[][] IntGridArray()
        {
            return GetGrid().Select(x => x.Select(x => int.Parse(x)).ToArray()).ToArray();
        }

        /// <summary>
        /// e.g. [["leet"],["code"]]
        /// </summary>
        public static List<IList<string>> StringGridList()
        {
            return GetGrid();
        }

        /// <summary>
        /// e.g. [["leet"],["code"]]
        /// </summary>
        public static string[][] StringGridArray()
        {
            return GetGrid().Select(x => x.ToArray()).ToArray();
        }

        /// <summary>
        /// e.g. 3
        ///      4
        /// </summary>
        public static int[] VerticalIntArray()
        {
            var result = new List<int>();

            foreach (var c in _inputRows)
            {
                result.Add(int.Parse(c));
            }

            return result.ToArray();
        }

        #endregion LeetCode Methods

        #region LeetCode Structures

        /// Leetcode Supplied Node Class
        public class Node
        {
            public int val { get; }
            public IList<Node> neighbors { get; }

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }

        #endregion LeetCode Structures

        #region Private Methods

        /// <summary>
        /// Gets input from input.txt as a string array
        /// </summary>
        private static string[] GetInput()
        {
            return File.ReadAllLines("../../../input.txt");
        }

        private static List<IList<string>> GetGrid()
        {
            var result = new List<IList<string>>();
            var currentRow = new List<string>();

            StringBuilder sb = new StringBuilder();

            foreach (var c in _inputRows[Row].Replace("\"", ""))
            {
                if (char.IsLetter(c) || char.IsDigit(c))
                    sb.Append(c);
                else if (c == '-' && sb.Length == 0)
                    sb.Append('-');
                else if (sb.Length != 0)
                {
                    currentRow.Add(sb.ToString());
                    sb.Clear();

                    if (c == ']')
                    {
                        result.Add(currentRow);
                        currentRow = new List<string>();
                    }
                }
            }

            return result;
        }

        #endregion Private Methods
    }
}