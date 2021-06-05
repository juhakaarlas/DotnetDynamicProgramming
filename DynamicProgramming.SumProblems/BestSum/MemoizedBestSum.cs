using System.Collections.Generic;

namespace DynamicProgramming.BestSum
{
    /// <summary>
    /// This class implements the BestSum algorithm in O(n * m^2) time and O(m^2) space
    /// where m is the <c>targetSum</c> and n is the length of <c>numbers</c>.
    /// </summary>
    public class MemoizedBestSum : IBestSum
    {
        private Dictionary<int, List<int>> _memo;

        public MemoizedBestSum()
        {
            _memo = new Dictionary<int, List<int>>();
        }
        
        /// <inheritdoc/>
        public List<int> BestSum(int targetSum, int[] numbers)
        {
            if (targetSum < 0) return null;
            if (targetSum == 0) return new List<int>();
            if (_memo.ContainsKey(targetSum)) return _memo[targetSum];
            
            List<int> shortestCombo = null;

            foreach (int num in numbers)
            {
                var remainderCombination = BestSum(targetSum - num, numbers);

                if (remainderCombination != null)
                {
                    //clone the list - this only works for value types
                    var combination = new List<int>(remainderCombination);
                    combination.Add(num);

                    shortestCombo ??= combination;

                    //if the combination is shorter than the current best, update it
                    if (shortestCombo == null || combination.Count < shortestCombo.Count)
                    {
                        shortestCombo = combination;
                    }
                }
            }

            _memo[targetSum] = shortestCombo;
            return shortestCombo;
        }
    }
}
