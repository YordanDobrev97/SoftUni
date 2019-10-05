namespace AquariumAdventure
{
    using System.Text;

    public class Fish
    {
        public Fish(string name, string color, int fins)
        {
            this.Name = name;
            this.Color = color;
            this.Fins = fins;
        }

        public string Name { get; }

        public string Color { get; }

        public int Fins { get;}

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Fish: {this.Name}");
            output.AppendLine($"Color: {this.Color}");
            output.AppendLine($"Number of fins: {this.Fins}");

            return output.ToString();
        }

    }
}
