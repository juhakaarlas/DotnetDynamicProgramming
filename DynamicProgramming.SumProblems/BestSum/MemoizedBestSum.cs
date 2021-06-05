using System;
using System.Collections.Generic;

namespace DynamicProgramming.BestSum
{
    public class MemoizedBestSum : IBestSum
    {
        private Dictionary<int, List<int>> _memo;

        public MemoizedBestSum()
        {
            _memo = new Dictionary<int, List<int>>();
        }
        public List<int> BestSum(int targetSum, int[] numbers)
        {
            if (_memo.ContainsKey(targetSum)) return _memo[targetSum];
            if (targetSum == 0) return new List<int>();
            if (targetSum < 0) return null;
            return null;
        }
    }
}
