using System;

namespace FoodShortage
{
    public class Citizen : IIdentifiable, IBirthdable, IBuyer
    {
        private const int DefaultIncreasValue = 10;
        private string id;
        private string name;
        private int age;
        private DateTime birthday;
        private int food;

        public Citizen(string name, int age, string id, DateTime birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.birthday = birthday;
        }

        public string Id
        {
            get => this.id;
            private set => this.id = value;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int Age
        {
            get => this.age;
            private set => this.age = value;
        }

        public DateTime Birthday
        {
            get => this.birthday;
            set => this.birthday = value;
        }
        public int Food
        {
            get => this.food;
            set => this.food = value;
        }

        public void BuyFood()
        {
            this.Food += DefaultIncreasValue;
        }
    }
}
