using System;
using System.Diagnostics;
using System.IO;
using System.Timers;

namespace CSharpCompProgrammingTemplate.Helpers
{
    public static class QuestionHelpers
    {
        #region Public Methods

        /// <summary>
        /// Times the solution and then prints the results to the console and output.txt
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        public static string Time<T>(Func<T> action)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var result = action();

            stopwatch.Stop();

            Console.WriteLine($"Elapsed: {stopwatch.ElapsedMilliseconds}ms");

            result.Print();

            return result.ToString();
        }

        /// <summary>
        /// Prints the results to the console and output.txt
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result"></param>
        public static void Print<T>(this T result)
        {
            Console.WriteLine(result);
            File.WriteAllText("../../../output.txt", result.ToString());
        }

        #endregion Public Methods
    }
}