namespace DynamicProgramming.Fibonacci
{
    interface IFibonacci
    {
        /// <summary>
        /// Returns the Nth number in the Fibonacci series.
        /// </summary>
        /// <param name="n">The number n for which the Fibonacci number should be calculated.</param>
        /// <returns>The Nth Fibonacci number</returns>
        long Fib(long n);
    }
}
