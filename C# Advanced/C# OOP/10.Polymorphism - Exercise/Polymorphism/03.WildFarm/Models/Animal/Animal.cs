using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animal
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public abstract List<Type> EatFoods { get; }

        public abstract string ProducingSound();

        public abstract bool Food(Food food);

        public abstract double DefaultValue { get; }

        public  void IncreasWeight(Food food)
        {
            this.Weight += food.Quantity * DefaultValue;
            this.FoodEaten += food.Quantity;
        }
    }
}
