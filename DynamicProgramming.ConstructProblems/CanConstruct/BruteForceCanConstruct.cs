namespace DynamicProgramming.ConstructProblems
{
    /// <summary>
    /// Problem Statement (from freeCodeCamp.org)
    /// <para>
    /// Write a method <c>CanConstruct(string target, string[] wordBank)</c> that accepts
    /// <c>target</c> string and an array of strings as arguments.
    /// </para>
    /// <para>
    /// The method should return a boolean indicating whether or not the <c>target</c>
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
    public class BruteForceCanConstruct : ICanConstruct
    {
        public bool CanConstruct(string target, string[] wordBank)
        {
            if (string.IsNullOrEmpty(target)) return true;

            foreach (string word in wordBank)
            {
                if (target.IndexOf(word) == 0)
                {
                    string suffix = target.Substring(word.Length);
                    if (CanConstruct(suffix, wordBank))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
