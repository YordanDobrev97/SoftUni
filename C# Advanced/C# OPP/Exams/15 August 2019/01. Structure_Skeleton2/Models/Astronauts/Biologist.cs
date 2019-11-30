﻿namespace SpaceStation.Models.Astronauts
{
    public class Biologist : Astronaut
    {
        public Biologist(string name) 
            : base(name, 70)
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
