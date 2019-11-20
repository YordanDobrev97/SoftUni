using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animal
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
            this.EatFoods = new List<Type>();
            this.EatFoods.Add(typeof(Meat));
        }

        public override List<Type> EatFoods { get; }

        public override double DefaultValue => 0.25;

        public override bool Food(Food food)
        {
            if (!this.EatFoods.Contains(food.GetType()))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            return true;
        }

        public override string ProducingSound()
        {
            return "Hoot Hoot";
        }
    }
}
