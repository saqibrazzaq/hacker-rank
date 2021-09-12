using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class DiagonalDifference
    {
        public static void Test()
        {
            List<List<int>> arr = new List<List<int>>();

            arr.Add("11 2 4".Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            arr.Add("4 5 6".Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            arr.Add("10 8 -12".Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());

            int result = diagonalDifference(arr);

            Console.WriteLine(result);
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int n = arr.Count;
            int d1 = 0, d2 = 0;

            // Calculate sum of left diagonal
            // 0,0 1,1 2,2 etc
            for (int i = 0; i < n; i++)
                d1 += arr[i][i];

            // Calculate sum of right diagonal
            // 0,2, 1,1 2,0
            for (int i = 0; i < n; i++)
                d2 += arr[i][n - i - 1];

            return Math.Abs(d1 - d2);
        }
    }
}
