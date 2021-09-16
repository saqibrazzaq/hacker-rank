using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class BreakingtheRecords
    {
        public static void Test()
        {
            int n = 9;
            List<int> score = new List<int>() { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };
            List<int> result = calculateMaxMinRecord(score);
            Console.WriteLine(string.Join(' ', result));
        }

        private static List<int> calculateMaxMinRecord(List<int> scores)
        {
            // Max and Min record
            List<int> result = new List<int>() { 0, 0 };

            // Initialize max and min values with the first score
            int min = scores[0], max = scores[0];
            // Start with 1
            for (int i = 1; i < scores.Count; i++)
            {
                // If max record broken
                if (scores[i] > max)
                {
                    max = scores[i];
                    result[0]++;
                }
                // If min record is broken
                if (scores[i] < min)
                {
                    min = scores[i];
                    result[1]++;
                }
            }

            return result;
        }
    }
}
