using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class ClimbingtheLeaderboard
    {
        public static void Test()
        {
            List<int> ranked = "100 90 90 90 60".Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();
            List<int> player = "60 61 62 63 95".Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            List<int> result = climbingLeaderboard(ranked, player);

            Console.WriteLine(String.Join("\n", result));
        }

        private static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            bool rf = false;
            List<int> result = new List<int>();
            int end = ranked.Count - 1;
            int rank = 0;
            int lastRank = ranked[ranked.Count - 1];
            foreach (int score in player)
            {
                // Start from the end
                for (int i = end; i >= 0; i--)
                {
                    //if (rf == true && (i + 1) < ranked.Count - 1 && ranked[i] != ranked[i + 1])
                    //    rank--;
                    // Update leaderboard
                    if (score <= ranked[i])
                    {
                        // Lowest score, insert at end
                        if (i == ranked.Count - 1)
                            ranked.Add(score);
                        else
                            ranked.Insert(i + 1, score);
                        i++;
                        end = i;
                        //if (rf == true) result.Add(rank);
                        break;
                    }
                    else if (score > ranked[0])
                    {
                        // Highest score
                        ranked.Insert(0, score);
                        //if (rf == true) result.Add(rank);
                        break;
                    }
                    // Decrease rank when it changes from previous leaderboard
                    //else if (rf == true && (i + 1) < ranked.Count - 1 && ranked[i] != ranked[i + 1])
                    //    rank--;
                }
                // Only find rank first time by traversing all array
                if (rf == false)
                {
                    rank = findRank(ranked, score);
                    lastRank = score;
                    //result.Add(rank);
                    rf = true;
                }
                else
                {
                    while (end >= 0 && lastRank == ranked[end])
                        end--;
                }
                result.Add(rank);
                lastRank = ranked[end];
            }

            return result;
        }

        private static List<int> climbingLeaderboard1(List<int> ranked, List<int> player)
        {
            List<int> result = new List<int>();

            foreach (int score in player)
            {
                ranked.Add(score);
                ranked.Sort((a, b) => b.CompareTo(a));
                result.Add(findRank(ranked, score));
            }

            return result;
        }

        private static int findRank(List<int> ranked, int score)
        {
            int rank = 1;

            for (int i = 1; i < ranked.Count; i++)
            {
                // Ignore if previous rank is same as current
                if (ranked[i] == ranked[i - 1])
                    continue;
                // If score is less or equal, lower rank
                if (score <= ranked[i])
                {
                    rank++;
                }
                // Break if leaderboard score is greater
                if (score > ranked[i])
                    break;
            }

            return rank;
        }
    }
}
