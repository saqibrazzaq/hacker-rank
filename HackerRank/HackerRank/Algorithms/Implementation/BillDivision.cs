using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class BillDivision
    {
        public static void Test()
        {
            int k = 1;
            List<int> bill = "3 10 2 9".Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = 12;

            bonAppetit(bill, k, b);
        }

        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int totalBill = 0;

            for (int i = 0; i < bill.Count; i++)
            {
                if (i != k) totalBill += bill[i];
            }

            int pay = totalBill / 2;
            if (pay != b)
            {
                Console.WriteLine(b - pay);
            }
            else
            {
                Console.WriteLine("Bon Appetit");
            }
        }
    }
}
