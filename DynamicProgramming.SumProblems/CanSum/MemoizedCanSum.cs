using System.Collections.Generic;

namespace DynamicProgramming.CanSum
{
    /// <summary>
    /// This class implements the CanSum algorithm using memoization.
    /// It completes in O(m*n) time and O(m) space, where
    /// here m = target sum and n = array length.
    /// </summary>
    public class MemoizedCanSum : ICanSum
    {
        private Dictionary<long, bool> _lookup;

        public MemoizedCanSum()
        {
            _lookup = new Dictionary<long, bool>();
        }
        
        /// <inheritdoc />
        public bool CanSum(long targetSum, int[] numbers)
        {
            if (_lookup.ContainsKey(targetSum)) return _lookup[targetSum];
            if (targetSum == 0) return true;
            if (targetSum < 0) return false;

            foreach (int num in numbers)
            {
                long remainder = targetSum - num;

                if (CanSum(remainder, numbers))
                {
                    _lookup[targetSum] = true;
                    return true;
                }
            }

            _lookup[targetSum] = false;
            return false;
        }
    }
}
