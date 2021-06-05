using Xunit;

namespace DynamicProgramming.GridTraveler.Tests
{
    /// <summary>
    /// Test data from <see href=""/>
    /// </summary>
    public class MemoizedGridTravelerTests
    {
        [Theory]
        [InlineData(2, 3, 3)]
        [InlineData(3, 2, 3)]
        [InlineData(3, 3, 6)]
        [InlineData(18,  18, 2333606220)]
        public void Calculates_Examples_Correctly(int w, int h, long expected)
        {
            var testee = new MemoizedGridTraveler();
            Assert.Equal(expected, testee.GridTraveler(w, h));
        }
    }
}
