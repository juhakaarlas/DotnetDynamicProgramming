using Xunit;

namespace DynamicProgramming.CanSum.Tests
{
    /// <summary>
    /// Test dataset from <see href="https://youtu.be/oBt53YbR9Kk?t=4921">freeCodeCamp.org</see>.
    /// </summary>
    public class MemoizedCanSumTests
    {
        [Fact]
        public void Handles_Zero_TargetSum()
        {
            var testee = new MemoizedCanSum();
            Assert.True(testee.CanSum(0, null));
        }

        [Fact]
        public void Handles_Negative_TargetSum()
        {
            var testee = new MemoizedCanSum();
            Assert.False(testee.CanSum(-1, null));
        }

        [Theory]
        [InlineData(7, new int[] { 2, 4 })]
        [InlineData(300, new int[] { 7, 14 })]
        public void Calculates_False_Examples_Correctly(long targetSum, int[] numbers)
        {
            var testee = new MemoizedCanSum();
            Assert.False(testee.CanSum(targetSum, numbers));
        }

        [Theory]
        [InlineData(7, new int[] { 2, 3 })]
        [InlineData(8, new int[] { 2, 3, 5 })]
        [InlineData(7, new int[] { 3, 4, 5, 7 })]
        public void Calculates_True_Examples_Correctly(long targetSum, int[] numbers)
        {
            var testee = new MemoizedCanSum();
            Assert.True(testee.CanSum(targetSum, numbers));
        }

        [Fact]
        public void Same_Input_Produces_Consistent_Results()
        {
            int[] numbersFor8 = new int[] { 2, 3, 5 };
            int[] numbersFor7 = new int[] { 3, 4, 5, 7 };
            var testee = new MemoizedCanSum();

            bool first8Result = testee.CanSum(8, numbersFor8);
            bool sevenResult = testee.CanSum(7, numbersFor7);
            bool second8Result = testee.CanSum(8, numbersFor8);

            Assert.True(first8Result);
            Assert.True(sevenResult);
            Assert.True(second8Result);
        }
    }
}