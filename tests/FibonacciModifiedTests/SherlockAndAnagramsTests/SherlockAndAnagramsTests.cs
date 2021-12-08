using Xunit;

namespace SherlockAndAnagramsTests
{
    public class SherlockAndAnagramsTests
    {
        [Theory]
        [InlineData("abba", 4)]
        [InlineData("abcd", 0)]
        [InlineData("ifailuhkqq", 3)]
        [InlineData("cdcd", 5)]
        [InlineData("kkkk", 10)]
        public void TestCases(string s,int expected)
        {
            var result = SherlockAndAnagrams.SherlockAndAnagrams.Calculate(s);

            Assert.Equal(expected,result);
        }
    }
}
