using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> astronauts;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.astronauts = new List<Astronaut>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.astronauts.Count;

        public void Add(Astronaut astronaut)
        {
            if (this.astronauts.Count < this.Capacity)
            {
                this.astronauts.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            var result = this.astronauts.FirstOrDefault(x => x.Name == name);
            //Astronaut result = null;

            //foreach (var item in this.astronauts)
            //{
            //    if (item.Name == name)
            //    {
            //        result = item;
            //        break;
            //    }
            //}

            return this.astronauts.Remove(result);
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut oldest = new Astronaut(string.Empty, int.MinValue, string.Empty);

            foreach (var item in this.astronauts)
            {
                if (item.Age > oldest.Age)
                {
                    oldest = item;
                }
            }

            return oldest;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut result = this.astronauts.FirstOrDefault(x => x.Name == name);

            return result;
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach (var item in this.astronauts)
            {
                output.AppendLine(item.ToString());
            }

            return output.ToString().TrimEnd();
        }
    }
}