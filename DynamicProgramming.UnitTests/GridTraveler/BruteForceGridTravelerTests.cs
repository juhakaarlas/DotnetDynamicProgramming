using Xunit;

namespace DynamicProgramming.GridTraveler.Tests
{
    /// <summary>
    /// Test dataset from <see href="https://youtu.be/oBt53YbR9Kk?t=2958">freeCodeCamp.org video</see>.
    /// </summary>
    public class BruteForceGridTravelerTests
    {
        [Fact]
        public void Basic_Traveler_Handles_Base_Case()
        {
            var testee = new BruteForceGridTraveler();
            Assert.Equal(1, testee.GridTraveler(1, 1));
        }

        [Fact]
        public void Basic_Traveler_Handles_Singularity()
        {
            var testee = new BruteForceGridTraveler();
            Assert.Equal(0, testee.GridTraveler(0, 1));
            Assert.Equal(0, testee.GridTraveler(1, 0));
        }

        [Theory]
        [InlineData(2, 3, 3)]
        [InlineData(3, 2, 3)]
        [InlineData(3, 3, 6)]
        public void Basic_Traveler_Calculates_Examples_Correctly(int m, int n, long expected)
        {
            var testee = new BruteForceGridTraveler();
            Assert.Equal(expected, testee.GridTraveler(m, n));
        }
    }
}
