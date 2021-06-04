namespace DynamicProgramming.CanSum
{
    /// <summary>
    /// Problem Statement (from freeCodeCamp.org)
    /// <para>
    /// Write a method <code>bool CanSum(long targetSum, int[] numbers)</code>
    /// which takes a target sum and an array of numbers as arguments.
    /// </para>
    /// <para>
    /// The method should return a boolean indicating whether or not
    /// it is possible to generate the target sum using numbers from the array.
    /// </para>
    /// <para>
    /// You may use an element of the array as many times as needed.
    /// You may assume that all input numbers are non-negative.
    /// </para>
    /// Check the <seealso href="https://youtu.be/oBt53YbR9Kk?t=4199">video from freeCodeCamp.org</seealso>
    /// for a thorough explanation of the algorithm.
    /// </summary>
    public class BruteForceCanSum : ICanSum
    {
        /// <inheritdoc/>
        public bool CanSum(long targetSum, int[] numbers)
        {
            if (targetSum == 0) return true;
            if (targetSum < 0) return false;

            foreach (int num in numbers)
            {
                long remainder = targetSum - num;

                if (CanSum(remainder, numbers))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
