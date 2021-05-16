using System.Linq;

namespace Equal
{
    using System;
    using Newtonsoft.Json;
    using Unchase.FluentPerformanceMeter;
    using Unchase.FluentPerformanceMeter.Attributes;
    using Unchase.FluentPerformanceMeter.Models;

    public class EqualHelper
    {

        private IPerformanceInfo<EqualHelper> m_performance = new PerformanceInfo<EqualHelper>();

        [IgnoreMethodPerformance]
        public int Equal(int[] arr)
        {
            Array.Sort(arr);

            var result= GetCount(arr);
            GetCount(arr);
            GetCount(arr);
            GetCount(arr);
            var performance = JsonConvert.SerializeObject(PerformanceMeter<EqualHelper>.PerformanceInfo);

            return result;
        }

        private int GetCount(int[] sortedArr)
        {
            using (PerformanceMeter<EqualHelper>.StartWatching<int[],int>(GetCount))
            {
                var pieces = new[] { 5, 2, 1 };
                var iterations = new int[pieces.Max() + 1];
                var firstItem = sortedArr[0];
                for (int i = 0; i < sortedArr.Length; i++)
                {
                    var dif = sortedArr[i] - firstItem;
                    if (dif == 0)
                    {
                        continue;
                    }

                    foreach (var pieceCount in pieces)
                    {
                        while (pieceCount <= dif)
                        {
                            dif -= pieceCount;
                            iterations[pieceCount] += 1;
                        }
                    }
                }
                return iterations.Sum();
            }
        }
    }
}
