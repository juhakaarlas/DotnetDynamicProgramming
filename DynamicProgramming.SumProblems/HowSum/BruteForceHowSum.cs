using System.Collections.Generic;

namespace DynamicProgramming.SumProblems.HowSum
{
    /// <summary>
    /// Problem Statement (from freeCodeCamp.org)
    /// <para>
    /// Write a method <code>List&lt;int&gt; HowSum(long targetSum, int[] numbers)</code>
    /// which takes a <c>targetSum</c> and an array of numbers as arguments.
    /// </para>
    /// <para>
    /// The method should return an array containing any combination of elements
    /// that add up to exactly <c>targetSum</c>. If there is no combination that
    /// adds up to the <c>targetSum</c>, then return null.
    /// If there are multiple combinations possible, you may return any single one.
    /// </para>
    /// <para>
    /// You may use an element of the array as many times as needed.
    /// You may assume that all input numbers are non-negative.
    /// Check the <see href="https://youtu.be/oBt53YbR9Kk?t=5407">video from freeCodeCamp.org</see>
    /// for a thorough explanation of the algorithm.
    /// </para>
    /// <para>
    /// This class implements a brute force approach with O(n^m) time and O(m) space,
    /// where m = target sum and n = array length.</para>
    /// </summary>
    public class BruteForceHowSum
    {
        public List<int> HowSum(long targetSum, int[] numbers)
        {
            if (targetSum == 0) return new List<int>();
            
            if (targetSum < 0) return null;

            foreach (int num in numbers)
            {
                long remainder = targetSum - num;
                var remainderResult = HowSum(remainder, numbers);

                if (remainderResult != null)
                {
                    remainderResult.Add(num);
                    return remainderResult;
                }
            }

            return null;
        }
    }
}
