namespace DynamicProgramming.ConstructProblems
{
    public interface IAllConstruct
    {
        /// <summary>
        /// Finds out all the possible ways of constructing the target word by
        /// concatenating the words given in the word bank.
        /// </summary>
        /// <param name="target">The target word</param>
        /// <param name="wordBank">The word bank</param>
        /// <returns>A jagged array of all the possible constructions</returns>
        string[][] AllConstruct(string target, string[] wordBank);
    }
}