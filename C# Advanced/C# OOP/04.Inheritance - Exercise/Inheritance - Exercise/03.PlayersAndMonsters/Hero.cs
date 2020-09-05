namespace PlayersAndMonsters
{
    public abstract class Hero
    {
        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }

        public string Username { get; set; }

        public int Level { get; set; }
    }
}
