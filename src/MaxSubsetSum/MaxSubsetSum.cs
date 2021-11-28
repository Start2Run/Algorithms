using System;
using System.Collections.Generic;

namespace MaxSubsetSum
{
    public class MaxSubsetSum
    {
        public static int GetMaxSubsetSumRec(int[] arr, int index, Dictionary<int, int> dic)
        {
            if (arr.Length == 0) return 0;
            if (arr.Length == 1) return arr[0];
            if (dic.ContainsKey(index)) return dic[index];
            if (index >= arr.Length) return 0;

            var max = 0;
            for (var i = index; i < arr.Length; i++)
            {
                var sum = GetMaxSubsetSumRec(arr, i + 2, dic);
                max = Math.Max(sum, max);
            }
            if (!dic.ContainsKey(index))
            {
                dic.Add(index, arr[index] + max);
            }
          
            return arr[index] + max;
        }
    }
}
