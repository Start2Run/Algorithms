using CoinChange;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Xunit;

namespace CoinChangeTests
{
    [TestClass]
    public class CoinChangeUnitTests
    {
        [Theory]
        [InlineData(10, new long[] { 2, 5, 3, 6 }, 5)]
        [InlineData(4, new long[] { 1, 2, 3 }, 4)]
        //[InlineData(166, new long[] { 5, 37, 8, 39, 33, 17, 22, 32, 13, 7, 10, 35, 40, 2, 43, 49, 46, 19, 41, 1, 12, 11, 28 }, 96190959)]
        public void TestCase1(int sum, long[] coins, long expected)
        {
            var t = new CoinChangeHelper();
            var result = t.GetWays(sum, coins.ToList());
            Xunit.Assert.Equal(expected, result);
        }

        [Theory]
        //[InlineData(10, new long[] { 2, 5, 3, 6 }, 5)]
        //[InlineData(4, new long[] { 1, 2, 3 }, 4)]
        [InlineData(
            166,
            new long[] { 5, 37, 8, 39, 33, 17, 22, 32, 13, 7, 10, 35, 40, 2, 43, 49, 46, 19, 41, 1, 12, 11, 28 },
            96190959)]
        public void TestCase2(int sum, long[] coins, long expected)
        {
            var t = new CoinChangeHelper();
            var result = t.GetWays1(sum, coins);
            Xunit.Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(10, new long[] { 2, 5, 3, 6 }, 5)]
        //[InlineData(4, new long[] { 1, 2, 3 }, 4)]
        //[InlineData(166, new long[] { 5, 37, 8, 39, 33, 17, 22, 32, 13, 7, 10, 35, 40, 2, 43, 49, 46, 19, 41, 1, 12, 11, 28 }, 96190959)]
        public void TestCase3(int sum, long[] coins, long expected)
        {
            var t = new CoinChangeHelper();
            var result = t.GetWays2(coins, coins.Length, sum);
            Xunit.Assert.Equal(expected, result);
        }

    }
}