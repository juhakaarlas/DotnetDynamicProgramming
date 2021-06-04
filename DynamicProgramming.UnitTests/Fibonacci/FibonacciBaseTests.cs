using DynamicProgramming.Fibonacci;
using Xunit;

namespace DynamicProgramming.UnitTests
{
    public class FibonacciBaseTests : FibonacciBase
    {
        [Fact]
        public void BaseFibonacci_Returns_Base_Cases()
        {
            Assert.Equal(1, BaseCase(1));
            Assert.Equal(1, BaseCase(2));
        }

        [Fact]
        public void BaseFibonacci_Handles_Zero()
        {
            var testee = new BruteForceFibonacci();
            Assert.Equal(0, BaseCase(0));
        }

        public override long Fib(long n)
        {
            throw new System.NotImplementedException();
        }
    }
}
