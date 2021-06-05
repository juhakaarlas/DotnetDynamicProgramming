using System;

namespace DynamicProgramming.Fibonacci
{
    /// <summary>
    /// Problem Statement (modified from freeCodeCamp.org)
    /// <para>
    /// Write a method <c>long Fib(long n)</c> that takes in a number 
    /// as an argument. The method should return the N-th number of
    /// the Fibonacci sequence.
    /// </para>
    /// <para>
    /// The 1st and 2nd number of the sequence is 1. To generate the next number
    /// of the sequence, we sum the previous two.
    /// Fib(0) = 0, Fib(1) = 1, Fib(2) = 1, Fib(n) = Fib(n-2) + Fib(n-1).
    /// </para>
    /// This class implements the calculation of the N-th Fibonacci number with brute force and recursion.
    /// It calculates the result in O(2^n) time and O(n) (stack) space.
    /// Check the <see href="https://youtu.be/oBt53YbR9Kk?t=238">video</see> for 
    /// a more thorough explanation.
    /// </summary>
    public class BruteForceFibonacci : FibonacciBase
    {
        /// <inheritdoc />
        public override long Fib(long n)
        {
            //Leaving the duplicate code here as an intro instead of utilizing the 
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
