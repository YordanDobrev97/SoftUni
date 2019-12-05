using MortalEngines.Core;
using MortalEngines.IO.Contracts;
using System;

namespace MortalEngines.IO
{
    public class Command : ICommand
    {
        private MachinesManager machinesManager;
        private IReader reader;
        private IWriter writer;

        public Command()
        {
            this.machinesManager = new MachinesManager();
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();
        }

        public void Execute()
        {
            bool isEnd = false;
            while (true)
            {
                string[] line = Console.ReadLine().Split();

                switch (line[0])
                {
                    case "HirePilot":
                        writer.Write(machinesManager.HirePilot(line[1]));
                        break;
                    case "PilotReport":
                        writer.Write(machinesManager.PilotReport(line[1]));
                        break;
                    case "ManufactureTank":
                        writer.Write(machinesManager.ManufactureTank(line[1], double.Parse(line[2]), double.Parse(line[3])));
                        break;
                    case "ManufactureFighter":
                        writer.Write(machinesManager.ManufactureFighter(line[1], double.Parse(line[2]), double.Parse(line[3])));
                        break;
                    case "MachineReport":
                        writer.Write(machinesManager.MachineReport(line[1]));
                        break;
                    case "AggressiveMode":
                        writer.Write(machinesManager.ToggleFighterAggressiveMode(line[1]));
                        break;
                    case "DefenseMode":
                        writer.Write(machinesManager.ToggleTankDefenseMode(line[1]));
                        break;
                    case "Engage":
                        writer.Write(machinesManager.EngageMachine(line[1], line[2]));
                        break;
                    case "Attack":
                        writer.Write(machinesManager.AttackMachines(line[1], line[2]));
                        break;
                    case "Quit":
                        isEnd = true;
                        break;
                }

                if (isEnd)
                {
                    break;
                }
            }
        }
    }
}
