using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.ConstructProblems
{
    /// <summary>
    /// Problem Statement (from freeCodeCamp.org)
    /// <para>
    /// Write a method <c>CountConstruct(string target, string[] wordBank)</c> that accepts
    /// <c>target</c> string and an array of strings as arguments.
    /// </para>
    /// <para>
    /// The method should return the number of ways that the <c>target</c>
    /// can be constructed by concatenating elements of the <c>wordBank</c> array.
    /// </para>
    /// <para>
    /// You may reuse elements of <c>wordBank</c> as many times as needed.
    /// </para>
    /// <para>
    /// This class implements the algorithm in O(m*n^m) time and O(m^2) space
    /// where m is the <c>target.Length</c> n <c>wordBank.Length</c>.
    /// </para>
    /// </summary>
    public class BruteForceCountConstruct : ICountConstruct
    {
        /// <inheritdoc />
        public int CountConstruct(string target, string[] wordBank)
        {
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

            return totalCount;
        }
    }
}
