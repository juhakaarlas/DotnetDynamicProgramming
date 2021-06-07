using Xunit;

namespace DynamicProgramming.ConstructProblems.Tests
{
    /// <summary>
    /// Test data set from <see href="https://youtu.be/oBt53YbR9Kk?t=8908">freeCodeCamp.org</see>. 
    /// </summary>
    public class MemoizedCanConstructTests
    {
        [Theory]
        [InlineData("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }, true)]
        [InlineData("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }, false)]
        [InlineData("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }, true)]
        [InlineData("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", 
                    new string[] { "e", "ee", "eee", "eeee", "eeee", "eeeee", "eeeeee" }, false)]
        public void Calculates_Example_Cases_Correctly(string target, string[] wordBank, bool expected)
        {
            var testee = new MemoizedCanConstruct();

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