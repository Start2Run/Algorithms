// ==========================================================================
// <copyright file="StringReductionTests.cs" company="Genetec">
//   Copyright (c) 2018 by Genetec
//   All rights reserved. May be used only in accordance with a valid Source Code License Agreement.
// </copyright>
// Created: 01/03/2021
// Last update: 05/03/2021
// ==========================================================================

namespace UnitTests
{
    using Helper;
    using StringReduction;
    using Xunit;

    public class StringReductionTests : TestHelper
    {
        #region Public Methods

        [Theory]
        [MemberData(nameof(GetData), " UnitTests.TestCases.TestCase1")]
        public void Test1(string s, int expected)
        {
            var t = new StringReductionHelper();
            var result = t.StringReduction(s);
            Assert.AreEqual(expected, result);
        }

        [Theory]
        [MemberData(nameof(GetData), " UnitTests.TestCases.TestCase2")]
        public void Test2(string s, int expected)
        {
            var t = new StringReductionHelper();
            var result = t.StringReduction(s);
            Assert.AreEqual(expected, result);
        }

        [Theory]
        [InlineData("ccaacbabbccbcca", 2)]
        public void TestMethodCustom(string s, int expected)
        {
            var t = new StringReductionHelper();
            var result = t.StringReduction(s);
            Assert.AreEqual(expected, result);
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
