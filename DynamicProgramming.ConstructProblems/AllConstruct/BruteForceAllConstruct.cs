using System;
using System.Linq;

namespace DynamicProgramming.ConstructProblems
{
    /// <summary>
    /// Problem Statement (from freeCodeCamp.org)
    /// <para>
    /// Write a method <c>ASllConstruct(string target, string[] wordBank)</c> that accepts
    /// <c>target</c> string and an array of strings as arguments.
    /// </para>
    /// <para>
    /// The method should return a jagged *) array containing <i>all of the ways</i> that the
    /// <c>target</c> can be constructed by concatenating elements of the
    /// <c>wordBank</c> array. Each element of the jagged array should represent one
    /// combination that constructs the <c>target</c>.
    /// </para>
    /// <para>*) The <see href="https://youtu.be/oBt53YbR9Kk?t=10083">tutorial</see> describes
    /// this as a 2D array but in C# it's really a jagged array because the elements
    /// (or member arrays) can be of different sizes.
    /// </para>
    /// <para>
    /// You may reuse elements of <c>wordBank</c> as many times as needed.
    /// </para>
    /// <para>
    /// This class implements the algorithm in O(n^m) time and O(m) space
    /// where m is the <c>target.Length</c> n <c>wordBank.Length</c>.
    /// </para>
    /// </summary>
    public class BruteForceAllConstruct : IAllConstruct
    {
        /// <inheritdoc />
        public string[][] AllConstruct(string target, string[] wordBank)
        {
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
                        suffixWays = new string[][] {new[] {word}};
                        result = result.Append(new []{word}).ToArray();
                        continue;
                    }

                    foreach (var way in suffixWays)
                    {
                        result = result.Append(way.Prepend(word).ToArray()).ToArray();
                    }
                }
            }

            return result;
        }
    }
}