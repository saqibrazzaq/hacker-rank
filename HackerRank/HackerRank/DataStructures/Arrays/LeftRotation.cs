using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.Arrays
{
    class LeftRotation
    {
        public static void Test()
        {
            string[] firstMultipleInput = "5 4".TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = "1 2 3 4 5".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = rotateLeft(d, arr);

            Console.WriteLine(String.Join(" ", result));
        }

        public static List<int> rotateLeft(int d, List<int> arr)
        {
            // Declare queue to store array items 0 to d
            Queue<int> q = new Queue<int>();
            
            // Write d to 0, d+1 to 1 and so on
            for (int i = d; i < arr.Count; i++)
                q.Enqueue(arr[i]);

            for (int i = 0; i < d; i++)
                q.Enqueue(arr[i]);

            return q.ToList();
        }
    }
}
