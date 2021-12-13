using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace DictionariesAndHashmapsTests
{
    public class FrequencyQueriesTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void TestCase1(List<List<int>> q, List<int> expected)
        {
            var actual = DictionariesAndHashmaps.FrequencyQueries.Execute(q);
            for (var i = 0; i < expected.Count; i++)
            {
                if (expected[i] != actual[i])
                {

                }
            }
            Assert.Equal(expected, actual);
        }


        public static IEnumerable<object[]> Data()
        {
            return new List<object[]> { new object[] { InputData(), ExpectedResults() } };
        }

        public static List<List<int>> InputData()
        {
            List<List<int>> queries = new List<List<int>>();

            var data = Properties.Resources.TestCase1;
            Stream stream = new MemoryStream(data);
            using (StreamReader sr = new StreamReader(stream))
            {
                while (sr.Peek() >= 0)
                {

                    queries.Add(sr.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
                }
            }
            return queries;
        }

        public static List<int> ExpectedResults()
        {
            List<List<int>> queries = new List<List<int>>();

            var data = Properties.Resources.TestCase1Results;
          
            return data.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Select(x=>int.Parse(x)).ToList();
        }
    }
}
