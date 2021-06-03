using Fibonacci;
using System;

namespace DynamicProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 18;
            //int.TryParse(args[0], out n);

            Console.WriteLine("Starting Brute Force Fibonacci for n={0}...", n);
            
            var fibo = new BruteForceFibonacci();
            int result = fibo.Fib(n);

            Console.Out.WriteLine("The result is {0}", result);

        }
    }
}
