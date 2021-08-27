using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.Arrays
{
    class SparseArrays
    {
        public static void Test()
        {
            int stringsCount = 4;

            List<string> strings = new List<string>();

            //for (int i = 0; i < stringsCount; i++)
            //{
            //    string stringsItem = Console.ReadLine();
            //    strings.Add(stringsItem);
            //}
            strings.Add("aba");
            strings.Add("baba");
            strings.Add("aba");
            strings.Add("xzxb");

            int queriesCount = 3;

            List<string> queries = new List<string>();

            //for (int i = 0; i < queriesCount; i++)
            //{
            //    string queriesItem = Console.ReadLine();
            //    queries.Add(queriesItem);
            queries.Add("aba");
            queries.Add("xzxb");
            queries.Add("ab");
            //}

            List<int> res = matchingStrings(strings, queries);

            Console.WriteLine(String.Join("\n", res));
        }

        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> result = new List<int>();

            foreach(string q in queries)
            {
                int count = strings.Where(x => x.Equals(q)).Count();
                result.Add(count);
            }

            return result;
        }

    }
}
