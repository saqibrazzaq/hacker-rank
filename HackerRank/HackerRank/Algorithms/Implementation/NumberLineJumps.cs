using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class NumberLineJumps
    {
        public static void Test()
        {
            int x1 = 0;

            int v1 = 2;

            int x2 = 5;

            int v2 = 3;

            string result = kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);
        }

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string result;
            int x1Next = x1, x2Next = x2;
            int jumps = 0;

            while (true)
            {
                x1Next += v1; // Kangroo 1 moves next step
                x2Next += v2; // Kangro 2 moves next step

                // If they are at the same position, quit with yes
                if (x1Next == x2Next)
                {
                    result = "YES";
                    break;
                }
                // Detect infinite chase
                if (jumps > 5 && Math.Abs(x1Next - x2Next) >= Math.Abs(x1 - x2))
                {
                    result = "NO";
                    break;
                }
                jumps++;
            }

            return result;
        }
    }
}
