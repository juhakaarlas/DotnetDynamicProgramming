using Xunit;

namespace DynamicProgramming.CanSum.Tests
{
    /// <summary>
    /// Test dataset from <see href="https://youtu.be/oBt53YbR9Kk?t=4921">freeCodeCamp.org</see>.
    /// </summary>
    public class BruteForceCanSumTests
    {
        [Fact]
        public void Handles_Zero_TargetSum()
        {
            var testee = new BruteForceCanSum();
            Assert.True(testee.CanSum(0, null));
        }

        [Fact]
        public void Handles_Negative_TargetSum()
        {
            var testee = new BruteForceCanSum();
            Assert.False(testee.CanSum(-1, null));
        }

        [Theory]
        [InlineData(7, new int[]{2, 4})]
        public void Calculates_False_Examples_Correctly(long targetSum, int[] numbers)
        {
            var testee = new BruteForceCanSum();
            Assert.False(testee.CanSum(targetSum, numbers));
        }

        [Theory]
        [InlineData(7, new int[] { 2, 3 })]
        [InlineData(7, new int[] { 3, 4 })]
        [InlineData(8, new int[] { 2, 3, 5 })]
        public void Calculates_True_Examples_Correctly(long targetSum, int[] numbers)
        {
            var testee = new BruteForceCanSum();
            Assert.True(testee.CanSum(targetSum, numbers));
        }
    }
}
