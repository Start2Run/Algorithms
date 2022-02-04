namespace Sorting
{
    public class MergeSortCountingInversions
    {
        public static long CountInversions(int[] data)
        {
            return SortMethod(data, 0, data.Length - 1);
        }

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
            var offset = -left;
            var leftEnd = mid - 1;
            var pivotPosition = left;
            var n = (right - left + 1);
            var temp = new int[n];

            while (left <= leftEnd && mid <= right)
            {
                if (numbers[left] <= numbers[mid])
                {
                    temp[offset + pivotPosition++] = numbers[left++];
                }
                else
                {
                    temp[offset + pivotPosition++] = numbers[mid++];
                    count+= (mid - pivotPosition);
                }
            }

            while (left <= leftEnd)
            {
                temp[offset + pivotPosition++] = numbers[left++];
            }

            while (mid <= right)
            {
                temp[offset + pivotPosition++] = numbers[mid++];
            }

            for (int i = 0; i < n; i++)
            {
                numbers[right] = temp[offset + right--];
            }
            return count;
        }
    }
}
