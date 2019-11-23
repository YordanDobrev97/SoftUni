using PlayersAndMonsters.Core;
using PlayersAndMonsters.Models.BattleFields;
using PlayersAndMonsters.Repositories;

namespace PlayersAndMonsters.IO
{
    public class Engine
    {
        public void Run()
        {
            PlayerRepository repository = new PlayerRepository();
            CardRepository cardRepository = new CardRepository();
            BattleField battleField = new BattleField();

            ManagerController manager = new ManagerController(repository,
                cardRepository, battleField);

            while (true)
            {
                var reader = new ConsoleReader();
                var writer = new ConsoleWriter();
                string line = reader.ReadLine();

                if (line == "Exit")
                {
                    break;
                }

                string[] items = line.Split();
                string command = items[0];

                switch (command)
                {
                    case "AddPlayer":
                        writer.WriteLine(manager.AddPlayer(items[1], items[2]));
                        break;
                    case "AddCard":
                        writer.WriteLine(manager.AddCard(items[1], items[2]));
                        break;
                    case "Fight":
                        writer.WriteLine(manager.Fight(items[1], items[2]));
                        break;
                    case "AddPlayerCard":
                        manager.AddPlayerCard(items[1], items[2]);
                        break;
                    case "Report":
                        writer.WriteLine(manager.Report());
                        break;
                }
            }
        }
    }
}
