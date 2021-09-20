using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class CatsandaMouse
    {
        public static void Test()
        {
            int x = 1;

            int y = 3;

            int z = 2;

            string result = catAndMouse(x, y, z);

            Console.WriteLine(result);
        }

        private static string catAndMouse(int x, int y, int z)
        {
            if (Math.Abs(x - z) < Math.Abs(y - z))
                return "Cat A";
            else if (Math.Abs(y - z) < Math.Abs(x - z))
                return "Cat B";
            else
                return "Mouse C";
        }
    }
}
