using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.Arrays
{
    class ArrayManipulation
    {
        public static void Test()
        {
            string[] firstMultipleInput = "10 4".TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            //for (int i = 0; i < m; i++)
            {
                //queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            queries.Add("2 6 8".TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            queries.Add("3 5 7".TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            queries.Add("1 8 1".TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            queries.Add("5 9 15".TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());

            long result = arrayManipulation(n, queries);

            Console.WriteLine(result);
        }

        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            // Initialize array of size n, with 0
            long[] arr = new long[n];
            //for (int i = 0; i < n; i++)
            //    arr[i] = 0;
            // Let max = 0
            long max = arr[0];

            // Process each query
            foreach(List<int> q in queries)
            {
                // a and b are array location, add 1 because input's range starts from 1
                long a = q[0] - 1;
                long b = q[1];
                long k = q[2];

                arr[a] += k;
                if (b < n) arr[b] -= k;
            }

            long sum = arr[0];
            for (int i = 1; i < n; i++)
            {
                sum += arr[i];
                arr[i] = sum;
                if (arr[i] > max) max = sum;
            }

            return max;
        }
    }
}
