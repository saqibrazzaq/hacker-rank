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
            List<int> ranked = "100 90 90 80 75 60".Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();
            List<int> player = "50 65 77 90 102".Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            List<int> result = climbingLeaderboard(ranked, player);

            Console.WriteLine(String.Join("\n", result));
        }

        private static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> result = new List<int>();
            
            foreach (int score in player)
            {
                // Add score
                ranked.Add(score);
                ranked = ranked.OrderByDescending(x => x).ToList();

                // Create group
                var groupedRanks = ranked.GroupBy(x => x);

                // Find rank in group
                var rank = groupedRanks.Select(x => x.Key).ToList();

                result.Add(rank.IndexOf(score) + 1);
            }

            return result;
        }

        
    }
}
