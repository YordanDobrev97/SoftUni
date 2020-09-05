using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;
        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == string.Empty || char.IsWhiteSpace(value[0]))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }

                this.age = value;
            }
        }

        public double ProductPerDay
        {
			get
			{				
				return this.CalculateProductPerDay();
			}
        }

        private double CalculateProductPerDay()
        {
            double result = 0;
            if (this.Age <= 3)
            {
                result = 1.5;
            }
            else if (this.Age <= 7) 
            {
                result = 2;
            }
            else if (this.Age <= 11)
            {
                result = 1;
            }
            else
            {
                result = 0.75;
            }

            return result;
        }
    }
}
