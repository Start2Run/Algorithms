using System.Collections.Generic;
using System.Linq;

namespace SherlockAndAnagrams
{
    using System.Diagnostics;

    public class SherlockAndAnagrams
    {
        public static int Calculate(string s)
        {
            var result = 0;
            var collection = new Dictionary<string,int>();

            for (var i = 0; i < s.Length; i++)
            {
                var substring = s[i].ToString();

                if (collection.ContainsKey(substring))
                {
                    collection[substring]++; 
                    result += collection[substring];
                    Debug.WriteLine(substring);
                }
                else
                {
                    collection.Add(substring,0);
                }
                
                for (var j = i+1; j < s.Length; j++)
                {
                    substring += s[j];
                    var sortedString = string.Join("",substring.OrderBy(x => x));
                    if (collection.ContainsKey(sortedString))
                    {
                        collection[sortedString]++;
                        result+= collection[sortedString];
                        Debug.WriteLine(substring);
                    }
                    else
                    {
                        collection.Add(sortedString, 0);
                    }
                }
            }
            return result;
        }
    }
}
