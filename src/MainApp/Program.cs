using System.Collections.Generic;

namespace MainApp
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            //var max = MaxSubsetSum.MaxSubsetSum.GetMaxSubsetSumRec(new int[] { 0, 1, 2, 3, 4 },0, new Dictionary<int, int>());
            //var max = MaxSubsetSum.MaxSubsetSum.GetMaxSubsetSumRec(new int[] { -2, 1, 3,-4, 5 });
            var max = MaxSubsetSum.MaxSubsetSum.GetMaxSubsetSumRec(new int[] { 3, 5, - 7, 8, 10 },0, new Dictionary<int, int>());
        }
    }
}
