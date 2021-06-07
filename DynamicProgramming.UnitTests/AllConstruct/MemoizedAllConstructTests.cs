using Xunit;
using FluentAssertions;

namespace DynamicProgramming.ConstructProblems.Tests
{
    /// <summary>
    /// Test dataset from <see href="https://youtu.be/oBt53YbR9Kk?t=11307">freeCodeCamp.org</see>
    /// </summary>
    public class MemoizedAllConstructTests
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
            var testee = new MemoizedAllConstruct();

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
            var testee = new MemoizedAllConstruct();

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
            var testee = new MemoizedAllConstruct();

            // Act
            var result = testee.AllConstruct(target, wordBank);

            // Assert
            result.Should().BeEquivalentTo(expectation);
        }

        [Fact]
        public void Handles_Mean_Input_Correctly()
        {
            // Arrange
            const string target = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaz";
            string[] wordBank = { "a", "aa", "aaa", "aaaa", "aaaaa" };
            string[][] expectation = System.Array.Empty<string[]>();
            var testee = new MemoizedAllConstruct();

            // Act
            var result = testee.AllConstruct(target, wordBank);

            // Assert
            result.Should().BeEquivalentTo(expectation);
        }
    }
}