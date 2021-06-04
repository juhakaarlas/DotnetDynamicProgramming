namespace DynamicProgramming.CanSum
{
    public interface ICanSum
    {
        /// <summary>
        /// Determines if the given target sum can be calculated by adding
        /// numbers from the given array.
        /// </summary>
        /// <param name="targetSum">The target sum</param>
        /// <param name="numbers">An array of non-negative integers</param>
        /// <returns>
        /// <c>true</c> if <paramref name="targetSum"/> can be calculated from <paramref name="numbers"/>,
        /// otherwise <c>false</c>.
        /// </returns>
        bool CanSum(long targetSum, int[] numbers);
    }
}