namespace PlayersAndMonsters.Models.Cards
{
    public class MagicCard : Card
    {
        private static int damagePoints = 5;
        private static int healthPoints = 80;

        public MagicCard(string name) 
            : base(name, damagePoints, healthPoints)
        {
        }
    }
}
