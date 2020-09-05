namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        private const int DefaultIncreasValue = 5;
        private int food;
        private string name;
        private int age;
        private string group;

        public Rebel(string name, int age, string group)
        {
            this.name = name;
            this.age = age;
            this.group = group;
        }

        public int Food
        {
            get => this.food;
            set => this.food = value;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public void BuyFood()
        {
            this.Food += DefaultIncreasValue;
        }
    }
}
