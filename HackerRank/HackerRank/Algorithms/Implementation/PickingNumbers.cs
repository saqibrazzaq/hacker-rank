using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class PickingNumbers
    {
        public static void Test()
        {
            List<int> a = "1 3".Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            int result = pickingNumbers(a);

            Console.WriteLine(result);
        }

        private static int pickingNumbers(List<int> a)
        {
            int countMax = 0;

            // Declare array of size 100 to store count
            int[] arrCount = new int[100];

            // Store count of each number in an array
            foreach (int n in a)
            {
                arrCount[n]++;
            }

            // Calculate sum of adjacent pairs
            for (int i = 0; i < arrCount.Length - 1; i++)
            {
                // Only compare if value is not 0
                //if (arrCount[i] > 0 && arrCount[i + 1] > 0)
                {
                    // Calculate sum of pair
                    int sum = arrCount[i] + arrCount[i + 1];
                    // If this sum is greater than previous saved, update
                    if (sum > countMax)
                    {
                        countMax = sum;
                    }
                }
            }

            // If max count is 0, that means, no pair exists
            // Sort the count array and get max
            if (countMax == 0) countMax = arrCount.ToList().Max();

            return countMax;
        }
    }
}
