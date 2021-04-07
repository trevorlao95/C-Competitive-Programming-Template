using System;
using System.IO;
using System.Timers;

namespace CSharpCompProgrammingTemplate.Helpers
{
    public static class QuestionHelpers
    {
        public static string Time<T>(Func<T> action)
        {
            var timer = new Timer();

            var result = action();

            Console.WriteLine($"Elapsed: {timer.Interval}ms");

            timer.Stop();
            timer.Dispose();

            result.Print();

            return result.ToString();
        }

        public static void Print<T>(this T result)
        {
            Console.WriteLine(result);
            File.WriteAllText("../../../output.txt", result.ToString());
        }
    }
}