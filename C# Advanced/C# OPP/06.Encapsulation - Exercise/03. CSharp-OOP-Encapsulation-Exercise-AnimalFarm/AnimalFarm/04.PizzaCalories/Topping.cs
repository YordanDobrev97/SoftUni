using System.Linq;

namespace PizzaCalories
{
    public class Topping
    {
        private string[] validFourTypes;
        private const double Meat = 1.2;
        private const double Veggies = 0.8;
        private const double Cheese = 1.1;
        private const double Sauce = 0.9;

        private double weight;
        private double four;

        public Topping(double weight, string four)
        {
            this.validFourTypes = new string[] { "meat", "veggies", "cheese", "sauce" };
            this.Weight = weight;
        }

        public double Weight
        {
            get => this.weight;
            private set => this.weight = value;
        }

        public double Four
        {
            get => this.four;
            private set
            {
                
            }
        }
    }
}
