using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class ComparetheTriplets
    {
        public static void Test()
        {
            List<int> a = "17 28 30".Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = "99 16 8".Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);
            Console.WriteLine(String.Join(" ", result));
        }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0, bob = 0;

            // Only 3 results in each array
            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i]) alice++;
                else if (a[i] < b[i]) bob++;
            }

            return new List<int>() { alice, bob };
        }
    }
}
