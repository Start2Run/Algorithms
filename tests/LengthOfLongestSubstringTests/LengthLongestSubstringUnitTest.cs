using Xunit;

namespace UnitTests
{
    public class LongestSubstringUnitTest
    {
        [Theory]
        [InlineData(@"", 0)]
        [InlineData(@"abcabcbb", 3)]
        [InlineData(@"bbbbb", 1)]
        [InlineData(@"pwwkew", 3)]
        [InlineData(@"loddktdji", 5)]
        [InlineData(@"eeydgwdykpv", 7)]
        [InlineData(@"wslznzfxojzd",6)]
        public void Test1(string input, int expected)
        {
            var result = Algorithms.LengthOfLongestSubstring.LengthOfLongestSubstringMethod(input);
            Assert.Equal(expected, result);
        }
    }
}
