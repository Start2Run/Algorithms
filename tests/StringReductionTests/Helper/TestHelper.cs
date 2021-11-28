using StringReductionUnitTests;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StringReductionTests.Helper
{
    public class TestHelper
    {
        public static IEnumerable<object[]> GetData(string testCaseName)
        {
            var collection = new List<object[]>();

            Type t = Type.GetType(testCaseName);

            if (!(t.GetProperty("Model").GetValue(null, null) is TestCaseModel model))
            {
                return collection;
            }

            string[] data = FilterData(model.Data);
            string[] expected = FilterData(model.Expected);
            for (int i = 0; i < model.TestCasesCount; i++)
            {
                collection.Add(new object[] { data[i], expected[i] });
            }
            return collection;
        }

        private static string[] FilterData(string s)
        {
            string[] data = s.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            return data.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
        }
    }
}