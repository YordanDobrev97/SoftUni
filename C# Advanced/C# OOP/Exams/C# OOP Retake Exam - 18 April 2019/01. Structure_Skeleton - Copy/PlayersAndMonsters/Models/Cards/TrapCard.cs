namespace PlayersAndMonsters.Models.Cards
{
    public class TrapCard : Card
    {
        private const int DefaultDamangePoints = 120;
        private const int DefaultHealthPoints = 5;

        public TrapCard(string name) 
            : base(name, DefaultDamangePoints, DefaultHealthPoints)
        {
        }
    }
}
