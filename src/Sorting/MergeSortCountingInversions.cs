namespace Sorting
{
    public static class MergeSortCountingInversions
    {
        public static long CountInversions(int[] data) => SortMethod(data, 0, data.Length - 1);

        private static long SortMethod(int[] numbers, int left, int right)
        {
            long count = 0;
            if (right <= left)
            {
                return count;
            }

            int mid = (left + right) / 2;
            count += SortMethod(numbers, left, mid);
            count += SortMethod(numbers, mid + 1, right);
            count += MergeMethod(numbers, left, mid + 1, right);
            return count;
        }

        private static long MergeMethod(int[] numbers, int left, int mid, int right)
        {
            long count = 0;

            var pivot = left;
            var leftEnd = mid - 1;
            var n = right - left + 1;
            var array = new int[n];
            var offset = -left;

            while (left <= leftEnd && mid <= right)
            {
                if (numbers[left] <= numbers[mid])
                {
                    array[offset+pivot++] = numbers[left++];
                }
                else
                {
                    array[offset + pivot++] = numbers[mid++];
                    count += mid - pivot;
                }
            }

            while (left <= leftEnd)
            {
                array[offset + pivot++] = numbers[left++];
            }

            while (mid <= right)
            {
                array[offset + pivot++] = numbers[mid++];
            }

            for (int i = 0; i < n; i++)
            {
                numbers[right] = array[offset + right--];
            }

            return count;
        }
    }
}
