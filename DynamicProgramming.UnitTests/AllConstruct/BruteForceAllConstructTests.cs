using FluentAssertions;
using Xunit;

namespace DynamicProgramming.ConstructProblems.Tests
{
    /// <summary>
    /// Test dataset from <see href="https://youtu.be/oBt53YbR9Kk?t=11174">freeCodeCamp.org</see>
    /// </summary>
    public class BruteForceAllConstructTests
    {
        [Fact]
        public void Returns_Purple_Combos_Correctly()
        {
            // Arrange
            const string target = "purple";
            string[] wordBank = { "purp", "p", "ur", "le", "purpl" };
            string[][] expectation =
            {
                new [] { "purp", "le" }, 
                new [] { "p", "ur", "p", "le" }
            };
            var testee = new BruteForceAllConstruct();

            // Act
            var result = testee.AllConstruct(target, wordBank);

            // Assert
            result.Should().BeEquivalentTo(expectation);
        }

        [Fact]
        public void Returns_Abcdef_Combos_Correctly()
        {
            // Arrange
            const string target = "abcdef";
            string[] wordBank = { "ab", "abc", "cd", "def", "abcd", "ef", "c" };
            string[][] expectation =
            {
                new []{ "ab", "cd", "ef" }, 
                new []{ "ab", "c", "def" }, 
                new []{"abc", "def"}, 
                new []{"abcd", "ef"}
            };
            var testee = new BruteForceAllConstruct();

            // Act
            var result = testee.AllConstruct(target, wordBank);

            // Assert
            result.Should().BeEquivalentTo(expectation);
        }

        [Fact]
        public void Returns_Skateboard_Combos_Correctly()
        {
            // Arrange
            const string target = "skateboard";
            string[] wordBank = { "bo", "rd", "ate", "t", "ska", "sk", "boar" };
            string[][] expectation = System.Array.Empty<string[]>();
            var testee = new BruteForceAllConstruct();

            // Act
            var result = testee.AllConstruct(target, wordBank);

            // Assert
            result.Should().BeEquivalentTo(expectation);
        }
    }
}