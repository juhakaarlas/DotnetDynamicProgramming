using System;

namespace DynamicProgramming.GridTraveler
{
    /// <summary>
    /// Implements a basic brute force grid traveler algorithm.
    /// Completes in O(2^(m+n)) time.
    /// </summary>
    public class BasicGridTraveler : IGridTraveler
    {
        /// <inheritdoc/>
        public long GridTraveler(long m, long n)
        {
            //Implement the base cases
            if (m == 1 && n == 1) return 1;
            if (m == 0 || n == 0) return 0;

            return GridTraveler(m-1, n) + GridTraveler(m, n-1);
        }
    }
}
