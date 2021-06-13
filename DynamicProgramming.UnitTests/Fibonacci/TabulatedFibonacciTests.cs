using Xunit;

namespace DynamicProgramming.Fibonacci.Tests
{
    public class TabulatedFibonacciTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(3, 2)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(50, 12586269025)]
        public void FibTest(int n, long expected)
        {
            var testee = new TabulatedFibonacci();
            Assert.Equal(expected, testee.Fib(n));
        }
    }
}