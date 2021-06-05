using System.Collections.Generic;
using Xunit;

namespace DynamicProgramming.SumProblems.HowSum.Tests
{
    /// <summary>
    /// Test dataset from <see href="https://youtu.be/oBt53YbR9Kk?t=6181">freeCodeCamp.org</see>
    /// </summary>
    public class BruteForceHowSumTests
    {
        [Theory]
        [InlineData(7, new int[] { 2, 4 })]
        public void Returns_Null_When_No_Solution_Exists(int targetSum, int[] numbers)
        {
            var testee = new BruteForceHowSum();

            Assert.Null(testee.HowSum(targetSum, numbers));
        }

        [Theory]
        [InlineData(7, new int[] { 2, 3 }, new int[] { 3, 2, 2 })]
        [InlineData(7, new int[] { 5, 3, 4, 7 }, new int[] { 4, 3 })]
        [InlineData(8, new int[] { 2, 3, 5 }, new int[] { 2, 2, 2, 2 })]
        public void Calculates_Examples_Correctly(int targetSum, int[] numbers, int[] expected)
        {
            var expectedResult = new List<int>(expected);
            var testee = new BruteForceHowSum();

            Assert.Equal(expectedResult, testee.HowSum(targetSum, numbers));
        }
    }
}