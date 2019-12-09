using System;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public abstract class Gun : IGun
    {
        private const string MessageInvalidName = "Name cannot be null or a white space!";
        private const string MessageInvalidBulletsPerBarrel = "Bullets cannot be below zero!";
        private const string MessageInvalidTotalBullets = "Total bullets cannot be below zero!";

        private string name;
        private int bulletsPerBarrel;
        private int totalBullets;

        protected Gun(string name, int bulletsPerBarrel, int totalBullets)
        {
            this.Name = name;
            this.BulletsPerBarrel = bulletsPerBarrel;
            this.TotalBullets = totalBullets;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(MessageInvalidName);
                }
                this.name = value;
            }
        }

        public int BulletsPerBarrel
        {
            get => this.bulletsPerBarrel;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(MessageInvalidBulletsPerBarrel);
                }
                this.bulletsPerBarrel = value;
            }
        }

        public int TotalBullets
        {
            get => this.totalBullets;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(MessageInvalidTotalBullets);
                }
                this.totalBullets = value;
            }
        }

        public bool CanFire => BulletsPerBarrel > 0 && TotalBullets > 0;

        public abstract int Fire();
    }
}
