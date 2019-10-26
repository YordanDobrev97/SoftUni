using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> rabbits;

        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.rabbits = new List<Rabbit>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.rabbits.Count;

        public void Add(Rabbit rabbit)
        {
            if (this.rabbits.Count < this.Capacity)
            {
                this.rabbits.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            var rabit = this.rabbits.FirstOrDefault(x => x.Name == name);
            return this.rabbits.Remove(rabit);
        }

        public void RemoveSpecies(string species)
        {
            var allSpecies = this.rabbits.RemoveAll(x => x.Species == species);
        }

        public Rabbit SellRabbit(string name)
        {
            var currentRabit = this.rabbits.FirstOrDefault(x => x.Name == name);
            currentRabit.Available = false;

            return currentRabit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            List<Rabbit> rabbits = new List<Rabbit>();
            foreach (var item in this.rabbits)
            {
                if (item.Species == species)
                {
                    var currentRabit = SellRabbit(item.Name);
                    rabbits.Add(currentRabit);
                }
            }

            return rabbits.ToArray();
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Rabbits available at {Name}:");

            foreach (var item in this.rabbits)
            {
                output.AppendLine(item.ToString());
            }

            return output.ToString().TrimEnd();
        }
    }
}
