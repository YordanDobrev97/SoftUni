using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MOBAChallenger
{
    class Program
    {
        static void Main()
        {
            var players = new Dictionary<string, Dictionary<string, int>>();

            string line = Console.ReadLine();

            while (line != "Season end")
            {
                string[] arguments = line.Split(new[] { " -> "}, 
                    StringSplitOptions.RemoveEmptyEntries);

                if (arguments.Length == 3)
                {
                    string player = arguments[0];
                    string position = arguments[1];
                    int skill = int.Parse(arguments[2]);

                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new Dictionary<string, int>());
                    }

                    if (!players[player].ContainsKey(position))
                    {
                        players[player].Add(position, skill);
                    }
                    else
                    {
                        if (players[player][position] < skill)
                        {
                            players[player][position] = skill;
                        }
                    }
                }
                else if (arguments.Length == 1)
                {
                    //vs
                    string firstPlayer = arguments[0].Split("vs")[0].Trim();
                    string secondPlayer = arguments[0].Split("vs")[1].Trim();

                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        var positionFirstPlayer = players[firstPlayer].Keys.ToList()[0];
                        var positionSecondPlayer = players[secondPlayer].Keys.ToList()[0];

                        if (positionFirstPlayer == positionSecondPlayer)
                        {
                            var skillOfFirstPlayer = players[firstPlayer].Values.ToList()[0];
                            var skillOfSecondPlayer = players[secondPlayer].Values.ToList()[0];

                            if (skillOfFirstPlayer > skillOfSecondPlayer)
                            {
                                players.Remove(secondPlayer);
                            }
                            else if (skillOfSecondPlayer > skillOfFirstPlayer)
                            {
                                players.Remove(firstPlayer);
                            }
                        }
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var currentPlayer in players.OrderByDescending(x => x.Value.Values).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currentPlayer.Key}: ");
                foreach (var item in currentPlayer.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }
    }
}
