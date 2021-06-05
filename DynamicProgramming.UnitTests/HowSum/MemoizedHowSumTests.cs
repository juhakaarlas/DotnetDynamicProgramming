using Xunit;
using System.Collections.Generic;

namespace DynamicProgramming.SumProblems.HowSum.Tests
{
    public class MemoizedHowSumTests
    {
        [Theory]
        [InlineData(7, new int[] { 2, 4 })]
        [InlineData(300, new int[] { 7, 14 })]
        public void Returns_Null_When_No_Solution_Exists(int targetSum, int[] numbers)
        {
            var testee = new MemoizedHowSum();
            Assert.Null(testee.HowSum(targetSum, numbers));
        }

        [Theory]
        [InlineData(7, new int[] { 2, 3 }, new int[] { 3, 2, 2 })]
        [InlineData(7, new int[] { 5, 3, 4, 7 }, new int[] { 4, 3 })]
        [InlineData(8, new int[] { 2, 3, 5 }, new int[] { 2, 2, 2, 2 })]
        public void Calculates_Examples_Correctly(int targetSum, int[] numbers, int[] expected)
        {
            var expectedResult = new List<int>(expected);
            var testee = new MemoizedHowSum();

            Assert.Equal(expectedResult, testee.HowSum(targetSum, numbers));
        }
    }
}