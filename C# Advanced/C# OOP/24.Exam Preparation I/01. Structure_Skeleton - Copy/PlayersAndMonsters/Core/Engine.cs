using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.IO;
using PlayersAndMonsters.IO.Contracts;
using System;

namespace PlayersAndMonsters.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IManagerController controller;

        public Engine(IReader reader, IWriter writer, IManagerController controller)
        {
            this.reader = reader;
            this.writer = writer;
            this.controller = controller;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string[] lineElements = reader.ReadLine().Split(" ", 
                        StringSplitOptions.RemoveEmptyEntries);

                    if (lineElements[0] == "Exit")
                    {
                        break;
                    }

                    string message = string.Empty;
                    if (lineElements[0] == "AddPlayer")
                    {
                        message = controller.AddPlayer(lineElements[1], lineElements[2]);
                    }
                    else if (lineElements[0] == "AddCard")
                    {
                        message = controller.AddCard(lineElements[1], lineElements[2]);
                    }
                    else if (lineElements[0] == "AddPlayerCard")
                    {
                        message = controller.AddPlayerCard(lineElements[1], lineElements[2]);
                    }
                    else if (lineElements[0] == "Fight")
                    {
                        message = controller.Fight(lineElements[1], lineElements[2]);
                    }
                    else if (lineElements[0] == "Report")
                    {
                        message = controller.Report();
                    }

                    writer.WriteLine(message);
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
