using System.Collections.Generic;

namespace CoinChange
{
    using System;
    using System.Linq;
    using BenchmarkDotNet.Attributes;

    [MemoryDiagnoser]
    public class CoinChangeHelper
    {
        [Benchmark]
        [Arguments(10, new long[] { 2, 5, 3, 6 })]
        public long GetWays(long n, ICollection<long> c)
        {
            if (n == 0)
            {
                return 0;
            }

            if (c.Count == 0)
            {
                return 0;
            }

            long count = 0;
            Recursive(n, c.OrderBy(x => x).ToArray(), new long[0], ref count, 0);
            return count;
        }

        private void Recursive(long total, long[] coins, long[] currentItems, ref long count, int index)
        {
            var sum = currentItems.Sum();
            var result = currentItems.ToArray();
            Array.Resize(ref result, result.Length + 1);
            for (int i = index; i < coins.Length; i++)
            {
                var p = sum + coins[i];
                if (p > total)
                {
                    return;
                }
                result[result.Length - 1] = coins[i];
                if (p == total)
                {
                    count++;
                }
                else
                {
                    Recursive(total, coins, result, ref count, i);
                }
            }
        }

        [Benchmark]
        [Arguments(10, new long[] { 2, 5, 3, 6 })]
        public long GetWays1(int n, long[] c)
        {
            if (n == 0)
            {
                return 0;
            }

            if (c.Length == 0)
            {
                return 0;
            }

            long count = 0;
            Recursive(n, c.OrderBy(x => x).ToArray(), ref count, 0, 0);
            return count;
        }

        private void Recursive(int total, long[] coins, ref long count, int index, long sum)
        {
            for (int i = index; i < coins.Length; i++)
            {
                var p = sum + coins[i];
                if (p > total)
                {
                    return;
                }

                if (p == total)
                {
                    count++;
                }
                else
                {
                    Recursive(total, coins, ref count, i, sum + coins[i]);
                }
            }
        }

        public long GetWays2(long[] coins, long n, long total)
        {
            long[] table = new long[total + 1];
            table[0] = 1;
            for (int i = 0; i < n; i++)
            {
                for (long j = coins[i]; j <= total; j++)
                {
                    table[j] += table[j - coins[i]];
                }
            }
            return table[n];
        }
    }
}
