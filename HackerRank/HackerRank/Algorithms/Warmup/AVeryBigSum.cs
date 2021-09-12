using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class AVeryBigSum
    {
        public static void Test()
        {
            List<long> ar = "1000000001 1000000002 1000000003 1000000004 1000000005"
                .Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = aVeryBigSum(ar);

            Console.WriteLine(result);
        }

        public static long aVeryBigSum(List<long> ar)
        {
            long result = 0;

            for (int i = 0; i < ar.Count; i++)
                result += ar[i];

            return result;
        }
    }
}
