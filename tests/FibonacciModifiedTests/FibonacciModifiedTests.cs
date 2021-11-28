using System.Numerics;
using Fibonacci_Modified;
using Xunit;

namespace FibonacciModifiedTests
{
    public class FibonacciModifiedTests
    {
        [Theory]
        [InlineData(0, 1, 5, 5)]
        [InlineData(0, 1, 6, 27)]
        public void TestCase(int t1, int t2, int n, BigInteger expected)
        {
            var result = FibonacciModified.FibonacciModifiedMethod(t1, t2, n);
            Assert.Equal(expected, result);
        }
    }
}
