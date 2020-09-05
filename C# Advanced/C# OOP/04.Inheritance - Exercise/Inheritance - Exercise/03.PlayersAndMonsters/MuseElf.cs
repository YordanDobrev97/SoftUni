﻿namespace PlayersAndMonsters
{
    public class MuseElf : Elf
    {
        public MuseElf(string username, int level) 
            : base (username, level)
        {
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
