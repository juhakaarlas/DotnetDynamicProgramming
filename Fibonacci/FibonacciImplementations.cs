using System;

namespace Fibonacci
{
    public class BruteForceFibonacci : IFibonacci
    {
        public int Fib(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException();
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;


            return Fib(n - 2) + Fib(n - 1);
        }
    }
}
