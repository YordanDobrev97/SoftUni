using System.Collections.Generic;
using System.Linq;
using SpaceStation.Models.Astronauts.Contracts;

namespace SpaceStation.Models.Astronauts
{
    public class AstronautRepository
    {
        private List<IAstronaut> astronauts;

        public AstronautRepository()
        {
            this.astronauts = new List<IAstronaut>();
        }

        public IReadOnlyCollection<IAstronaut> Models => this.astronauts.AsReadOnly();

        public void Add(IAstronaut model)
        {
            this.astronauts.Add(model);
        }

        public IAstronaut FindByName(string name)
        {
            var astronaut = astronauts.FirstOrDefault(x => x.Name== name);
            return astronaut;
        }

        public bool Remove(IAstronaut model)
        {
            return this.astronauts.Remove(model);
        }
    }
}
