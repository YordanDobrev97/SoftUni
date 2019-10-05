namespace AquariumAdventure
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

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

        public int Capacity { get; }

        public int Size { get; }

        public List<Fish> FishInPool { get; set; }

        public void Add(Fish fish)
        {
            if (this.FishInPool.Count < this.Capacity 
                && !this.FishInPool.Exists(x => x.Name == fish.Name))
            {
                this.FishInPool.Add(fish);
            }
        }

        public bool Remove(string name)
        {
            return this.FishInPool.Remove(this.FishInPool.
                Where(x => x.Name == name).FirstOrDefault());
        }

        public Fish FindFish(string name)
        {
            return this.FishInPool.Find(x => x.Name == name);
        }

        public string Report()
        {
            var output = new StringBuilder();

            output.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");

            foreach (var item in this.FishInPool)
            {
                output.AppendLine($"{item}");
            }

            return output.ToString();
        }
    }
}
