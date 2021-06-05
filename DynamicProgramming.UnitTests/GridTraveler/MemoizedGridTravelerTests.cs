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
        [InlineData(18, 18, 2333606220)]
        public void Calculates_Examples_Correctly(int w, int h, long expected)
        {
            var testee = new MemoizedGridTraveler();
            Assert.Equal(expected, testee.GridTraveler(w, h));
        }

        [Fact]
        public void Transposed_Grids_Return_Same_Result()
        {
            var testee = new MemoizedGridTraveler();
            
            var result3x2 = testee.GridTraveler(3, 2);
            var result2x3 = testee.GridTraveler(2, 3);

            Assert.Equal(result2x3, result3x2);
        }

        [Fact]
        public void Returns_Consistent_Results_For_Same_Input()
        {
            var testee = new MemoizedGridTraveler();

            var first3x2Result = testee.GridTraveler(3, 2);
            //Invoke intermediary calculation to check if internal state remains consistent
            testee.GridTraveler(5, 5);
            var second3x2Result = testee.GridTraveler(3, 2);

            Assert.Equal(first3x2Result, second3x2Result);
        }
    }
}
