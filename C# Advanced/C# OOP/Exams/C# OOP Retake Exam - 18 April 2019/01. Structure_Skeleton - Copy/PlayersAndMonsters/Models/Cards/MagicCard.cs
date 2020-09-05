namespace PlayersAndMonsters.Models.Cards
{
    public class MagicCard : Card
    {
        private const int DefaultDamangeCard = 5;
        private const int DefaultHealthPoints = 80;

        public MagicCard(string name) 
            : base(name, DefaultDamangeCard, DefaultHealthPoints)
        {
        }
    }
}
