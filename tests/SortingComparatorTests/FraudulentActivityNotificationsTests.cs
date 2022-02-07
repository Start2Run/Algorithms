// ==========================================================================
// Copyright (C) 2022 by Genetec, Inc.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// ==========================================================================

namespace SortingTests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Xunit;
    using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    [TestClass]
    public class FraudulentActivityNotificationsTests
    {

        [Theory]
        [InlineData(new int[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 }, 5, 2)]
        public void TestMethod(int[] data, int d, int expected)
        {
            var result = Sorting.FraudulentActivityNotifications.ActivityNotifications(data.ToList(), d);
            Assert.AreEqual(expected, result);
        }
    }
}
