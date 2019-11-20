using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animal
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
            this.EatFoods = new List<Type>();
            this.EatFoods.Add(typeof(Fruit));
            this.EatFoods.Add(typeof(Meat));
            this.EatFoods.Add(typeof(Seeds));
            this.EatFoods.Add(typeof(Vegetable));
        }

        public override List<Type> EatFoods { get; }
        public override double DefaultValue => 0.35;

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
            return "Cluck";
        }        
    }
}
