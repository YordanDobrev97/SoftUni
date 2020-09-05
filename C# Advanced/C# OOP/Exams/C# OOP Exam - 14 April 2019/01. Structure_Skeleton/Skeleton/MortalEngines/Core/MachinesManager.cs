namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Entities;
    using MortalEngines.Entities.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private List<IMachine> machines;
        private List<IPilot> pilots;

        public MachinesManager()
        {
            this.pilots = new List<IPilot>();
            this.machines = new List<IMachine>();
        }

        public string HirePilot(string name)
        {
            if (pilots.Any(x => x.Name == name))
            {
                return $"Pilot {name} is hired already";
            }

            IPilot pilot = new Pilot(name);
            this.pilots.Add(pilot);
            return $"Pilot {name} hired";
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (this.machines.Any(x => x.Name == name))
            {
                return "Machine {name} is manufactured already";
            }
            ITank tank = new Tank(name, attackPoints, defensePoints);
            this.machines.Add(tank);
            tank.ToggleDefenseMode();

            return $"Tank {name} manufactured - attack: {tank.AttackPoints:F2}; defense: {tank.DefensePoints:F2}";
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (this.machines.Any(x => x.Name == name))
            {
                return $"Machine {name} is manufactured already";
            }

            var fighter = new Fighter(name, attackPoints, defensePoints);
            this.machines.Add(fighter);
            fighter.ToggleAggressiveMode();

            return $"Fighter {name} manufactured - attack: {fighter.AttackPoints:F2}; defense: {fighter.DefensePoints:F2}; aggressive: ON";
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            if (!this.pilots.Any(x => x.Name == selectedPilotName))
            {
                return $"Pilot {selectedPilotName} could not be found";
            }

            if (!this.machines.Any(x => x.Name == selectedMachineName))
            {
                return $"Machine {selectedMachineName} could not be found";
            }

            var machine = this.machines.FirstOrDefault(x => x.Name == selectedMachineName);
            var pilot = this.pilots.FirstOrDefault(x => x.Name == selectedPilotName);
            if (machine.Pilot != null)
            {
                return $"Machine {selectedMachineName} is already occupied";
            }

            if (pilot != null)
            {
                return $"Pilot {selectedPilotName} engaged machine {selectedMachineName}";
            }

            machine.Pilot = pilot;
            pilot.AddMachine(machine);

            return $"Pilot {pilot.Name} engaged machine {machine.Name}";
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            if (!this.machines.Any(x => x.Name == attackingMachineName))
            {
                return $"Machine {attackingMachineName} could not be found";
            }

            if (!this.machines.Any(x => x.Name == defendingMachineName))
            {
                return $"Machine {defendingMachineName} could not be found";
            }

            var attackedMachine = this.machines.FirstOrDefault(x => x.Name == attackingMachineName);
            var defendingMachine = this.machines.FirstOrDefault(x => x.Name == defendingMachineName);

            if (attackedMachine.HealthPoints <= 0)
            {
                return $"Dead machine {attackingMachineName} cannot attack or be attacked";
            }

            if (defendingMachine.HealthPoints <= 0)
            {
                return $"Dead machine {defendingMachineName} cannot attack or be attacked";
            }

            attackedMachine.Attack(defendingMachine);
            return $"Machine {defendingMachine} was attacked by machine {attackingMachineName} - current health: {defendingMachine.HealthPoints}";
        }

        public string PilotReport(string pilotReporting)
        {
           return this.pilots.FirstOrDefault(x => x.Name == pilotReporting).Report();
        }

        public string MachineReport(string machineName)
        {
            return this.pilots.FirstOrDefault(x => x.Name == machineName).ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            var fighter = this.machines.FirstOrDefault(x => x.Name == fighterName);

            if (fighter != null)
            {
                return $"Fighter {fighterName} toggled aggressive mode";
            }

            return $"Machine {fighterName} could not be found";
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            var tank = this.machines.FirstOrDefault(x => x.Name == tankName);

            if (tank != null)
            {
                return $"Tank {tankName} toggled defense mode";
            }

            return $"Machine {tankName} could not be found";
        }
    }
}