namespace DynamicProgramming.ConstructProblems
{
    public interface ICanConstruct
    {
        /// <summary>
        /// Determines if the given target string can be constructed by concatenating
        /// words from the given word bank.
        /// </summary>
        /// <param name="target">The target string</param>
        /// <param name="wordBank">The word bank</param>
        /// <returns><c>true</c> if the word can be constructed, otherwise <c>false</c></returns>
        bool CanConstruct(string target, string[] wordBank);
    }
}