using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private IList<IDecoration> decorations;
        private IList<IFish> fishes;

        public Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.decorations = new List<IDecoration>();
            this.fishes = new List<IFish>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aquarium name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Capacity { get; private set; }

        public int Comfort => this.Decorations.Sum(x => x.Comfort);

        public ICollection<IDecoration> Decorations => this.decorations.ToList().AsReadOnly();

        public ICollection<IFish> Fish => this.fishes.ToList().AsReadOnly();

        public void AddDecoration(IDecoration decoration)
        {
            this.decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            this.fishes.Add(fish);
        }

        public void Feed()
        {
            foreach (var item in this.Fish)
            {
                item.Eat();
            }
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name} ({this.Name.GetType().Name}):");
            sb.AppendLine($"Fish: {string.Join(", ", this.Fish)}");
            sb.AppendLine($"Decorations: {this.Decorations.Count}");
            sb.AppendLine($"Comfort: {this.Comfort}");
            return sb.ToString();
        }

        public bool RemoveFish(IFish fish)
        {
            var fishRemoved = this.fishes.FirstOrDefault(x => x.Name == fish.Name);

            return this.Fish.Remove(fishRemoved);
        }
    }
}
