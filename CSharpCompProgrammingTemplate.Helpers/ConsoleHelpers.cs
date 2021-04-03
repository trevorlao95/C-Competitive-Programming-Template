using System;
using System.Timers;

namespace CSharpCompProgrammingTemplate.Helpers
{
    public static class ConsoleHelpers
    {
        public static void Time(Action action, bool pauseAtFinish = false)
        {
            var timer = new Timer();

            action();

            Console.WriteLine($"Elapsed: {timer.Interval}ms");
            timer.Stop();
            timer.Dispose();

            if (pauseAtFinish)
                Console.ReadLine();
        }
    }
}