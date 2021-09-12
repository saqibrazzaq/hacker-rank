using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class Staircase
    {
        public static void Test()
        {
            int n = 6;

            staircase(n);
        }

        public static void staircase(int n)
        {
            // Loop stairs times
            for (int i = 0; i < n; i++)
            {
                // Calculate spaces and # count for eash stair
                int spaces = n - 1 - i;
                int stairs = i + 1;
                for (int iSpaces = 0; iSpaces < spaces; iSpaces++)
                    Console.Write(" ");
                for (int iStairs = 0; iStairs < stairs; iStairs++)
                    Console.Write("#");
                Console.WriteLine();
            }
        }
    }
}
