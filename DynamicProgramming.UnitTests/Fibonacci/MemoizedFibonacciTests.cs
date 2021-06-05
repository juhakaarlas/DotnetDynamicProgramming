using Xunit;

namespace DynamicProgramming.Fibonacci.Tests
{
    /// <summary>
    /// Test dataset from <see href="https://youtu.be/oBt53YbR9Kk?t=1897">freeCodeCampl.org</see>
    /// </summary>
    public class MemoizedFibonacciTests
    {
        [Fact]
        public void Returns_Base_Cases_Correctly()
        {
            var testee = new MemoizedFibonacci();

            Assert.Equal(1, testee.Fib(1));
            Assert.Equal(1, testee.Fib(2));
        }

        [Fact]
        public void Returns_Zero_Correctly()
        {
            var testee = new MemoizedFibonacci();
            Assert.Equal(0, testee.Fib(0));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(3, 2)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(50, 12586269025)]
        public void Calculates_Examples_Correctly(long n, long expected)
        {
            var testee = new MemoizedFibonacci();
            Assert.Equal(expected, testee.Fib(n));
        }

        [Fact]
        public void Returns_Consistent_Results_For_Same_Input()
        {
            var testee = new MemoizedFibonacci();

            var firstResult = testee.Fib(4);
            var secondResult = testee.Fib(4);

            Assert.Equal(firstResult, secondResult);
        }
    }
}
