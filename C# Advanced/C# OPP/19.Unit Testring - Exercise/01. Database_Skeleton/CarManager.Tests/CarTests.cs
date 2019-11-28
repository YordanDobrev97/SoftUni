using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        [Test]
        public void Success_Create_Car()
        {
            string make = "Kiro";
            string model = "BWM";
            double fuelConsumption = 30;
            double fuelCapacity = 40;
            var car = 
                new CarManager.Car(make, model, fuelConsumption, fuelCapacity);

            Assert.AreEqual(car.Make, "Kiro");
            Assert.AreEqual(car.Model, "BWM");
            Assert.AreEqual(car.FuelConsumption, 30);
            Assert.AreEqual(car.FuelCapacity, 40);
        }

        [TestCase(null, "BMW", 30, 40)]
        [TestCase("Kiro", null, 30, 40)]
        [TestCase("Kiro", "BMW", -30, 40)]
        [TestCase("Kiro", "BMW", 0, -40)]
        [TestCase("Kiro", "BMW", 30, -40)]
        [TestCase("Kiro", "BMW", 30, 0)]
        public void Create_Car_Throw_Argument_Exception(string make, string model,
            double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
                new CarManager.Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void Success_Refuel_Car()
        {
            string make = "Kiro";
            string model = "BWM";
            double fuelConsumption = 30;
            double fuelCapacity = 40;
            var car =
                new CarManager.Car(make, model, fuelConsumption, fuelCapacity);

            car.Refuel(30);
            Assert.AreEqual(car.FuelAmount, 30);
        }

        [TestCase(-30)]
        [TestCase(0)]
        public void Try_Reful_Car_Invalid(double amount)
        {
            string make = "Kiro";
            string model = "BWM";
            double fuelConsumption = 30;
            double fuelCapacity = 40;
            var car =
                new CarManager.Car(make, model, fuelConsumption, fuelCapacity);

            Assert.Throws<ArgumentException>(() => car.Refuel(amount));
        }

        [Test]
        public void Drive_Car_Success()
        {
            string make = "Kiro";
            string model = "BWM";
            double fuelConsumption = 30;
            double fuelCapacity = 40;
            var car =
                new CarManager.Car(make, model, fuelConsumption, fuelCapacity);

            car.Refuel(20);
            car.Drive(20);

            Assert.AreEqual(car.FuelAmount, 14);
        }

        [Test]
        public void Drive_Car_Invalid()
        {
            string make = "Kiro";
            string model = "BWM";
            double fuelConsumption = 30;
            double fuelCapacity = 40;
            var car =
                new CarManager.Car(make, model, fuelConsumption, fuelCapacity);

            Assert.Throws<InvalidOperationException>(() => car.Drive(50));
        }
    }
}