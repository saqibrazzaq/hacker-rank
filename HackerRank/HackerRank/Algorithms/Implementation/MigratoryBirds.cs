using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class MigratoryBirds
    {
        public static void Test()
        {
            List<int> arr = "1 2 3 4 5 4 3 2 1 3 4".Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int result = migratoryBirds(arr);

            Console.WriteLine(result);
        }

        public static int migratoryBirds(List<int> arr)
        {
            int maxCount = 0;
            int maxCountType = 0;
            // Create a count array
            List<int> birdCount = new List<int> { 0, 0, 0, 0, 0 };

            // Traverse the array to count each bird type
            foreach (int birdType in arr)
            {
                // Increment count for the bird type
                birdCount[birdType - 1]++;
            }

            // Now we got bird counts in count array
            // Assume bird 1 has max count
            maxCount = birdCount[0];
            maxCountType = 0;
            // Compare with count of other bird types
            for (int i = 1; i < birdCount.Count; i++)
            {
                if (birdCount[i] > maxCount)
                {
                    maxCount = birdCount[i];
                    maxCountType = i;
                }
            }

            return maxCountType + 1;
        }
    }
}
