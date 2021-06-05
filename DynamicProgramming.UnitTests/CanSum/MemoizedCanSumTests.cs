using Xunit;

namespace DynamicProgramming.CanSum.Tests
{
    public class MemoizedCanSumTests
    {
        [Fact]
        public void MemoizedCanSum_Handles_Zero_TargetSum()
        {
            var testee = new MemoizedCanSum();
            Assert.True(testee.CanSum(0, null));
        }

        [Fact]
        public void MemoizedCanSum_Handles_Negative_TargetSum()
        {
            var testee = new MemoizedCanSum();
            Assert.False(testee.CanSum(-1, null));
        }

        [Theory]
        [InlineData(7, new int[] { 2, 4 })]
        [InlineData(300, new int[] { 7, 14 })]
        public void MemoizedCanSum_Calculates_False_Examples_Correctly(long targetSum, int[] numbers)
        {
            var testee = new MemoizedCanSum();
            Assert.False(testee.CanSum(targetSum, numbers));
        }

        [Theory]
        [InlineData(7, new int[] { 2, 3 })]
        [InlineData(8, new int[] { 2, 3, 5 })]
        [InlineData(7, new int[] { 3, 4, 5, 7 })]
        public void MemoizedCanSum_Calculates_True_Examples_Correctly(long targetSum, int[] numbers)
        {
            var testee = new MemoizedCanSum();
            Assert.True(testee.CanSum(targetSum, numbers));
        }
    }
}