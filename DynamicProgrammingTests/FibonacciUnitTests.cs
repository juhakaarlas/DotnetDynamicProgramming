using Fibonacci;
using Xunit;

namespace DynamicProgrammingTests
{
    
    public class FibonacciUnitTests
    {
        [Fact]
        public void BruteForceFibonacci_Returns_Base_Case()
        {
            var testee = new BruteForceFibonacci();

            Assert.Equal(1, testee.Fib(1));
        }
    }
}
