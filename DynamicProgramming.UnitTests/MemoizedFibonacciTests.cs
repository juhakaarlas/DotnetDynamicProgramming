using DynamicProgramming.Fibonacci;
using Xunit;

namespace DynamicProgramming.UnitTests
{
    public class MemoizedFibonacciTests
    {

        [Fact]
        public void BruteForceFibonacci_Returns_Base_Cases()
        {
            var testee = new BruteForceFibonacci();

            Assert.Equal(1, testee.Fib(1));
            Assert.Equal(1, testee.Fib(2));
        }

        [Fact]
        public void BruteForceFibonacci_Handles_Zero()
        {
            var testee = new BruteForceFibonacci();
            Assert.Equal(0, testee.Fib(0));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(3, 2)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(50, 12586269025)]
        public void MemoizedFibonacci_Calculates_Correctly(long n, long expected)
        {
            var testee = new MemoizedFibonacci();
            Assert.Equal(expected, testee.Fib(n));
        }
    }
}
