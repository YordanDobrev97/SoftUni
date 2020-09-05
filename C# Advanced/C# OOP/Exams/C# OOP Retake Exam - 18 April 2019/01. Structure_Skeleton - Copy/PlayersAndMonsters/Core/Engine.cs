using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.Models.BattleFields;
using System;

namespace PlayersAndMonsters.Core
{
    public class Engine : IEngine
    {
        private ManagerController managerController;

        public Engine()
        {
            this.managerController = new ManagerController();
        }

        public void Run()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Exit")
                {
                    break;
                }

                if (input[0] == "AddPlayer")
                {
                    Console.WriteLine(managerController.AddPlayer(input[1], input[2]));
                }
                else if (input[0] == "AddCard")
                {
                    Console.WriteLine(managerController.AddCard(input[1], input[2]));
                }
                else if (input[0] == "AddPlayerCard")
                {
                    Console.WriteLine(managerController.AddPlayerCard(input[1], input[2]));
                }
                else if (input[0] == "Fight")
                {
                    Console.WriteLine(managerController.Fight(input[1], input[2]));
                }
                else if (input[0] == "Report")
                {
                    Console.WriteLine(managerController.Report());
                }
            }
        }
    }
}
