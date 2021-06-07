using Xunit;

namespace DynamicProgramming.ConstructProblems.Tests
{
    /// <summary>
    /// Test dataset from <see href="https://youtu.be/oBt53YbR9Kk?t=8687">freeCodeCamp.org</see>.
    /// </summary>
    public class BruteForceCanConstructTests
    {
        [Theory]
        [InlineData("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }, true)]
        [InlineData("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" },false)]
        [InlineData("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }, true)]
        public void Calculates_Example_Cases_Correctly(string target, string[] wordBank, bool expected)
        {
            var testee = new BruteForceCanConstruct();

            if (expected)
            {
                Assert.True(testee.CanConstruct(target, wordBank));
            }
            else
            {
                Assert.False(testee.CanConstruct(target, wordBank));
            }
        }
    }
}