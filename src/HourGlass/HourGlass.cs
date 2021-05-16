using System;
using System.Collections.Generic;
using System.Linq;

namespace HourGlass
{
    public class HourGlass
    {
        private static List<List<int>> ProcessString(string s)
        {
            var lines = s.Split(Environment.NewLine.ToArray(), StringSplitOptions.None);

            return lines.Where(x => !string.IsNullOrWhiteSpace(x)).Select(line => line.Replace("\t", "").Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Select(arrTemp => Convert.ToInt32(arrTemp)).ToList()).ToList();
        }

        public static int[,] HourglassSum(string input)
        {
            var arr = ProcessString(input);
            var rowCount = 0;
            var n = arr.Count;
            var resultArray = new int[n - 2, n - 2];

            foreach (var row in arr)
            {
                var columnCount = 0;
                foreach (var val in row)
                {
                    var points = new List<Point>();
                    //up-left corner
                    points.Add(new Point
                    {
                        OffsetRow = 0,
                        OffsetColumn = 0,
                        Condition = (m, r, c) => r < n - 2 && c < m - 2
                    });

                    //up-middle
                    points.Add(new Point
                    {
                        OffsetRow = 0,
                        OffsetColumn = -1,
                        Condition = (m, r, c) => r < n - 2 && c > 0 && c < m - 1
                    });

                    //right-up corner
                    points.Add(new Point
                    {
                        OffsetRow = 0,
                        OffsetColumn = -2,
                        Condition = (m, r, c) => r < n - 2 && c > 1
                    });

                    //middle
                    points.Add(new Point
                    {
                        OffsetRow = -1,
                        OffsetColumn = -1,
                        Condition = (m, r, c) => r < n - 1 && r > 0 && c < n - 1 && c > 0
                    });

                    //bottom-left corner
                    points.Add(new Point
                    {
                        OffsetRow = -2,
                        OffsetColumn = 0,
                        Condition = (m, r, c) => r > 1 && c < n - 2
                    });

                    //bottom-middle
                    points.Add(new Point
                    {
                        OffsetRow = -2,
                        OffsetColumn = -1,
                        Condition = (m, r, c) => r > 1 && r < n && c > 0 && c < n - 1
                    });

                    //bottom-right corner
                    points.Add(new Point
                    {
                        OffsetRow = -2,
                        OffsetColumn = -2,
                        Condition = (m, r, c) => r > 1 && c > 1
                    });

                    foreach (var point in points.Where(point => point.Condition(n, rowCount, columnCount)))
                    {
                        resultArray[rowCount + point.OffsetRow, columnCount + point.OffsetColumn] += val;
                    }

                    columnCount++;
                }
                rowCount++;
            }

            return resultArray;
        }

        public class Point
        {
            public Func<int, int, int, bool> Condition;
            public int OffsetRow;
            public int OffsetColumn;
        }
    }
}