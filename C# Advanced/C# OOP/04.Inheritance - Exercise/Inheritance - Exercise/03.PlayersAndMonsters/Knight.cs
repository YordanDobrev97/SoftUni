namespace PlayersAndMonsters
{
    public class Knight : Hero
    {
        public Knight(string  username, int level)
            : base (username, level)
        {
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
