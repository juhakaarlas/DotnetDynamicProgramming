using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace DynamicProgramming.BestSum.Tests
{
    public class MemoizedBestSumTests
    {
        [Fact]
        public void Handles_Base_Cases()
        {
            var testee = new MemoizedBestSum();

            var shouldBeNull = testee.BestSum(-1, null);
            var shouldBeZero = testee.BestSum(0, null);

            Assert.Null(shouldBeNull);
            shouldBeZero.Should().BeEquivalentTo(new List<int>());
        }

        [Theory]
        [InlineData(7, new int[] { 5, 3, 4, 7 }, new int[] { 7 })]
        [InlineData(8, new int[] { 2, 3, 5 }, new int[] { 3, 5 })]
        [InlineData(8, new int[] { 1, 4, 5 }, new int[] { 4, 4 })]
        [InlineData(100, new int[] { 1, 2, 5, 25 }, new int[] { 25, 25, 25, 25 })]
        public void Calculates_Examples_Correctly(int targetSum, int[] numbers, int[] expected)
        {
            var testee = new MemoizedBestSum();
            var expectedList = new List<int>(expected);
            var actual = testee.BestSum(targetSum, numbers);

            actual.Should().BeEquivalentTo(expectedList);
        }
    }
}