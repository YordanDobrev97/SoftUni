using MXGP.Models.Motorcycles.Contracts;
using System;

namespace MXGP.Models.Motorcycles
{
    public abstract class Motorcycle : IMotorcycle
    {
        private string model;
        private int horsePower;

        private  Motorcycle(int horsePowerMinRange, int horsePowerMaxRange)
        {
            this.HorsePowerMinRange = horsePowerMinRange;
            this.HorsePowerMaxRange = horsePowerMaxRange;
        }

        protected Motorcycle(string model, int horsePower, double cubicCentimeters, int horsePowerMinRange, int horsePowerMaxRange)
            : this (horsePowerMinRange, horsePowerMaxRange)
        {
            this.Model = model;
            this.HorsePower = horsePower;
            this.CubicCentimeters = cubicCentimeters;
        }

        public string Model
        {
            get => this.model;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException($"Model {value} cannot be less than 4 symbols.");
                }

                this.model = value;
            }
        }

        public int HorsePower
        {
            get => this.horsePower;
            protected set
            {
                if (value < this.HorsePowerMinRange || value > this.HorsePowerMaxRange)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }
                this.horsePower = value;
            }
        }

        public double CubicCentimeters { get; private set; }

        public int HorsePowerMinRange { get; protected set; }

        public int HorsePowerMaxRange { get; protected set; }

        public double CalculateRacePoints(int laps)
        {
            return CubicCentimeters / HorsePower * laps;
        }
    }
}
