using System.Collections.Generic;
using System.Linq;

namespace DictionariesAndHashmaps
{
    public class FrequencyQueries
    {
        public static List<int> Execute(List<List<int>> queries)
        {
            var dic1 = new Dictionary<int, int>();
            var dic2 = new Dictionary<int, List<int>>();
            var result = new List<int>();
            foreach (var q in queries)
            {
                var operation = q[0];
                var parameter = q[1];
                if (!dic1.ContainsKey(parameter))
                {
                    dic1.Add(parameter, 0);
                }
                switch (operation)
                {
                    case 1:
                        dic1[parameter]++;
                        if (!dic2.ContainsKey(dic1[parameter]))
                        {
                            dic2.Add(dic1[parameter], new List<int>());
                        }
                        dic2[dic1[parameter]].Add(parameter);
                        break;
                    case 2:
                        if (dic2.ContainsKey(dic1[parameter]))
                        {
                            dic2[dic1[parameter]].Remove(parameter);
                        }

                        if (dic1[parameter] > 0)
                        {
                            dic1[parameter]--;
                        }
                        break;
                    case 3:
                        var c = dic2.ContainsKey(parameter) ? dic2[parameter].Any() ? 1 : 0 : 0;
                        if (c == 1)
                        {
                        }
                        result.Add(c);
                        break;
                }
            }
            return result;
        }
    }
}
