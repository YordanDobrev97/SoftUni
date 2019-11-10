using System.Text;

namespace Cars
{
    public abstract class Car : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int battery;

        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }

        public Car(string model, string color, int battery)
            : this (model, color)
        {
            this.battery = battery;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public int Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
    }
}
