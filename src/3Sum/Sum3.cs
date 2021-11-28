using System;
using System.Collections.Generic;
using System.Linq;

namespace _3Sum
{
    public class Sum3
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new Dictionary<string, IList<int>>();

            if (nums.Count() < 3)
            {
                return result.Values.ToList();
            }

            var sorted = nums.ToList().OrderBy(x => x).ToList();

            var firstPositiveIndex = 0;
            for (var i = 0; i < sorted.Count(); i++)
            {
                if (sorted[i] >= 0)
                {
                    firstPositiveIndex = i;
                    break;
                }
            }

            if (sorted.Where(x => x == 0).Count() >= 3)
            {
                result.Add("000", new List<int> { 0, 0, 0 });
            }


            if (firstPositiveIndex == 0)
            {
                return result.Values.ToList();
            }

            var n = sorted.Count();
            for (var i = 0; i < n; i++)
            {
                var j = i + 1;
                var k = n - 1;
                while (j < k)
                {
                    var s = sorted[i] + sorted[j] + sorted[k];
                    if (s == 0)
                    {
                        var lst = new List<int> { sorted[i], sorted[j], sorted[k] }.OrderBy(x => x).ToList();
                        var key = string.Join("", lst);
                        if (!result.ContainsKey(key))
                        {
                            result.Add(key, lst);
                        }

                        j++;
                    }
                    else if (s < 0)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            }

            return result.Values.ToList();
        }

        public int ThreeSumClosest(int[] nums, int target)
        {
            var dif = int.MaxValue;
            var sorted = nums.ToList().OrderBy(x => x).ToList();

            var n = sorted.Count();
            for (var i = 0; i < n; i++)
            {
                var j = i + 1;
                var k = n - 1;
                while (j < k && dif != 0)
                {
                    var sum = sorted[i] + sorted[j] + sorted[k];
                    if (Math.Abs(dif) > Math.Abs(target -sum))
                    {
                        dif = target - sum;
                    }

                    if (sum - target < 0)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            }
            return target-dif;
        }
    }
}
