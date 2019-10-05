using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquariumAdventure.Models
{
    public class Aquarium
    {
        public Aquarium(string name, int capacity, int size)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Size = size;
            this.FishInPool = new List<Fish>();
        }

        public string Name { get; }

        public int Capacity { get;}

        public int Size { get; }

        public List<Fish> FishInPool { get; set; }

        public void Add(Fish fish)
        {
            if (this.FishInPool.Count <= this.Capacity 
                && !this.FishInPool.Exists(x => x.Name == fish.Name))
            {
                this.FishInPool.Add(fish);
            }
        } 

        public bool Remove(string name)
        {
           return this.FishInPool.Remove(this.FishInPool.Where(s => s.Name == name).FirstOrDefault());
        }

        public Fish FindFish(string name)
        {
            return this.FishInPool.Where(x => x.Name == name).FirstOrDefault();
        }

        public StringBuilder Report()
        {
            var output = new StringBuilder();

            output.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");

            foreach (var fishData in this.FishInPool)
            {
                output.AppendLine($"Fish: {fishData.Name}");
                output.AppendLine($"Color: {fishData.Color}");
                output.AppendLine($"Number of fins: {fishData.Fins}");
            }

            return output;
        }
    }
}
