using System.Collections.Generic;
using SpaceStation.Repositories.Contracts;
using System.Linq;

namespace SpaceStation.Models.Planets
{
    public class PlanetRepository
    {
        private List<IPlanet> planets  = new List<IPlanet>();

        public IReadOnlyCollection<IPlanet> Models => this.planets.AsReadOnly();

        public void Add(IPlanet model)
        {
            this.planets.Add(model);
        }

        public IPlanet FindByName(string name)
        {
            var planet = this.planets.FirstOrDefault(x => x.Name == name);
            return planet;
        }

        public bool Remove(IPlanet model)
        {
            return this.planets.Remove(model);
        }
    }
}
