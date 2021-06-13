namespace DynamicProgramming.Fibonacci
{
    /// <summary>
    /// This class implements the Fibonacci algorithm iteratively.
    /// It runs in O(n) time and O(1) space.
    /// </summary>
    public class IterativeFibonacci : IFibonacci
    {
        /// <inheritdoc/>
        public long Fib(long n)
        {
            long result = 0;
            long previous = 1;

            for (long i = 0; i < n ; i++)
            {
                long temp = result;
                result = previous;
                previous += temp;
            }

            return result;
        }
    }
}
