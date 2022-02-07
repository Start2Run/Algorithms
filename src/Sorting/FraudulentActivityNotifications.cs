// ==========================================================================
// Copyright (C) 2022 by Genetec, Inc.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// ==========================================================================

namespace Sorting
{
    using System.Collections.Generic;
    using System.Linq;

    public static class FraudulentActivityNotifications
    {
        public static int ActivityNotifications(List<int> expenditure, int d)
        {
            var result = 0;

            var middle = d / 2;
            for (var i=d;i<expenditure.Count;i++)
            {
                var temp = expenditure.GetRange(i - d,d).OrderBy(x => x).ToArray();

                var median = (d % 2 == 0)?temp[middle - 1] + temp[middle]: temp[middle];

                if (median * 2 <= expenditure[i])
                {
                    result++;
                }
            }

            return result;
        }
    }
}
