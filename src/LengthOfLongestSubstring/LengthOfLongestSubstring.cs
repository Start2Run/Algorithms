using System;

namespace Algorithms
{
    public class LengthOfLongestSubstring
    {
        public static int LengthOfLongestSubstringMethod(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var result = 0;
            var ls = string.Empty;
            var i = 0;

            while (i < s.Length)
            {
                var c = s[i];

                var indexOfc = ls.IndexOf(c);
                if (indexOfc != -1)
                {
                    if (result < ls.Length)
                    {
                        result = Math.Max(ls.Length, result);
                    }

                    i = 0;
                    s = s.Remove(0, indexOfc + 1);
                    ls = string.Empty;
                    continue;
                }
                i++;

                ls += c;
            }
            return Math.Max(ls.Length, result);
        }
    }
}