using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class SubarrayDivision
    {
        public static void Test()
        {
            int n = 6;
            List<int> s = "1 1 1 1 1 1".Split(' ').Select(arr => Convert.ToInt32(arr)).ToList();
            List<int> bd = "3 2".Split(' ').Select(arr => Convert.ToInt32(arr)).ToList();
            int d = bd[0], m = bd[1];
            Console.WriteLine(birthday(s, d, m));
        }
        public static int birthday(List<int> s, int d, int m)
        {
            int count = 0;

            // Traverse multiple regions of chocolate
            for (int i = 0; i < s.Count - m + 1; i++)
            {
                // Calculate sum of boxes in one region
                int sum = 0;
                for (int j = 0; j < m; j++)
                    sum += s[i + j];
                // If sum = m, count it
                if (sum == d) count++;
            }

            return count;
        }
    }
}
