using System.Collections.Generic;
using _3Sum;
using Xunit;

namespace _3SumTests
{
    public class Sum3Tests
    {
        [Theory]
        [InlineData(new int[] { -1, 0, 1, 2, -1, -4 })]
        public void Test1(int[] data)
        {
            var sum3 = new Sum3();
            var result = sum3.ThreeSum(data);
            var expected = new List<IList<int>> { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } };
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(new int[] { -1, 2, 1, -4 }, 1, 2)]
        [InlineData(new int[] { 1, 1,1, 0 }, -100, 2)]
        public void Test2(int[] data, int target, int expected)
        {
            var sum3 = new Sum3();
            var result = sum3.ThreeSumClosest(data, target);
            Assert.Equal(result, expected);
        }
    }
}
