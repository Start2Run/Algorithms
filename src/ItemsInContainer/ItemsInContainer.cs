using System.Collections.Generic;

namespace ItemsInContainer
{
    using System.Linq;

    //  Given a string s consisting of items as "*" and closed compartments as an open and close "|", an array of starting indices startIndices, and an array of ending indices         endIndices, determine the number of items in closed compartments within the substring between the two indices, inclusive.

    //  An item is represented as an asterisk *
    //  A compartment is represented as a pair of pipes | that may or may not have items between them.
    //  Example:
    //  s = '|**|*|*'
    //  startIndices = [1,1]
    //  endIndices = [5,6]

    //  The String has a total 2 closed compartments, one with 2 items and one with 1 item.For the first par of indices, (1, 5), the substring is '|**|*'. There are 2 items in a     compartment.
    //  For the second pair of indices, (1,6), the substring is '|**|*|' and there 2+1=3 items in compartments.
    //  Both of the answers are returned in an array. [2,3].


    public class ItemsInContainer
    {
        public static List<int> ItemsInContainerMethod(string s, List<int> startIndices, List<int> endIndices)
        {
            var result = new List<int>();

            for (var i = 0; i < startIndices.Count; i++)
            {
                var start = startIndices[i] - 1;
                var end = endIndices[i] - 1;

                for (var j = start; j < end; j++)
                {
                    if (s[start] != '|')
                    {
                        start++;
                        continue;
                    }
                    break;
                }

                for (var k = end; k > start; k--)
                {
                    if (s[end] != '|')
                    {
                        end--;
                        continue;
                    }
                    break;
                }
                var substring = s.Substring(start, end - start);
                result.Add(substring.Count(x => x.Equals('*')));
            }

            return result;
        }

        //public static List<int> ItemsInContainerMethod(string s, List<int> startIndices, List<int> endIndices)
        //{
        //    int[] arr = new int[s.Length];
        //    int count = 0;

        //    for (var i = 0; i < s.Length; i++)
        //    {
        //        if (s[i] == '|')
        //        {
        //            arr[i] = count;
        //            continue;
        //        }
        //        ++count;
        //    }

        //    var result = new List<int>();
        //    for (int i = 0; i < startIndices.Count; i++)
        //    {
        //        int start = startIndices[i] - 1;
        //        int end = endIndices[i] - 1;
        //        while (s[start] != '|' && start < end)
        //        {
        //            ++start;
        //        }

        //        while (s[end] != '|' && end > 0)
        //        {
        //            --end;
        //        }
        //        result.Add(Math.Max(arr[end] - arr[start],0));
        //    }

        //    return result;
        //}
    }
}
