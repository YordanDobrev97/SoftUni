namespace SpaceStation.Models.Astronauts
{
    public class Biologist : Astronaut
    {
        private const double DefaultOxygen = 70;

        public Biologist(string name) 
            : base(name, DefaultOxygen)
        {
        }

        public override void Breath()
        {
            if (this.CanBreath)
            {
                this.Oxygen -= 5;
            }
        }
    }
}
