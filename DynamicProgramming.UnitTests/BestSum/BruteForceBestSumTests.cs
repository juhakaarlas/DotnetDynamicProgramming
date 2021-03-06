using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace DynamicProgramming.BestSum.Tests
{
    /// <summary>
    /// Test dataset from <see href="https://youtu.be/oBt53YbR9Kk?t=7051">freeCodeCamp.org</see>
    /// </summary>
    public class BruteForceBestSumTests
    {
        [Fact]
        public void Handles_Base_Cases()
        {
            var testee = new BruteForceBestSum();
            
            var shouldBeNull = testee.BestSum(-1, null);
            var shouldBeZero = testee.BestSum(0, null);

            Assert.Null(shouldBeNull);
            shouldBeZero.Should().BeEquivalentTo(new List<int>());
        }

        [Theory]
        [InlineData(7, new int[]{5, 3, 4, 7}, new int[] { 7 })]
        [InlineData(8, new int[] { 2, 3, 5 }, new int[] { 3, 5 })]
        [InlineData(8, new int[] { 1, 4, 5 }, new int[] { 4, 4 })]
        public void Calculates_Examples_Correctly(int targetSum, int[] numbers, int[] expected)
        {
            var testee = new BruteForceBestSum();
            var expectedList = new List<int>(expected);

            expectedList.Should().BeEquivalentTo(testee.BestSum(targetSum, numbers));
        }
    }
}
