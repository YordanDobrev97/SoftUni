using MortalEngines.Entities.Contracts;
using System.Text;

namespace MortalEngines.Entities
{
    public class Tank : BaseMachine, ITank
    {
        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, 100)
        {
            this.DefenseMode = true;
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
                this.DefenseMode = false;
            }
            else
            {
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
                this.DefenseMode = true;
            }
        }

        public override string ToString()
        {
            var baseStr = base.ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(baseStr);
            string state = this.DefenseMode ? "ON" : "OFF";
            sb.AppendLine($" *Defense: {state}");
            return sb.ToString();
        }
    }
}
