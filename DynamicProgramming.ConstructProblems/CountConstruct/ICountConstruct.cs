namespace DynamicProgramming.ConstructProblems
{
    public interface ICountConstruct
    {
        /// <summary>
        /// Calculates the number of ways a target string can be constructed
        /// by concatenating words from a given word bank.
        /// </summary>
        /// <param name="target">The target string</param>
        /// <param name="wordBank">The word bacnk</param>
        /// <returns>The number of ways the target string can be constructed</returns>
        int CountConstruct(string target, string[] wordBank);
    }
}