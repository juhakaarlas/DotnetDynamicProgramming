using Xunit;

namespace DynamicProgramming.ConstructProblems.Tests
{
    /// <summary>
    /// Test dataset from <see href="https://youtu.be/oBt53YbR9Kk?t=9914">freeCodeCamp.org</see>.
    /// </summary>
    public class MemoizedCountConstructTests
    {
        [Theory]
        [InlineData("purple", new string[] { "purp", "p", "ur", "le", "purpl" }, 2)]
        [InlineData("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }, 1)]
        [InlineData("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }, 0)]
        [InlineData("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }, 4)]
        [InlineData("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
            new string[] { "e", "ee", "eee", "eeee", "eeee", "eeeee", "eeeeee" }, 0)]
        public void Calculates_Example_Cases_Correctly(string target, string[] wordBank, int expected)
        {
            var testee = new MemoizedCountConstruct();
            Assert.Equal(expected, testee.CountConstruct(target, wordBank));
        }
    }
}