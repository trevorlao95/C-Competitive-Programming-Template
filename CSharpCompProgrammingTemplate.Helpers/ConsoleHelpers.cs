using System;
using System.Timers;

namespace CSharpCompProgrammingTemplate.Helpers
{
    public static class ConsoleHelpers
    {
        public static string Time<T>(Func<T> action)
        {
            var timer = new Timer();

            var result = action();

            Console.WriteLine($"Elapsed: {timer.Interval}ms");
            timer.Stop();
            timer.Dispose();

            return result.ToString();
        }
    }
}