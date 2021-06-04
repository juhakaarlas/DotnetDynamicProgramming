using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Fibonacci
{
    /// <summary>
    /// This class implementes the Nth Fibonacci number calculation using memoization.
    /// It completes in O(n) time and space.
    /// </summary>
    public class MemoizedFibonacci : FibonacciBase
    {
        private Dictionary<int, int> _lookup;

        public MemoizedFibonacci()
        {
            _lookup = new Dictionary<int, int>();
        }
        
        /// <inheritdoc />
        public override int Fib(int n)
        {
            int value = BaseCase(n);

            if (value > -1)
            {
                return value;
            }

            if (_lookup.TryGetValue(n, out value))
            {
                return value;
            }

            value = Fib(n - 2) + Fib(n - 1);
            _lookup[n] = value;
            
            return value;
        }
    }
}
