using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class BirthdayCakeCandles
    {
        public static void Test()
        {
            List<int> candles = "3 2 1 3".Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = birthdayCakeCandles(candles);
            Console.WriteLine(result);
        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            int count = 0, max = int.MinValue;

            foreach (int item in candles)
            {
                // If this int is greater, reset count, it is new
                if (item > max)
                {
                    max = item;
                    count = 1;
                } else if (item == max)
                {
                    // If max is repeated, increment count
                    count++;
                }
            }

            return count;
        }
    }
}
