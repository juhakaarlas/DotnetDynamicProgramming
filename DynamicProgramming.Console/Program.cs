using DynamicProgramming.Fibonacci;
using System;

namespace DynamicProgrammingProblems
{
    class Program
    {
        /// <summary>
        /// You can use the console app for quick and dirty experiments if unit tests are not your thing...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n = 40;

            Console.WriteLine("Starting Brute Force Fibonacci for n={0}...", n);
            
            var fibo = new BruteForceFibonacci();
            long result = fibo.Fib(n);

            Console.Out.WriteLine("The result is {0}", result);

        }
    }
}
