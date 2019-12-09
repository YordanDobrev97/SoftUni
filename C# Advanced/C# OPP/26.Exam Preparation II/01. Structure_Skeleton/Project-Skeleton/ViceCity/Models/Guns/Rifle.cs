using System;

namespace ViceCity.Models.Guns
{
    public class Rifle : Gun
    {
        private static int DefaultBulletsPerBarrel = 50;
        private static int DefaultTotalBullets = 500;
        private int DefaultShootBullets = 5;

        public Rifle(string name) 
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
