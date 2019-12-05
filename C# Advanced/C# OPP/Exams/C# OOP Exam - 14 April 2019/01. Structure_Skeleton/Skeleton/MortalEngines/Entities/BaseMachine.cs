using System;
using System.Collections.Generic;
using MortalEngines.Entities.Contracts;
using System.Linq;
using System.Text;

namespace MortalEngines.Entities
{
    public abstract class BaseMachine : IMachine
    {
        private string name;

        public BaseMachine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.Targets = new List<string>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Machine name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public IPilot Pilot { get; set; } 

        public double HealthPoints { get; set; }

        public double AttackPoints { get; set; }

        public double DefensePoints { get; set; }

        public IList<string> Targets { get; private set; }

        public void Attack(IMachine target)
        {
            this.HealthPoints -= Math.Abs(AttackPoints - target.DefensePoints);

            if (this.HealthPoints < 0)
            {
                this.HealthPoints = 0;
            }

            this.Targets.Add(target.Name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"- {this.Name}");
            sb.AppendLine($" *Type: {this.name.GetType().Name}");
            sb.AppendLine($" *Health: {this.HealthPoints}");
            sb.AppendLine($" *Attack: {this.AttackPoints}");
            sb.AppendLine($" *Defense: {this.DefensePoints}");
            sb.AppendLine("*Targets: ");

            foreach (var item in this.Targets)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
    }
}
