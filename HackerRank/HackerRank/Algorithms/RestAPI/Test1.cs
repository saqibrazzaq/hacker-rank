using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.RestAPI
{
    public class Test1
    {
        public static void Test()
        {
            string team = "Barcelona";

            int year = 2011;

            int result = Test1.getTotalGoals(team, year);

            Console.WriteLine(result);
        }

        public static int getTotalGoals(string team, int year)
        {
            try
            {
                int team1Goals = getTeam1Goals(team, year);
                int team2Goals = getTeam2Goals(team, year);

                return team1Goals + team2Goals;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        private static int getTeam1Goals(string team, int year)
        {
            string apiUrlHomeTeam = $"https://jsonmock.hackerrank.com/api/football_matches?year={year}&team1={team}&page=1";
            HttpClient client = new HttpClient();

            List<MatchData> allMatches = new List<MatchData>();

            int total_pages = 1;
            for (int page = 1; page <= total_pages; page++)
            {
                // Call API
                HttpResponseMessage response = client.GetAsync(apiUrlHomeTeam).Result;
                response.EnsureSuccessStatusCode();
                var resultString = response.Content.ReadAsStringAsync().Result;
                var result = JsonSerializer.Deserialize<MatchResponse>(resultString);
                //Console.WriteLine("Result: " + result.Total);

                // Get number of pages
                total_pages = result.total_pages;

                // Save data from current page
                allMatches.AddRange(result.data);
            }


            return allMatches.Sum(x => int.Parse(x.team1goals));
        }

        private static int getTeam2Goals(string team, int year)
        {
            string apiUrlHomeTeam = $"https://jsonmock.hackerrank.com/api/football_matches?year={year}&team2={team}&page=1";
            HttpClient client = new HttpClient();

            List<MatchData> allMatches = new List<MatchData>();

            int total_pages = 1;
            for (int page = 1; page <= total_pages; page++)
            {
                // Call API
                HttpResponseMessage response = client.GetAsync(apiUrlHomeTeam).Result;
                response.EnsureSuccessStatusCode();
                var resultString = response.Content.ReadAsStringAsync().Result;
                var result = JsonSerializer.Deserialize<MatchResponse>(resultString);
                //Console.WriteLine("Result: " + result.Total);

                // Get number of pages
                total_pages = result.total_pages;

                // Save data from current page
                allMatches.AddRange(result.data);
            }


            return allMatches.Sum(x => int.Parse(x.team2goals));
        }
    }

    internal class MatchResponse
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<MatchData> data { get; set; }
    }

    internal class MatchData
    {
        public string competition { get; set; }
        public int year { get; set; }
        public string round { get; set; }
        public string team1 { get; set; }
        public string team2 { get; set; }
        public string team1goals { get; set; }
        public string team2goals { get; set; }
    }
}
