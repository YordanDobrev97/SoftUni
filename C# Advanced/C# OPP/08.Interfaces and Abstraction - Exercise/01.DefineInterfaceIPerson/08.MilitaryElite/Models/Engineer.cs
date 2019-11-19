using System.Collections.Generic;
using System.Text;
using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<Repair> repairs;

        public Engineer(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.repairs = new List<Repair>();
        }

        public List<Repair> Repairs
        {
            get => this.repairs;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.TypeCorps}");

            sb.AppendLine($"Repairs:");
            foreach (var item in this.Repairs)
            {
                sb.AppendLine($"  {item.ToString()}");
            }

            return sb.ToString();
        }
    }
}
