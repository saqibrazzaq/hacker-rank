using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class BetweenTwoSets
    {
        public static void Test()
        {
            List<int> arr = "2 4".Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = "16 32 96".Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = getTotalX(arr, brr);

            Console.WriteLine(total);
        }
        private static int getTotalX(List<int> a, List<int> b)
        {
            int result = 0;

            // Sort both arrays
            a.Sort();
            b.Sort();

            // Find GCD of second array
            int gcd = b[0];
            for (int i = 1; i < b.Count; i++)
                gcd = getGCD(b[i], gcd);

            // Find LCM of first array
            int lcm = a[0];
            for (int i = 1; i < a.Count; i++)
                lcm = getLCM(a[i], lcm);

            for (int i = lcm; i <= gcd; i++)
            {
                bool tryThis = true;
                bool isFactorAndMultiple = true;
                // Check if each item of a is factor of i
                for (int i1 = 0; i1 < a.Count; i1++)
                {
                    if (i % a[i1] != 0)
                    {
                        tryThis = false;
                    }
                }
                if (tryThis == false) continue;
                // Check if i is a factor of all items of b
                for (int i2 = 0; i2 < b.Count; i2++)
                {
                    if (b[i2] % i != 0)
                    {
                        isFactorAndMultiple = false;
                        break;
                    }
                }
                // it is factor and multiple, increment count
                if (isFactorAndMultiple == true)
                    result++;
            }
            
            return result;
        }
        private static int getLCM(int n1, int n2)
        {
            int lcm = 1;

            while (n1 != 1 || n2 != 1)
            {
                if (n1 == 1)
                {
                    lcm *= n2;
                    break;
                }
                if (n2 == 1)
                {
                    lcm *= n1;
                    break;
                }
                int gcd = getGCD(n1, n2);
                if (gcd == 1)
                {
                    lcm *= n1 * n2;
                    break;
                }
                n1 = (n1 / gcd == 0) ? 1 : n1 / gcd;
                n2 = (n2 / gcd == 0) ? 1 : n2 / gcd;
                lcm *= gcd;
            }

            return lcm;
        }
        private static int getGCD(int n1, int n2)
        {
            int result = n1;
            while (n2 % n1 != 0)
            {
                int rem = n2 % n1;
                n2 = n1;
                n1 = rem;
            }
            return n1;
        }
    }
}
