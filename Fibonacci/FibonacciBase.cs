using System;

namespace DynamicProgramming.Fibonacci
{
    /// <summary>
    /// This class provides common functionality for checking the Fibonacci series base cases.
    /// You can inherit this to avoid duplicating the boilerplate if statements.
    /// </summary>
    public abstract class FibonacciBase : IFibonacci
    {
        /// <summary>
        /// Checks if the given parameter falls under one of the Fibonacci base cases.
        /// Returns the value of the base case, or -1 if the input was not a base case.
        /// </summary>
        /// <param name="n">The Nth number in the Fibonacci series to check.</param>
        /// <returns>The value of the Fibonacci number, if <paramref name="n"/> was a base case. Otherwise -1.</returns>
        protected int BaseCase(long n)
        {
            //We don't suppport the generalized series
            if (n < 0) throw new ArgumentOutOfRangeException();

            //Base case according to the generally accepted axiom of F(0) = 0
            if (n == 0)
            {
                return 0;
            }

            //First and second base cases
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return -1;
        }

        /// <inheritdoc />
        public abstract long Fib(long n);
    }
}
