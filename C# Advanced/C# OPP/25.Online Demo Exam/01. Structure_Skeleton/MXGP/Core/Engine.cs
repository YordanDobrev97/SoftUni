using MXGP.IO;
using System;

namespace MXGP.Core
{
    public class Engine
    {
        private ChampionshipController controller;
        private ConsoleReader reader;
        private ConsoleWriter writer;

        public Engine()
        {
            this.controller = new ChampionshipController();
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string[] input = reader.ReadLine().Split();

                    if (input[0] == "End")
                    {
                        break;
                    }

                    if (input[0] == "CreateRider")
                    {
                        writer.WriteLine(controller.CreateRider(input[1]));
                    }
                    else if (input[0] == "CreateMotorcycle")
                    {
                        writer.WriteLine(controller.CreateMotorcycle(input[1], input[2], int.Parse(input[3])));
                    }
                    else if (input[0] == "AddMotorcycleToRider")
                    {
                        writer.WriteLine(controller.AddMotorcycleToRider(input[1], input[2]));
                    }
                    else if (input[0] == "AddRiderToRace")
                    {
                        writer.WriteLine(controller.AddRiderToRace(input[1], input[2]));
                    }
                    else if (input[0] == "CreateRace")
                    {
                        writer.WriteLine(controller.CreateRace(input[1], int.Parse(input[2])));
                    }
                    else if (input[0] == "StartRace")
                    {
                        writer.WriteLine(controller.StartRace(input[1]));
                    }
                }
                catch (Exception e)
                {
                    writer.WriteLine(e.Message);
                }
            }
        }
    }
}
