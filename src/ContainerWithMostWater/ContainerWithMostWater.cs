namespace ContainerWithMostWater
{
    using System;

    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            var result = 0;
            var x1 = 0;
            var x2 = height.Length-1;
            while (x1 < x2)
            {
                var x1Height = height[x1];
                var x2Height = height[x2];

                var area = Math.Min(x1Height, x2Height) * (x2 - x1);
                result = Math.Max(result, area);
                if (x1Height > x2Height)
                {
                    x2--;
                }
                else
                {
                    x1++;
                }
            }

            return result;
        }
    }
}
