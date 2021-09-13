using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class GradingStudents
    {
        public static void Test()
        {
            List<int> grades = new List<int>() { 73, 67, 38, 33 };
            List<int> result = gradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> final = new List<int>();

            foreach (int grade in grades)
            {
                // No rounding for less than 38
                if (grade < 38)
                    final.Add(grade);
                else if (grade < 40)
                    final.Add(40); // round 38, 39, 40 to 40
                else
                {
                    // Find next multiple of 5
                    int nextMultiple5 = grade + 5 - (grade % 5);
                    // If difference between next multiple and grade < 3, increase
                    if (nextMultiple5 - grade < 3)
                        final.Add(nextMultiple5);
                    else
                        final.Add(grade);
                }
            }

            return final;
        }
    }
}
