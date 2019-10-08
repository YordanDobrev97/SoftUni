namespace CarManufacturer
{
    using System;
    using System.Text;

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
            Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public string Make { get => make; set => make = value; }

        public string Model { get => model; set => model = value; }

        public int Year { get => year; set => year = value; }

        public double FuelQuantity { get => fuelQuantity; set => fuelQuantity = value; }

        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }

        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            double consumedFuel = (distance / 100) * this.FuelConsumption;

            if (consumedFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= consumedFuel;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }

        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
            result.AppendLine($"FuelQuantity: {this.FuelQuantity}");

            return result.ToString();
        }
    }

}