using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class AppleandOrange
    {
        public static void Test()
        {
            int s = 7;

            int t = 10;

            int a = 4;

            int b = 12;

            List<int> apples = "2 3 -4".Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = "3 -2 -4".Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appleCount = 0, orangeCount = 0;

            // First count apples
            foreach (int apple in apples)
            {
                if (apple + a >= s && apple + a <= t)
                    appleCount++;
            }
            // Count how many oranges fell in house
            foreach (int orange in oranges)
            {
                if (orange + b >= s && orange + b <= t)
                    orangeCount++;
            }
            Console.WriteLine(appleCount + Environment.NewLine + orangeCount);
        }
    }
}
