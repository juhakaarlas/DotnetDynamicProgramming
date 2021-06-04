using DynamicProgramming.CanSum;
using Xunit;


namespace DynamicProgramming.UnitTests.CanSum
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
    }
}