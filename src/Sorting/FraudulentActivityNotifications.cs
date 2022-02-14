// ==========================================================================
// Copyright (C) 2022 by Genetec, Inc.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// ==========================================================================

namespace Sorting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class FraudulentActivityNotifications
    {
        public static int ActivityNotifications(List<int> expenditure, int d)
        {
            var result = 0;
            var subset = expenditure.GetRange(0, d).OrderBy(x => x).ToArray();
            var middle = d / 2;
            for (var i = d; i < expenditure.Count; i++)
            {
                var median = (d % 2 == 0) ? (double)(subset[middle - 1] + subset[middle]) / 2 : subset[middle];

                var goToLeft = true;
                var j = 0;
                for (var k = 0; k < d; k++)
                {
                    if (subset[k] != expenditure[i - d])
                    {
                        continue;
                    }

                    if (subset[k] <= expenditure[i])
                    {
                        goToLeft = false;
                    }

                    j = k;
                    subset[k] = expenditure[i];
                    break;
                }

                while (j < subset.Length - 1)
                {
                    if (goToLeft && j > 0)
                    {
                        if (subset[j - 1] < subset[j])
                        {
                            break;
                        }

                        j--;
                        var t = subset[j];
                        subset[j] = subset[j + 1];
                        subset[j + 1] = t;
                    }
                    else
                    {
                        if (subset[j] <= subset[j + 1])
                        {
                            break;
                        }

                        var t = subset[j];
                        subset[j] = subset[j + 1];
                        subset[j + 1] = t;
                        j++;
                    }

                    if (j <= 0)
                    {
                        break;
                    }
                }

                if (median * 2 <= expenditure[i])
                {
                    result++;
                }
            }
            return result;
        }
    }
}
