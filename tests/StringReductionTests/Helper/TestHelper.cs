// ==========================================================================
// <copyright file="TestHelper.cs" company="Genetec">
//   Copyright (c) 2018 by Genetec
//   All rights reserved. May be used only in accordance with a valid Source Code License Agreement.
// </copyright>
// Created: 05/03/2021
// Last update: 05/03/2021
// ==========================================================================

namespace UnitTests.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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
