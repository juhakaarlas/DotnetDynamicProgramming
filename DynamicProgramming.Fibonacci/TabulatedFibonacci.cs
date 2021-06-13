using System;

namespace DynamicProgramming.Fibonacci
{
    /// <summary>
    /// This class finds the Nth Fibonacci number using tabulation.
    /// It returns in O(n) time and space.
    /// The array length and for loop condition are different from those
    /// in the <see href="https://youtu.be/oBt53YbR9Kk?t=12076">video</see>
    /// because with the given solution i would actually go out of bounds.
    /// </summary>
    public class TabulatedFibonacci : IFibonacci
    {
        
        /// <inheritdoc/>
        public long Fib(long n)
        {
            long[] table = new long[n+2];
            table[1] = 1;

            for (long i = 0; i < n ; i++)
            {
                table[i + 1] += table[i];
                table[i + 2] += table[i];
            }

            return table[n];
        }
    }
}
