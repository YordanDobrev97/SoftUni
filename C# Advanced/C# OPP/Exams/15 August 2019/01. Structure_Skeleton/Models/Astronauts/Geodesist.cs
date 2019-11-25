﻿namespace SpaceStation.Models.Astronauts
{
    public class Geodesist : Astronaut
    {
        private const double DefaultOxygen = 50;

        public Geodesist(string name) 
            : base(name, DefaultOxygen)
        {
        }
    }
}
