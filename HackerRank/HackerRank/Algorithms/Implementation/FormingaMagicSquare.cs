using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class FormingaMagicSquare
    {
        public static void Test()
        {
            List<List<int>> s = new List<List<int>>();
            s.Add(new List<int>() { 4, 9, 2 });
            s.Add(new List<int>() { 3, 5, 7 });
            s.Add(new List<int>() { 8, 1, 5 });

            int result = formingMagicSquare(s);

            Console.WriteLine(result);
        }

        private static int formingMagicSquare(List<List<int>> s)
        {
            int minDiff = int.MaxValue;

            // There are 8 pre-defined matrices of 3x3
            List<List<List<int>>> pre = getPredefinedMatrices();

            
            // Parse each 2D array
            foreach (List<List<int>> m in pre)
            {
                int diff = 0;
                // Parse each item of the 2d List
                for (int i = 0; i < m.Count; i++)
                {
                    for (int j = 0; j < m[i].Count; j++)
                    {
                        diff += Math.Abs(m[i][j] - s[i][j]);
                    }
                }
                // See if it is min difference
                if (diff < minDiff)
                    minDiff = diff;
            }

            return minDiff;
        }

        private static List<List<List<int>>> getPredefinedMatrices()
        {
            List<List<List<int>>> pre = new List<List<List<int>>>();

            // 1 combo
            pre.Add(new List<List<int>>());
            pre[0].Add(new List<int>() { 4, 9, 2 });
            pre[0].Add(new List<int>() { 3, 5, 7 });
            pre[0].Add(new List<int>() { 8, 1, 6 });
            // 1 combo
            pre.Add(new List<List<int>>());
            pre[1].Add(new List<int>() { 2, 9, 4 });
            pre[1].Add(new List<int>() { 7, 5, 3 });
            pre[1].Add(new List<int>() { 6, 1, 8 });
            // 1 combo
            pre.Add(new List<List<int>>());
            pre[2].Add(new List<int>() { 8, 1, 6 });
            pre[2].Add(new List<int>() { 3, 5, 7 });
            pre[2].Add(new List<int>() { 4, 9, 2 });
            // 1 combo
            pre.Add(new List<List<int>>());
            pre[3].Add(new List<int>() { 6, 1, 8 });
            pre[3].Add(new List<int>() { 7, 5, 3 });
            pre[3].Add(new List<int>() { 2, 9, 4 });
            // 1 combo
            pre.Add(new List<List<int>>());
            pre[4].Add(new List<int>() { 8, 3, 4 });
            pre[4].Add(new List<int>() { 1, 5, 9 });
            pre[4].Add(new List<int>() { 6, 7, 2 });
            // 1 combo
            pre.Add(new List<List<int>>());
            pre[5].Add(new List<int>() { 4, 3, 8 });
            pre[5].Add(new List<int>() { 9, 5, 1 });
            pre[5].Add(new List<int>() { 2, 7, 6 });
            // 1 combo
            pre.Add(new List<List<int>>());
            pre[6].Add(new List<int>() { 6, 7, 2 });
            pre[6].Add(new List<int>() { 1, 5, 9 });
            pre[6].Add(new List<int>() { 8, 3, 4 });
            // 1 combo
            pre.Add(new List<List<int>>());
            pre[7].Add(new List<int>() { 2, 7, 6 });
            pre[7].Add(new List<int>() { 9, 5, 1 });
            pre[7].Add(new List<int>() { 4, 3, 8 });

            return pre;
        }
    }
}
