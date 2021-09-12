using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class MiniMaxSum
    {
        public static void Test()
        {
            List<int> arr = "1 2 3 4 5".Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            miniMaxSum(arr);
        }

        public static void miniMaxSum(List<int> arr)
        {
            long min = arr[0], max = arr[0], sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                // Min count
                if (arr[i] < min) min = arr[i];
                // Max count
                if (arr[i] > max) max = arr[i];
                // Sum all
                sum += arr[i];
            }
            Console.WriteLine((sum - max) + " " + (sum - min));
        }
    }
}
