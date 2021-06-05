using System;
using Xunit;

namespace DynamicProgramming.Fibonacci.Tests
{
    public class BruteForceFibonacciTests
    {
        [Fact]
        public void Returns_Base_Cases_Correctly()
        {
            var testee = new BruteForceFibonacci();

            Assert.Equal(1, testee.Fib(1));
            Assert.Equal(1, testee.Fib(2));
        }

        [Fact]
        public void Returns_Zero_Correctly()
        {
            var testee = new BruteForceFibonacci();
            Assert.Equal(0, testee.Fib(0));
        }

        [Fact]
        public void Negatives_Throw_ArgumentException()
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
        public void Calculates_Examples_Correctly(int n, int expected)
        {
            var testee = new BruteForceFibonacci();
            Assert.Equal(expected, testee.Fib(n));
        }
    }
}
