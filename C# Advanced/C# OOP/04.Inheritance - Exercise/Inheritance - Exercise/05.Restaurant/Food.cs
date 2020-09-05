namespace Restaurant
{
    public abstract class Food
    {
        public Food(string name, decimal price, double grams)
        {
            this.Name = name;
            this.Price = price;
            this.Grams = grams;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public double Grams { get; set; }
    }
}
