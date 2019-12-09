using System;

namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        private static int DefaultBulletsPerBarrel = 10;
        private static int DefaultTotalBullets = 100;
        private const int DefaultShootBullets = 1;

        public Pistol(string name) 
            : base(name, DefaultBulletsPerBarrel, DefaultTotalBullets)
        {
        }

        public override int Fire()
        {
            if (this.BulletsPerBarrel == 0 && this.TotalBullets == 0)
            {
                return 0;
            }

            if (this.BulletsPerBarrel - DefaultShootBullets < 0)
            {
                Reload();
            }

            this.BulletsPerBarrel -= DefaultShootBullets;

            return DefaultShootBullets;
        }

        private void Reload()
        {
            DefaultTotalBullets -= DefaultBulletsPerBarrel;
            this.BulletsPerBarrel = DefaultBulletsPerBarrel;
        }
    }
}
