using MilitaryElite.Contracts;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private
    {
        private Dictionary<int, IPrivate> privateIds;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privateIds = new Dictionary<int, IPrivate>();
        }

        public Dictionary<int, IPrivate> PrivateIds
        {
            get => this.privateIds;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine("Privates:");

            foreach (var item in this.PrivateIds)
            {
                sb.AppendLine($"  {item.Value.ToString()}");
            }

            return sb.ToString();
        }
    }
}
