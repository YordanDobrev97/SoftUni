using PlayersAndMonsters.Models.Cards.Contracts;
using System;

namespace PlayersAndMonsters.Models.Cards
{
    public abstract class Card : ICard
    {
        private string name;
        private int damangePoints;
        private int healthPoints;

        public Card(string name, int damagePoints, int healthPoints)
        {
            this.Name = name;
            this.DamagePoints = damagePoints;
            this.HealthPoints = healthPoints;
        }

        public string Name 
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Card's name cannot be null or an empty string.");
                }

                this.name = value;
            }
        }

        public int DamagePoints
        {
            get => this.damangePoints;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Card's damage points cannot be less than zero.");
                }
                this.damangePoints = value;
            }
        }

        public int HealthPoints
        {
            get => this.healthPoints;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Card's HP cannot be less than zero.");
                }
                this.healthPoints = value;
            }
        }
    }
}
