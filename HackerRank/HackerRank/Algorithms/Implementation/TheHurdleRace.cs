using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class TheHurdleRace
    {
        public static void Test()
        {
            int n = 5;
            int k = 4;
            List<int> height = "1 6 3 5 2".Split(' ').ToList().Select(h => Convert.ToInt32(h)).ToList();
            int result = hurdleRace(k, height);
            Console.WriteLine(result);
        }

        private static int hurdleRace(int k, List<int> height)
        {
            int result = 0;

            // Sort the array
            height.Sort();
            int max = (height[height.Count() - 1]);
            if (max > k)
                result = max - k;

            return result;
        }
    }
}
