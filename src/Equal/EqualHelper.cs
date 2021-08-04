
namespace Equal
{
    using System.Linq;
    using System;

    public class EqualHelper
    {

        public int Equal(int[] arr)
        {
            Array.Sort(arr);

            var result = GetCount(arr);

            return result;
        }

        private static int GetCount(int[] sortedArr)
        {
            var pieces = new[] { 5, 2, 1 };
            var iterations = new int[pieces.Length + 1];
            var firstItem = sortedArr[0];
            for (int i = 0; i < sortedArr.Length; i++)
            {
                for (int j = 0; j < pieces.Length + 1; j++)
                {
                    var dif = sortedArr[i] - firstItem + j;
                    if (dif == 0)
                    {
                        continue;
                    }

                    foreach (var piece in pieces)
                    {
                        while (piece <= dif)
                        {
                            dif -= piece;
                            iterations[j] += 1;
                        }
                    }
                }
            }

            return iterations.Min();
        }
    }
}
