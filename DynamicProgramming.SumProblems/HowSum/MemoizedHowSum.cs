using System.Collections.Generic;

namespace DynamicProgramming.SumProblems.HowSum
{
    /// <summary>
    /// Implements the HowSum using memoization. Completes in O(n*m) instead of the O(n*m^2) given
    /// in the video example - using a <c>List</c> instead of repeatedly unpacking arrays 
    /// explains the difference. Space complexity is O(m^2).
    /// </summary>
    public class MemoizedHowSum : IHowSum
    {
        private Dictionary<long, List<int>> _memo;

        public MemoizedHowSum()
        {
            _memo = new Dictionary<long, List<int>>();
        }

        /// <inheritdoc/>
        public List<int> HowSum(long targetSum, int[] numbers)
        {
            if (_memo.ContainsKey(targetSum)) return _memo[targetSum];
            if (targetSum == 0) return new List<int>();
            if (targetSum < 0) return null;

            foreach (int num in numbers)
            {
                long remainder = targetSum - num;
                var remainderResult = HowSum(remainder, numbers);

                if (remainderResult != null)
                {
                    remainderResult.Add(num);
                    _memo[targetSum] = remainderResult;
                    return remainderResult;
                }
            }

            _memo[targetSum] = null;
            return null;
        }
    }
}
