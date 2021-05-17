using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimalHeaviestSetA
{
    public static class MinimalHeaviestSetA
    {
        public static List<int> MinimalHeaviestSetAMethod(List<int> arr)
        {
            Console.WriteLine(string.Join(",", arr));
            var sortedArr = arr.OrderBy(x => x).ToList();
            var a = new List<int>();
            var b = new List<int>();
            var sumA = 0;
            var sumB = 0;
            var j = arr.Count - 1;


            for (int i = 0; i < j + 1; i++)
            {
                if (sumA <= sumB + sortedArr[i])
                {
                    sumA += sortedArr[j];
                    a.Add(sortedArr[j--]);
                }

                if (j < i)
                {
                    break;
                }

                sumB += sortedArr[i];
                b.Add(sortedArr[i]);
            }

            return a;
            }
        }
    }