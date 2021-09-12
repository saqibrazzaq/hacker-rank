using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class PlusMinus
    {
        public static void Test()
        {
            List<int> arr = "-4 3 -9 0 4 1".Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            plusMinus(arr);
        }

        public static void plusMinus(List<int> arr)
        {
            int positive = 0, negative = 0, zero = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0) positive++;
                else if (arr[i] < 0) negative++;
                else zero++;
            }
            //Console.WriteLine(string.Format("{0:0.000000}", 0.5));
            Console.WriteLine(string.Format("{0:0.000000}\n{1:0.000000}\n{2:0.000000}",
                (double)positive / arr.Count,
                (double)negative / arr.Count,
                (double)zero / arr.Count));
        }
    }
}
