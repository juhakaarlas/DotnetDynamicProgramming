using DynamicProgramming.Fibonacci;
using System;
using Xunit;

namespace DynamicProgramming.UnitTests
{
    public class BruteForceFibonacciTests
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

        [Fact]
        public void BruteForceFibonacci_Negatives_Throw_ArgumentException()
        {
            var testee = new BruteForceFibonacci();
            Assert.Throws<ArgumentOutOfRangeException>( () => testee.Fib(-1));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        public void BruteForceFibonacci_Calculates_Correctly(int n, int expected)
        {
            var testee = new BruteForceFibonacci();
            Assert.Equal(expected, testee.Fib(n));
        }
    }
}
