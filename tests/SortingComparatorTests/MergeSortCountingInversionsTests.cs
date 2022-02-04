namespace SortingTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Xunit;
    using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    [TestClass]
    public class MergeSortCountingInversionsTests
    {
        [Theory]
        [InlineData(new int[] { 2, 1, 3, 1, 2 }, 4)]
        [InlineData(new int[] { 1, 1, 1, 2, 2 }, 0)]
        public void TestMethod(int[] data, int expected)
        {
            var result = Sorting.MergeSortCountingInversions.CountInversions(data);
            Assert.AreEqual(expected, result);
        }
    }
}
