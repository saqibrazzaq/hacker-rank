using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class SimpleArraySum
    {
        public static void Test()
        {
            List<int> ar = "1 2 3 4 10 11".Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int result = simpleArraySum(ar);
            Console.WriteLine(result);
        }
        public static int simpleArraySum(List<int> ar)
        {
            int result = 0;

            for (int i = 0; i < ar.Count; i++)
                result += ar[i];

            return result;
        }
    }
}
