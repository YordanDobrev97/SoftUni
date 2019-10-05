using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.SpaceStationRecruitment
{
    public class SpaceStation
    {
        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Astronauts = new List<Astronaut>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.Astronauts.Count;

        public List<Astronaut> Astronauts { get; set; }

        public void Add(Astronaut astronaut)
        {
            if (this.Astronauts.Count <= this.Capacity)
            {
                this.Astronauts.Add(astronaut);
            }
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach (var item in this.Astronauts)
            {
                result.AppendLine($"Astronaut: {item.Name}, {item.Age} ({item.Country})");
            }

            return result.ToString();
        }

        public bool Remove(string name)
        {
            var currentAstronaut = this.Astronauts.FirstOrDefault(x => x.Name == name);

            if (currentAstronaut != null)
            {
                this.Astronauts.Remove(currentAstronaut);
                return true;
            }
            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut oldestAstronaut = null;

            int oldestAge = 0;
            foreach (var item in this.Astronauts)
            {
                if (oldestAge < item.Age)
                {
                    oldestAstronaut = item;
                    oldestAge = item.Age;
                }
            }

            return oldestAstronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            return this.Astronauts.FirstOrDefault(x => x.Name == name);
        }
    }
}
