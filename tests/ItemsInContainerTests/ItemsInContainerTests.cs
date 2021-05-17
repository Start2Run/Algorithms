using System.Linq;
using Xunit;

namespace ItemsInContainerTests
{
    public class ItemsInContainerTests
    {
        [Theory]
        //[InlineData("|**|*|*", new[] { 1, 1 }, new[] { 5, 6 }, new[] { 2, 3 })]
        [InlineData("******|******||***||||||||**|*|", new[] { 2, 7, 8 }, new[] { 9, 14, 20 }, new[] { 0, 6, 3 })]
        public void TestMethod1(string s, int[] startIndices, int[] endIndices, int[] expected)
        {
            var result = ItemsInContainer.ItemsInContainer.ItemsInContainerMethod(s, startIndices.ToList(), endIndices.ToList());

            Assert.Equal(expected, result);
        }
    }
}
