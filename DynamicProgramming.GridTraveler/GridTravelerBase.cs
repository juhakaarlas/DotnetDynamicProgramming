using System;

namespace DynamicProgramming.GridTraveler
{
    public abstract class GridTravelerBase : IGridTraveler
    {
        /// <summary>
        /// Checks the arguments for the base cases and returns the appropriate path count.
        /// </summary>
        /// <param name="w">The width of the grid</param>
        /// <param name="h">The height of the grid</param>
        /// <returns>The axiomatic base case path count, otherwise -1.</returns>
        protected long BaseCase(long w, long h)
        {
            if (w < 0 || h < 0) throw new ArgumentOutOfRangeException("Arguments must be non-negative");

            //Implement the base cases
            if (w == 1 && h == 1) return 1;
            if (w == 0 || h == 0) return 0;

            return -1;
        }
        
        public abstract long GridTraveler(long m, long n);
        
    }
}
