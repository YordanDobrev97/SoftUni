using MilitaryElite.Contracts;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite.Core
{
    public class CommandExecutor
    {
        private Dictionary<int, ISoldier> soldiers;

        public CommandExecutor()
        {
            this.soldiers = new Dictionary<int, ISoldier>();
        }

        public void Execute()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] partsCommand = line.Split();
                string command = partsCommand[0];
                int id = int.Parse(partsCommand[1]);
                string firstName = partsCommand[2];
                string lastName = partsCommand[3];
                
                if (command == "Private")
                {
                    decimal salary = decimal.Parse(partsCommand[4]);
                    ISoldier @private = new Private(id, firstName, lastName, salary);
                    this.soldiers.Add(id, @private);
                }
                else if (command == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(partsCommand[4]);
                    List<int> privateIds = partsCommand.Skip(5).Select(int.Parse).ToList();

                    LieutenantGeneral lieutenant = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 0; i < privateIds.Count; i++)
                    {
                        int idSoldier = privateIds[i];
                        lieutenant.PrivateIds.Add(idSoldier, (IPrivate)soldiers[idSoldier]);
                    }
                    this.soldiers.Add(id, lieutenant);
                }
                else if  (command == "Engineer")
                {
                    decimal salary = decimal.Parse(partsCommand[4]);
                    string corps = partsCommand[5];
                    List<string> repairs = partsCommand.Skip(6)
                        .ToList();

                    Engineer engineer = new Engineer(id, firstName, lastName, salary);

                    switch (corps)
                    {
                        case "Marines":
                            engineer.TypeCorps = TypeCorps.Marines;
                            break;
                        case "Airforces":
                            engineer.TypeCorps = TypeCorps.Airforces;
                            break;
                        default:
                            continue;
                    }

                    for (int i = 0; i < repairs.Count; i+=2)
                    {
                        string partNameRepair = repairs[i];
                        int hourWorked = int.Parse(repairs[i + 1]);

                        Repair repair = new Repair(partNameRepair, hourWorked);
                        engineer.Repairs.Add(repair);
                    }

                    this.soldiers.Add(id, engineer);
                }
                else if (command == "Commando")
                {
                    decimal salary = decimal.Parse(partsCommand[4]);
                    bool isValidCorps = Enum.TryParse(partsCommand[5], out TypeCorps corps);
                  
                    if (!isValidCorps)
                    {
                        throw new ArgumentException("Invalid Corps");
                    }

                    List<Mission> missions = new List<Mission>();
                    for (int i = 6; i < partsCommand.Length; i+=2)
                    {
                        string codeNameMission = partsCommand[i];
                        string stateMission = partsCommand[i + 1];

                        State state = new State();
                        switch (stateMission)
                        {
                            case "inProgress":
                                state = State.inProgress;
                                break;
                            case "finished":
                                state = State.Finished;
                                break;
                            default:
                                continue;
                        }

                        Mission mission = new Mission(id, firstName, lastName, salary, codeNameMission, state);
                        missions.Add(mission);
                    }

                    var commando = new Commando(id, firstName, lastName, salary, missions);
                    
                    this.soldiers.Add(id, commando);
                }
                else if (command == "Spy")
                {
                    int codeNumber = int.Parse(partsCommand[4]);
                    Spy spy = new Spy(id, firstName, lastName, codeNumber);
                    this.soldiers.Add(id, spy);
                }
            }

            foreach (var item in this.soldiers)
            {
                Console.WriteLine(item.Value.ToString());
            }
        }
    }
}
