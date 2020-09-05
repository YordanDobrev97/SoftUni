using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private TypeCorps typeCorps;

        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.typeCorps = new TypeCorps();
        }

        public TypeCorps TypeCorps
        {
            get => this.typeCorps;
            set => this.typeCorps = value;
        }
    }
}
