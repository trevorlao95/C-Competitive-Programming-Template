using CSharpCompProgrammingTemplate.Helpers;
using System;
using System.Threading;

namespace CSharpCompProgrammingTemplate
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ConsoleHelpers.Time(() =>
            {
                Console.WriteLine("Hello World!");
                Thread.Sleep(1000);
            });
        }
    }
}