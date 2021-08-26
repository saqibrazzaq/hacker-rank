using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.Arrays
{
    class TwoDArrayDS
    {
        public static void Test()
        {
            List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < 6; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            arr.Add("1 1 1 0 0 0".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            arr.Add("0 1 0 0 0 0".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            arr.Add("1 1 1 0 0 0".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            arr.Add("0 0 2 4 4 0".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            arr.Add("0 0 0 2 0 0".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            arr.Add("0 0 1 2 4 0".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());

            int result = hourglassSum(arr);

            Console.WriteLine(result);
        }

        public static int hourglassSum(List<List<int>> arr)
        {
            // get sum of first hourglass
            int maxSum = singleHourglassSum(arr, 0, 0);

            // get hourglass sum of all
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int sum = singleHourglassSum(arr, i, j);
                    // If sum is greater than max, update max
                    if (sum > maxSum)
                        maxSum = sum;
                }
            }

            return maxSum;
        }

        private static int singleHourglassSum(List<List<int>> arr, int row, int col)
        {
            return arr[row][col] + arr[row][col + 1] + arr[row][col + 2] +
                arr[row + 1][col + 1] +
                arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];
        }
    }
}
