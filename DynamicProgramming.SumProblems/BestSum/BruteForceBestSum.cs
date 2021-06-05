using System.Collections.Generic;

namespace DynamicProgramming.BestSum
{
    /// <summary>
    /// Problem Statement (from freeCodeCamp.org)
    /// <para>
    /// Write a method <c>BestSum(int targetSum, int[] numbers)</c> that takes
    /// in a <c>targetSum</c> and an array of numbers as arguments.
    /// </para>
    /// <para>
    /// The method should return an array containing the <i>shortest</i> combination
    /// of numbers that add up to exactly the <c>targetSum</c>.
    /// </para>
    /// <para>
    /// If there is a tie for the shortest combination, you may return any
    /// one of the shortest.
    /// </para>
    /// </summary>
    public class BruteForceBestSum : IBestSum
    {
        /// <inheritdoc/>
        public List<int> BestSum(int targetSum, int[] numbers)
        {
            if (targetSum == 0) return new List<int>();

            if (targetSum < 0) return null;

            List<int> shortestCombo = null;

            foreach (int num in numbers)
            {
                int remainder = targetSum - num;
                var remainderCombination = BestSum(remainder, numbers);

                if (remainderCombination != null)
                {
                    (remainderCombination ??= new List<int>()).Add(num);

                    shortestCombo ??= remainderCombination;
                    
                    //if the combination is shorter than the current best, update it
                    if (remainderCombination.Count < shortestCombo.Count)
                    {
                        shortestCombo = remainderCombination;
                    }
                }
            }

            return shortestCombo;
        }
    }
}
