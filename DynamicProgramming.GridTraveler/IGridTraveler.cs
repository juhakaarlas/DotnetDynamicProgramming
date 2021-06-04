namespace DynamicProgramming.GridTraveler
{
    interface IGridTraveler
    {
        /// <summary>
        /// Given an m * n grid, 
        /// when starting from the top left square, 
        /// and the allowed movements are one square down or one square right,
        /// returns the number of possible paths to the bottom right corner.
        /// </summary>
        /// <param name="m">The width of the grid</param>
        /// <param name="n">The height of the grid</param>
        /// <returns>The number or possible paths.</returns>
        long GridTraveler(long m, long n);
    }
}
