using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        public Tire(double tire1Pressure, int tire1Age)
        {
            this.TirePressure = tire1Pressure;
            this.TireAge = tire1Age;
        }

        public double TirePressure { get; set; }

        public int TireAge { get; set; }

    }
}
