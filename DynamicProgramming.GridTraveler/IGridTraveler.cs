namespace DynamicProgramming.GridTraveler
{
    interface IGridTraveler
    {
        /// <summary>
        /// Given an w * n grid, 
        /// when starting from the top left square, 
        /// and the allowed movements are one square down or one square right,
        /// returns the number of possible paths to the bottom right corner.
        /// </summary>
        /// <param name="w">The width of the grid</param>
        /// <param name="h">The height of the grid</param>
        /// <returns>The number or possible paths.</returns>
        long GridTraveler(long w, long h);
    }
}
