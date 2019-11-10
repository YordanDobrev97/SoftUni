using System.Text;

namespace Cars
{
    public class Tesla : Car, ICar, IElectricCar
    {  
        public Tesla(string model, string color, int battery)
            : base (model, color, battery)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries");
            sb.AppendLine(this.Start());
            sb.Append(this.Stop());

            return sb.ToString();
        }
    }
}
