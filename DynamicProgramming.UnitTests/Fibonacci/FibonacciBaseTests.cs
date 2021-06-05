using Xunit;

namespace DynamicProgramming.Fibonacci.Tests
{
    public class FibonacciBaseTests : FibonacciBase
    {
        [Fact]
        public void Returns_Base_Cases_Correctly()
        {
            Assert.Equal(1, BaseCase(1));
            Assert.Equal(1, BaseCase(2));
        }

        [Fact]
        public void Returns_Zero_Correctly()
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
