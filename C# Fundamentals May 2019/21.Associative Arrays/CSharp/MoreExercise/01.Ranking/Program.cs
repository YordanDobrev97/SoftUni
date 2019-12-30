using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    class Program
    {
        static void Main()
        {
            string contest = Console.ReadLine();

            var contests = new Dictionary<string, string>();
            while (contest != "end of contests")
            {
                var items = contest.Split(":");

                var currentContest = items[0];
                var password = items[1];

                if (!contests.ContainsKey(currentContest))
                {
                    contests.Add(currentContest, password);
                }

                contest = Console.ReadLine();
            }

            var userContests = new Dictionary<string, Dictionary<string, int>>();
            string submission = Console.ReadLine();

            while (submission != "end of submissions")
            {
                var items = submission.Split("=>");

                var currentContest = items[0];
                var password = items[1];
                var username = items[2];
                var points = int.Parse(items[3]);

                if (contests.ContainsKey(currentContest) && contests.ContainsValue(password))
                {
                    if (!userContests.ContainsKey(username))
                    {
                        userContests.Add(username, new Dictionary<string, int>());
                    }

                    if (!userContests[username].ContainsKey(currentContest))
                    {
                        userContests[username].Add(currentContest, points);
                    }
                    else
                    {
                        if (userContests[username][currentContest] < points)
                        {
                            userContests[username][currentContest] = points;
                        }
                    }
                }

                submission = Console.ReadLine();
            }

            int maxPoints = 0;
            string winner = string.Empty;
            foreach (var item in userContests)
            {
                int sumPoints = 0;
                foreach (var contestPoints in item.Value)
                {
                    int currentPoints = contestPoints.Value;
                    sumPoints += currentPoints;
                }

                if (maxPoints < sumPoints)
                {
                    maxPoints = sumPoints;
                    winner = item.Key;
                }
            }

            Console.WriteLine($"Best candidate is {winner} with total {maxPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var item in userContests.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var contestsWithPoints in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contestsWithPoints.Key} -> {contestsWithPoints.Value}");
                }
            }
        }
    }
}
