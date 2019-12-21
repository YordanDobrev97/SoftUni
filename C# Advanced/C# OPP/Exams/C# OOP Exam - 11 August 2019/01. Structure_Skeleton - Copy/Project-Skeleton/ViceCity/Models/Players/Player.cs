using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string name;
        private int lifePoints;
        private IRepository<IGun> repository;

        public Player(string name, int lifePoints)
        {
            this.Name = name;
            this.LifePoints = lifePoints;
            this.IsAlive = true;
            this.repository = new GunRepository();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Player's name cannot be null or a whitespace!");
                }
                this.name = value;
            }
        }

        public bool IsAlive { get; private set; }

        public IRepository<IGun> GunRepository => this.repository;

        public int LifePoints
        {
            get => this.lifePoints;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player life points cannot be below zero!");
                }
                this.lifePoints = value;
            }
        }

        public void TakeLifePoints(int points)
        {
            if (this.LifePoints - points < 0)
            {
                this.LifePoints = 0;
                this.IsAlive = false;
            }
            else
            {
                this.lifePoints -= points;
            }

        }
    }
}
