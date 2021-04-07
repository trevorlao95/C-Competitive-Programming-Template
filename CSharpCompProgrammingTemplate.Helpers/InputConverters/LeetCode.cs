using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CSharpCompProgrammingTemplate.Helpers
{
    public static class LeetCode
    {
        public static int[][] Grid()
        {
            List<int[]> result = new List<int[]>();

            List<int> currentRow = new List<int>();
            string currentNumber = string.Empty;

            foreach (var c in GetInput()[0])
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

        private static string[] GetInput()
        {
            return File.ReadAllLines("../../../input.txt");
        }
    }
}