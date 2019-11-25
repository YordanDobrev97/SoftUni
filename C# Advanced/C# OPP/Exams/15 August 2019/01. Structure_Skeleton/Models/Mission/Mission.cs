using System.Collections.Generic;
using System.Linq;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Planets;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            foreach (var item in astronauts)
            {
               
            }
        }
    }
}
