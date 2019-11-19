namespace MilitaryElite.Models
{
    public class Mission : SpecialisedSoldier
    {
        public Mission(int id, string firstName, string lastName, decimal salary, string codeName, State state)
            : base(id, firstName, lastName, salary)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; set; }

        public State State { get; set; }

        public void CompleteMission()
        {
            this.State = State.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
