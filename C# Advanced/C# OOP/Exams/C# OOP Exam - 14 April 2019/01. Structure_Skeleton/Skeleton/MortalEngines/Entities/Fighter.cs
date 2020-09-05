using System.Collections.Generic;
using System.Text;
using MortalEngines.Entities.Contracts;

namespace MortalEngines.Entities
{
    public class Fighter : BaseMachine, IFighter
    {
        public Fighter(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, 200)
        {
            this.AggressiveMode = true;
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            if (this.AggressiveMode)
            {
                this.AttackPoints += 50;
                this.DefensePoints -= 25;
                this.AggressiveMode = false;
            }
            else
            {
                this.AttackPoints -= 50;
                this.DefensePoints += 25;
                this.AggressiveMode = false;
            }
        }

        public override string ToString()
        {
            var baseStr =  base.ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(baseStr);
            string state = this.AggressiveMode ? "ON" : "OFF";
            sb.AppendLine($" *Aggressive: {state}");

            return sb.ToString();
        }
    }
}
