using System;
using System.Linq;

namespace Algorithms
{
    public class MyAtoi
    {
        public static int MyAtoiMethod(string s)
        {
            var foundSign = false;
            var isNegativeNumber = false;
            var spacesRemoved = false;
            var result = 0;
            var digits = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var signs = new[] { '+', '-' };
            var min = -(int)Math.Pow(2, 31);
            var max = -min - 1;

            foreach (var c in s)
            {
                if (c == ' ')
                {
                    if (!spacesRemoved)
                    {
                        continue;
                    }
                    return result;
                }

                spacesRemoved = true;

                if (Array.Exists(signs, x => x == c) && !foundSign)
                {
                    foundSign = true;
                    if (c == '-')
                    {
                        isNegativeNumber = true;
                    }
                    continue;
                }

                if (!digits.Contains(c))
                {
                    return result;
                }

                foundSign = true;

                var digit = int.Parse(c.ToString());
                if ((min + digit) / 10 > result)
                {
                    return min;
                }
                if ((max - digit) / 10 < result)
                {
                    return max;
                }

                if (isNegativeNumber)
                {
                    result = result * 10 - digit;
                }
                else
                {
                    result = result * 10 + digit;
                }
            }
            return result;
        }
    }
}
