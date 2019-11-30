﻿using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Planets;
using SpaceStation.Utilities.Messages;
using System;
using System.Linq;
using System.Text;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private AstronautRepository astronautRepository = new AstronautRepository();
        private PlanetRepository planetRepository = new PlanetRepository();
        private Mission mission = new Mission();
 
        public string AddAstronaut(string type, string astronautName)
        {
            var getNamespace = "SpaceStation.Models.Astronauts";
            var getType = Type.GetType($"{getNamespace}.{type}");
            var instanceAstronaut = (IAstronaut)Activator.
                CreateInstance(getType, astronautName);

            if (instanceAstronaut == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
            }

            astronautRepository.Add(instanceAstronaut);
            return $"Successfully added {type}: {astronautName}!";
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            var getNamespace = "SpaceStation.Models.Planets";
            var getType = Type.GetType($"{getNamespace}.Planet");
            var instancePlanet = (IPlanet)Activator.CreateInstance(getType, items);

            planetRepository.Add(instancePlanet);

            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName)
        {
            var planet = planetRepository.FindByName(planetName);

            if (planet == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
            }

            var missionAstronants = astronautRepository.
                Models
                .Where(x => x.Oxygen > 60)
                .ToList();

            mission.Explore(planet, missionAstronants);
            return $"Planet: {planetName} was explored! Exploration finished with {missionAstronants.Count} dead astronauts!";
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"{planetRepository.Models.Count} planets were explored!");
            output.AppendLine("Astronauts info:");

            foreach (var item in astronautRepository.Models)
            {
                string name = item.Name;
                double oxygen = item.Oxygen;
                var bagItems = item.Bag.Items;

                output.AppendLine($"Name: {name}");
                output.AppendLine($"Oxygen: {oxygen}");
                output.AppendLine($"Bag items: {string.Join(", ", bagItems)}");
            }

            return output.ToString();
        }

        public string RetireAstronaut(string astronautName)
        {
            IAstronaut astronaut = astronautRepository.FindByName(astronautName);

            if (astronaut == null)
            {
                string message = string.Format(ExceptionMessages.InvalidRetiredAstronaut, astronautName);
                throw new InvalidOperationException(message);
            }

            astronautRepository.Remove(astronaut);
            return $"Astronaut {astronautName} was retired!";
        }
    }
}
