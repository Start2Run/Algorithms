using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace ContainerWithMostWaterTests
{
    using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    [TestClass]
    public class ContainerWithMostWaterTests
    {
        [Theory]
        [InlineData(new[] { 1, 1 }, 1)]
        [InlineData(new[] { 4, 3, 2, 1, 4 }, 16)]
        [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        public void TestMethod1(int[] height, int expected)
        {
            var result = ContainerWithMostWater.ContainerWithMostWater.MaxArea(height);
            Assert.AreEqual(expected, result);
        }
    }
}
