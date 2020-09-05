using System;
using System.Linq;

namespace PizzaCalories
{
    public class Dough
    {
        private string[] validTypesFlour;
        private string[] validTechniqueBaking;
        private const double White = 1.5;
        private const double Wholegrain = 1.0;
	    private const double Crispy = 0.9;
	    private const double Chewy = 1.1;
	    private const double Homemade = 1.0;

        private string flourType;
        private double weight;
        private string techniqueBaking;

        public Dough(string flourType, string technique, double weight)
        {
            this.validTechniqueBaking = new string[] { "Crispy", "Chewy", "Homemade" };
            this.validTypesFlour = new string[] { "White", "Wholegrain" };
            this.TypeFlour = flourType;
            this.Weight = weight;
            this.techniqueBaking = technique;
        }

        public string TypeFlour
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (!validTypesFlour.Contains(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value <= 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public string TechniqueBaking
        {
            get => this.techniqueBaking;
            private set
            {
                if (!validTechniqueBaking.Contains(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.techniqueBaking = value;
            }
        }

    }
}
