using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.Arrays
{
    class ArraysDS
    {
        public static void Test()
        {
            int arrCount = 4;

            List<int> arr = new List<int>() { 1, 4, 3, 2};

            List<int> res = reverseArray(arr);

            Console.WriteLine(String.Join(" ", res));
        }
        public static List<int> reverseArray(List<int> a)
        {
            List<int> rev = new List<int>();
            for (int i = a.Count - 1; i >= 0; i--)
                rev.Add(a[i]);
            return rev;
        }
    }
}
