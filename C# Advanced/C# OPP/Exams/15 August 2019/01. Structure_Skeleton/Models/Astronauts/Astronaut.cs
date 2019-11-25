namespace SpaceStation.Models.Astronauts
{
    using SpaceStation.Models.Astronauts.Contracts;
    using SpaceStation.Models.Bags;
    using SpaceStation.Utilities.Messages;
    using System;

    public abstract class Astronaut : IAstronaut
    {
        private string name;
        private double oxygen;

        public Astronaut(string name, double oxygen)
        {
            this.Name = name;
            this.Oxygen = oxygen;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidAstronautName);
                }
                this.name = value;
            }
        }

        public double Oxygen
        {
            get => this.oxygen;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOxygen);
                }
            }
        }

        public bool CanBreath => this.Oxygen > 0;

        public IBag Bag => throw new System.NotImplementedException();

        public virtual void Breath()
        {
            if (CanBreath)
            {
                this.Oxygen -= 10;
            }
        }
    }
}
