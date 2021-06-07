using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicProgramming.ConstructProblems
{
    /// <summary>
    /// This class implements the AllConstruct problem with memoization.
    /// Formally its time complexity is still O(n^m) in the worst case,
    /// where m = <c>target.Length</c> and n = <c>wordBank.Length</c>.
    /// Space complexity is O(m).
    /// That said, it still runs considerably faster than <see cref="BruteForceAllConstruct"/>.
    /// Check the <see href="https://youtu.be/oBt53YbR9Kk?t=11325">video explanation</see>
    /// for more details.
    /// </summary>
    public class MemoizedAllConstruct : IAllConstruct
    {
        private Dictionary<string, string[][]> _memo;

        public MemoizedAllConstruct()
        {
            _memo = new Dictionary<string, string[][]>();
        }

        /// <inheritdoc />
        public string[][] AllConstruct(string target, string[] wordBank)
        {
            if (_memo.ContainsKey(target)) return _memo[target];
            if (string.IsNullOrEmpty(target)) return null;

            string[][] result = Array.Empty<string[]>();

            foreach (var word in wordBank)
            {
                if (target.IndexOf(word) == 0)
                {
                    var suffix = target.Substring(word.Length);
                    var suffixWays = AllConstruct(suffix, wordBank);

                    if (suffixWays == null)
                    {
                        suffixWays = new string[][] { new[] { word } };
                        result = result.Append(new[] { word }).ToArray();
                        continue;
                    }

                    foreach (var way in suffixWays)
                    {
                        result = result.Append(way.Prepend(word).ToArray()).ToArray();
                    }
                }
            }

            _memo[target] = result;
            return result;
        }
    }
}