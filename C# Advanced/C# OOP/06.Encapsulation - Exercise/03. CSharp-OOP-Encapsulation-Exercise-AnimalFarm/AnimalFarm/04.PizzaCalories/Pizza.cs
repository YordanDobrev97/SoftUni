namespace PizzaCalories
{
    public class Pizza
    {
        private string name;

        public Pizza(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }

        public Dough Dough { get; private set; }

        public void AddDough(Dough dough)
        {
            this.Dough = dough;
        }
    }
}