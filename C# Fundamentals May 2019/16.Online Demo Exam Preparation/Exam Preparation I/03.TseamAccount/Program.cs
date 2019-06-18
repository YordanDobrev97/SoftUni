using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TseamAccount
{
    class Program
    {
        static void Main()
        {
            List<string> games = Console.ReadLine()
                .Split()
                .ToList();
            string line = Console.ReadLine();

            while (line != "Play!")
            {
                string[] argumentsLine = line.Split();

                string command = argumentsLine[0];
                string game = argumentsLine[1];
                switch (command)
                {
                    case "Install":
                        if (!games.Contains(game))
                        {
                            games.Add(game);
                        }
                        break;
                    case "Uninstall":
                        if (games.Contains(game))
                        {
                            games.Remove(game);
                        }
                        break;
                    case "Update":
                        if (games.Contains(game))
                        {
                            int indexOfGame = games.IndexOf(game);
                            string saveGame = games[indexOfGame];
                            games.RemoveAt(indexOfGame);
                            games.Add(saveGame);
                        }    
                        break;
                    case "Expansion":
                        string expansion = game.Split('-')[1];
                        game = game.Split('-')[0];
                        if (games.Contains(game))
                        {
                            int index = games.IndexOf(game);
                            games.Insert(index + 1, $"{game}:{expansion}");
                        }
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", games));
        }
    }
}
