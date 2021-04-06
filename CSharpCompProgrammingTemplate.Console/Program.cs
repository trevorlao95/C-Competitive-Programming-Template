using CSharpCompProgrammingTemplate.Helpers;
using System;
using System.IO;

namespace CSharpCompProgrammingTemplate
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var input = InputConverters.Grid();

            var result = ConsoleHelpers.Time(() =>
            MinPathSum(input));

            Console.WriteLine(result);
            File.WriteAllText("../../../output.txt", result.ToString());
        }

        public static int MinPathSum(int[][] grid)
        {
            return 5;
        }
    }
}