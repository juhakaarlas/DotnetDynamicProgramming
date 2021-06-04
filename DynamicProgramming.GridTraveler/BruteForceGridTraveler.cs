namespace DynamicProgramming.GridTraveler
{
    /// <summary>
    /// <para>
    /// Problem Statement:
    /// 
    /// Say that you are a traveler on a 2D grid. You begin in the top-left corner
    /// and your goal is to travel to the bottom-right corner. 
    /// You may only move down or right.
    /// 
    /// In how many ways can you travel to the goal on a grid with dimensions w * h?
    /// 
    /// Check the <see href="https://www.youtube.com/watch?v=oBt53YbR9Kk&t=2319s">video from freeCodeCamp.org</see>
    /// for a thorough explanation.
    /// </para>
    /// <para>
    /// This class implements a basic brute force grid traveler algorithm.
    /// Completes in O(2^(w+h)) time and O(w+h) space.
    /// </para>
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
