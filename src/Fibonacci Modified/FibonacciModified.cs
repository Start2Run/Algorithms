namespace Fibonacci_Modified
{
    public class FibonacciModified
    {
        public static System.Numerics.BigInteger FibonacciModifiedMethod(int t1, int t2, int n)
        {
            System.Numerics.BigInteger previous = t1;
            System.Numerics.BigInteger next = t2;
            System.Numerics.BigInteger result = 0;
            for (var i = 2; i < n; i++)
            {
                result = previous + System.Numerics.BigInteger.Pow(next, 2);
                previous = next;
                next = result;
            }
            return result;
        }
    }
}
