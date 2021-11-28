using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringReduction;
using System;
using Xunit;

namespace StringReductionTests
{
    [TestClass]
    public class StringReductionTests : Helper.TestHelper
    {
        #region Public Methods

        [Theory]
        [MemberData(nameof(GetData), " UnitTests.TestCases.TestCase1")]
        public void Test1(string s, int expected)
        {
            var t = new StringReductionHelper();
            var result = t.StringReduction(s);
            Xunit.Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(GetData), " UnitTests.TestCases.TestCase2")]
        public void Test2(string s, int expected)
        {
            var t = new StringReductionHelper();
            var result = t.StringReduction(s);
            Xunit.Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("ccaacbabbccbcca", 2)]
        public void TestMethodCustom(string s, int expected)
        {
            var t = new StringReductionHelper();
            var result = t.StringReduction(s);
            Xunit.Assert.Equal(expected, result);
            var reduction = @"ccaacbabbccbcca
                              cbacbabbccbcca
                              cccbabbccbcca
                              ccaabbccbcca
                              ccacbccbcca
                              ccaaccbcca
                              ccabcbcca
                              ccaabcca
                              ccaccca
                              ccaccb
                              cbccb
                              cacb
                              cbb
                              ab
                              c";
        }

        #endregion
    }
}
