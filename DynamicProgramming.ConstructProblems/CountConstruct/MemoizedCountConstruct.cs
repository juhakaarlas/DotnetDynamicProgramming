﻿using System.Collections.Generic;

namespace DynamicProgramming.ConstructProblems
{
    /// <summary>
    /// This class implements the CountConstruct algorithm in O(n*m^2) time and O(m^2) space.
    /// where m is the <c>target.Length</c> n <c>wordBank.Length</c>.
    /// </summary>
    public class MemoizedCountConstruct :ICountConstruct
    {
        private Dictionary<string, int> _memo;

        public MemoizedCountConstruct()
        {
            _memo = new Dictionary<string, int>();
        }
        
        /// <inheritdoc />
        public int CountConstruct(string target, string[] wordBank)
        {
            if (_memo.ContainsKey(target)) return _memo[target];
            if (string.IsNullOrEmpty(target)) return 1;

            int totalCount = 0;

            foreach (string word in wordBank)
            {
                if (target.IndexOf(word) == 0)
                {
                    int numWaysForRest = CountConstruct(target.Substring(word.Length), wordBank);
                    totalCount += numWaysForRest;
                }
            }

            _memo[target] = totalCount;
            return totalCount;
        }
    }
}