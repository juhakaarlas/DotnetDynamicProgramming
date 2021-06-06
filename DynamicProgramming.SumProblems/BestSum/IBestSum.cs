using System.Collections.Generic;

namespace DynamicProgramming.BestSum
{
    public interface IBestSum
    {
        /// <summary>
        /// Given an array of <c>numbers</c> and a <c>targetSum</c>, 
        /// calculates the <i>shortest</i> possible combination of <c>numbers</c> 
        /// which add up to exactly <c>targetSum</c>.
        /// </summary>
        /// <param name="targetSum">The target sum</param>
        /// <param name="numbers">The numbers to used in addition.</param>
        /// <returns>
        /// A list containing the combination, if one was found. Otherwise <c>null</c>
        /// </returns>
        List<int> BestSum(int targetSum, int[] numbers);
    }
}