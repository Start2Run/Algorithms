// ==========================================================================
// Copyright (C) 2022 by Genetec, Inc.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// ==========================================================================

namespace SortingTests.FraudulentActivityNotifications
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Xunit;
    using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    [TestClass]
    public class FraudulentActivityNotificationsTests
    {

        [Theory]
        [InlineData(TestCase1.Data, TestCase1.D, TestCase1.Expected)]
        [InlineData(TestCase2.Data, TestCase2.D, TestCase2.Expected)]
        [InlineData(TestCase3.Data, TestCase3.D, TestCase3.Expected)]
        [InlineData(TestCase4.Data, TestCase4.D, TestCase4.Expected)]
        [InlineData(TestCase5.Data, TestCase5.D, TestCase5.Expected)]
        [InlineData(TestCase6.Data, TestCase6.D, TestCase6.Expected)]
        public void TestMethod(string data, int d, int expected)
        {
            var actual = Sorting.FraudulentActivityNotifications.ActivityNotifications(data.Split(' ').Select(int.Parse).ToList(), d);
            Assert.AreEqual(expected, actual);
        }
    }
}
