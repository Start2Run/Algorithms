namespace MainApp
{
    using BenchmarkDotNet.Running;
    using CoinChange;

    internal static class Program
    {
        public static void Main(string[] args)
        {
            var coinChange = new CoinChangeHelper();
            // coinChange.GetWays(166, new long[] { 5, 37, 8, 39, 33, 17, 22, 32, 13, 7, 10, 35, 40, 2, 43, 49, 46, 19, 41, 1, 12, 11, 28 });
            var summary = BenchmarkRunner.Run<CoinChangeHelper>();
        }
    }
}
