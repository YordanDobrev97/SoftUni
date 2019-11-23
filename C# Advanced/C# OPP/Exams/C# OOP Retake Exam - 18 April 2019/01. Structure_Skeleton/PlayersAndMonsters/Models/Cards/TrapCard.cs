namespace PlayersAndMonsters.Models.Cards
{
    public class TrapCard : Card
    {
        private static int damagePoints = 120;
        private static int healthPoints = 5;

        public TrapCard(string name)
            : base(name, damagePoints, healthPoints)
        {
        }
    }
}
