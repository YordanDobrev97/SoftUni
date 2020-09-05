﻿using System.Collections.Generic;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Planets;
using System.Linq;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            foreach (var astronaut in astronauts)
            {
                while (astronaut.CanBreath)
                {
                    var currentItem = planet.Items.FirstOrDefault();

                    if (currentItem != null)
                    {
                        astronaut.Breath();
                        astronaut.Bag.Items
                            .Add(currentItem);
                        planet.Items.Remove(currentItem);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
