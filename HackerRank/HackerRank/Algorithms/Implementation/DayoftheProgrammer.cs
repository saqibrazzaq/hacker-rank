using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class DayoftheProgrammer
    {
        public static void Test()
        {
            string result = dayOfProgrammer(1800);

            Console.WriteLine(result);
        }

        public static string dayOfProgrammer(int year)
        {
            int FIND_DAY = 256;
            string d = "";
            bool isJulian = (year >= 1700 && year <= 1917) ? true : false;

            // Store days in each month in an array
            List<int> days = new List<int>() { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Adjust days in Feb for leap year
            // In Julian, leap year is divisible by 4
            if (isJulian == true && year % 4 == 0)
                days[1] = 29;
            else if (isJulian == false && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
                days[1] = 29;
            // For 1918, Feb starts with 14th, means skip 13 days
            if (year == 1918)
                days[1] -= 13;

            // Calculate 256th day. We have year as input
            // Calculate day and month, from the days array
            int dd = 0, mm = 1;
            // Start counting days from the array
            foreach (int dayCount in days)
            {
                //count += dayCount;
                // Did we reach 256th day?
                if (dayCount >= FIND_DAY)
                {
                    dd = FIND_DAY % dayCount;
                    if (dd == 0) dd = dayCount;
                    break;
                }
                else
                {
                    FIND_DAY -= dayCount;
                    mm++;
                }
            }

            string ddStr = "0" + dd;
            ddStr = ddStr.Substring(ddStr.Length - 2);
            string mmStr = "0" + mm;
            mmStr = mmStr.Substring(mmStr.Length - 2);
            d = ddStr + "." + mmStr + "." + year;
            return d;
        }
    }
}
