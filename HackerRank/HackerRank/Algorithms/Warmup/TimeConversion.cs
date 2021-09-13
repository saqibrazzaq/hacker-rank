using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class TimeConversion
    {
        public static void Test()
        {
            string s = "12:05:45AM";

            string result = timeConversion(s);

            Console.WriteLine(result);
        }

        public static string timeConversion(string s)
        {
            string t = "";

            // Remove the am/pm from the end
            string am_pm = s.Substring(8, 2);
            s = s.Remove(8, 2);
            // Split the remaining string by : to get hh:mm:ss
            string[] arr = s.Split(':');
            // Convert hh, mm, ss into int
            int hh = int.Parse(arr[0]);

            // Add hour
            if (am_pm == "AM" && hh == 12)
                t += "00";
            else if (am_pm == "PM" && hh == 12)
                t += "12";
            else if (am_pm == "PM")
                t += "0" + (hh + 12) % 24;
            else
                t += "0" + (hh) % 24;
            // Add min
            if (t.Length == 3) t = t.Substring(1, 2);
            t += ":" + arr[1] + ":" + arr[2];

            return t;
        }
    }
}
