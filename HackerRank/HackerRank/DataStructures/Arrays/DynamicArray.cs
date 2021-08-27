using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.Arrays
{
    class DynamicArray
    {
        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            int lastAnswer = 0;
            List<List<int>> arr = new List<List<int>>();
            List<int> answers = new List<int>();

            for (int i = 0; i < n; i++)
                arr.Add(new List<int>());

            foreach (List<int> queryArr in queries)
            {
                int q = queryArr[0];
                int x = queryArr[1];
                int y = queryArr[2];
                int idx;

                if (q == 1)
                {
                    idx = ((x ^ lastAnswer) % n);
                    arr[idx].Add(y);
                }
                else
                {
                    idx = ((x ^ lastAnswer) % n);
                    lastAnswer = arr[idx][y % arr[idx].Count];
                    answers.Add(lastAnswer);
                }
                
            }
            return answers;
        }

        public static void Test()
        {
            string[] firstMultipleInput = "2 5".TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int q = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                //queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            queries.Add("1 0 5".TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            queries.Add("1 1 7".TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            queries.Add("1 0 3".TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            queries.Add("2 1 0".TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            queries.Add("2 1 1".TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());

            List<int> result = dynamicArray(n, queries);

            Console.WriteLine(String.Join("\n", result));
        }
    }
}
