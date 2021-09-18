using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class DivisibleSumPairs
    {
        public static void Test()
        {
            int n = 6, k = 5;
            List<int> ar = "1 2 3 4 5 6".Split(' ').Select(arr => Convert.ToInt32(arr)).ToList();
            Console.WriteLine(divisibleSumPairs(n, k, ar));
        }
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;

            // Sort the array
            ar.Sort();

            // Nested loop to make pair (i < j)
            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = i + 1; j < ar.Count; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        count++;
                }
            }

            return count;
        }
    }
}
