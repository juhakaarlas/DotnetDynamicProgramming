using System.Collections.Generic;

namespace DynamicProgramming.ConstructProblems
{
    /// <summary>
    /// /// <para>
    /// This class implements the CanConstruct algorithm in O(n*m^2) time and O(m^2) space
    /// where m is the <c>target.Length</c> n <c>wordBank.Length</c>.
    /// </para>
    /// </summary>
    public class MemoizedCanConstruct :ICanConstruct
    {
        private Dictionary<string, bool> _memo;

        public MemoizedCanConstruct()
        {
            _memo = new Dictionary<string, bool>();
        }

        /// <inheritdoc/>
        public bool CanConstruct(string target, string[] wordBank)
        {
            if (_memo.ContainsKey(target)) return _memo[target];
            if (string.IsNullOrEmpty(target)) return true;

            foreach (string word in wordBank)
            {
                if (target.IndexOf(word) == 0)
                {
                    string suffix = target.Substring(word.Length);
                    if (CanConstruct(suffix, wordBank))
                    {
                        _memo[target] = true;
                        return true;
                    }
                }
            }

            _memo[target] = false;
            return false;
        }

    }
}
