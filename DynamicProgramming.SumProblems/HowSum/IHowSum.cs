using System.Collections.Generic;

namespace DynamicProgramming.SumProblems.HowSum
{
    public interface IHowSum
    {
        /// <summary>
        /// Given an array of <c>numbers</c> and a <c>targetSum</c>, 
        /// calculates a combination of <c>numbers</c> which add up to 
        /// exactly <c>targetSum</c>.
        /// </summary>
        /// <param name="targetSum">The target sum</param>
        /// <param name="numbers">The numbers to used in addition.</param>
        /// <returns>
        /// A list containing the combination, if one was found. Otherwise <c>null</c>
        /// </returns>
        List<int> HowSum(long targetSum, int[] numbers);
    }
}