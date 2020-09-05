namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        private const int InitialBulletPerBarrel = 10;
        private const int InitialTotalBullets = 100;
        private const int CurrentCountBullets = 1;

        public Pistol(string name) 
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
