using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier
    {
        List<Mission> missions;

        public Commando(int id, string firstName, string lastName, decimal salary, List<Mission> missions) 
            : base(id, firstName, lastName, salary)
        {
            this.missions = missions;
        }

        public List<Mission> Missions
        {
            get => this.missions;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.TypeCorps}");
            sb.AppendLine($"Missions:");

            foreach (var item in this.Missions)
            {
                var state = item.State;
                if (state == State.inProgress)
                {
                    sb.AppendLine($"  {item.ToString()}");
                }
            }

            return sb.ToString();
        }
    }
}
