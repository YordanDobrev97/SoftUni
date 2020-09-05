namespace ViceCity.Models.Guns
{
    public class Rifle : Gun
    {
        private const int InitialBulletPerBarrel = 50;
        private const int InitialTotalBullets = 500;
        private const int CurrentCountBullets = 5;

        public Rifle(string name)
            : base(name, InitialBulletPerBarrel, InitialTotalBullets)
        {
        }

        public override int Fire()
        {
            if (this.BulletsPerBarrel - CurrentCountBullets <= 0 && InitialBulletPerBarrel > 0)
            {
                this.TotalBullets -= InitialBulletPerBarrel;
                this.BulletsPerBarrel -= CurrentCountBullets;
                this.BulletsPerBarrel = InitialBulletPerBarrel;
            }
            else
            {
                this.BulletsPerBarrel -= CurrentCountBullets;
            }

            return InitialBulletPerBarrel;
        }
    }
}
