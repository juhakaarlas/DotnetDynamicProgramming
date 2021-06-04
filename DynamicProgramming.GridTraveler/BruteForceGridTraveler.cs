using System;

namespace DynamicProgramming.GridTraveler
{
    /// <summary>
    /// Implements a basic brute force grid traveler algorithm.
    /// Completes in O(2^(w+h)) time and O(w+h) space.
    /// </summary>
    public class BruteForceGridTraveler : IGridTraveler
    {
        /// <inheritdoc/>
        public long GridTraveler(long w, long h)
        {
            //Implement the base cases
            if (w == 1 && h == 1) return 1;
            if (w == 0 || h == 0) return 0;

            return GridTraveler(w-1, h) + GridTraveler(w, h-1);
        }
    }
}
