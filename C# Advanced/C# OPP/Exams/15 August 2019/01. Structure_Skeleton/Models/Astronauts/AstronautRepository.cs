﻿namespace SpaceStation.Models.Astronauts
{
    using SpaceStation.Models.Astronauts.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class AstronautRepository
    {
        private ICollection<IAstronaut> astronauts;

        public AstronautRepository()
        {
            this.astronauts = new List<IAstronaut>();
        }

        public void Add(IAstronaut astronaut)
        {
            this.astronauts.Add(astronaut);
        }

        public bool Remove(IAstronaut astronaut)
        {
            var element = FindByName(astronaut.Name);

            return this.astronauts.Remove(element);
        }

        public IAstronaut FindByName(string name)
        {
            var element = this.astronauts.FirstOrDefault(x => x.Name == name);
            return element;
        }
    }
}
