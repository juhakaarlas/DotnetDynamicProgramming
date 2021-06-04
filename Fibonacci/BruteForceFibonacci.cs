using DynamicProgramming.Fibonacci;
using System;

namespace Fibonacci
{
    /// <summary>
    /// This class implements the calculation of the Nth Fibonacci number with brute force and recursion.
    /// It calculates the result in O(2^n) time and O(n) (stack) space.
    /// </summary>
    public class BruteForceFibonacci : IFibonacci
    {
        /// <inheritdoc />
        public int Fib(int n)
        {
            //We don't suppport the generalized series
            if (n < 0) throw new ArgumentOutOfRangeException();
            
            //Base case according to the generally accepted axiom of F(0) = 0
            if (n == 0) return 0;
            
            //First and second base cases
            if (n == 1 || n == 2) return 1;

            //Recurse to calculate the Nth value
            return Fib(n - 2) + Fib(n - 1);
        }
    }
}
