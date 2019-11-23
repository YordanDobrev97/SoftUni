namespace ParkingSystem.Tests
{
    using NUnit.Framework;
    using System;

    public class SoftParkTest
    {
        private Car car;
        private SoftPark softPark;

        [SetUp]
        public void Setup()
        {
            this.car = new Car("Kiro", "3233123");
            this.softPark = new SoftPark();
        }

        [Test]
        public void Get_Correctly_Car_Make()
        {
            var make = car.Make;
            Assert.AreEqual(make, "Kiro");
        }

        [Test]
        public void Get_Correctly_Car_Registration_Number()
        {
            var registrationNumber = this.car.RegistrationNumber;
            Assert.AreEqual(registrationNumber, "3233123");
        }

        [Test]
        public void Park_Car()
        {
            string result = this.softPark.ParkCar("A1", car);
            Assert.AreEqual(result, $"Car:{car.RegistrationNumber} parked successfully!");
        }

        [Test]
        public void Try_Add_Not_Exist_Parking()
        {
            Assert.Throws<ArgumentException>(() => this.softPark.ParkCar("Gosho", car));
        }

        [Test]
        public void Try_Add_Already_Taken_Place()
        {
            this.softPark.ParkCar("A3", new Car("Ivo", "30931K"));
            Assert.Throws<ArgumentException>(() => this.softPark.ParkCar("A3", new Car("Ivo", "30931K")));
        }

        [Test]
        public void Car_Is_Already_Parked()
        {
            var car = new Car("Joro", "123456");
            this.softPark.ParkCar("C4", car);
            Assert.Throws<InvalidOperationException>(() => this.softPark.ParkCar("C3", 
                new Car("Ivo", "123456")));
        }

        [Test]
        public void Remove_Not_Exist_Park()
        {
            Assert.Throws<ArgumentException>(() => this.softPark.RemoveCar("FF",
                new Car("Mitko", "3523123")));
        }

        [Test]
        public void Remove_Car_Successfuly()
        {
            var car = new Car("Ani", "9999");
            this.softPark.ParkCar("B4", car);

            var removeCar = this.softPark.RemoveCar("B4", car);
            Assert.AreEqual(removeCar, $"Remove car:{car.RegistrationNumber} successfully!");
        }

        [Test]
        public void Remove_Doesnt_Exists()
        {
            var car = new Car("Mimi", "333111");
            this.softPark.ParkCar("C2", car);

            Assert.Throws<ArgumentException>(() => this.softPark.RemoveCar("C2", 
                new Car("Qvkata", "1001010")));
        }
    }
}