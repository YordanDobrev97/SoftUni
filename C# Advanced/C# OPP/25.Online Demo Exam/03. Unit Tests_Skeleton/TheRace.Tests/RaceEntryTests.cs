using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Try_Add_Rider_Null_Value()
        {
            RaceEntry raceEntry = new RaceEntry();
            Assert.Throws<InvalidOperationException>(() => raceEntry.AddRider(null));
        }

        [Test]
        public void Try_Add_Exist_Rider()
        {
            RaceEntry raceEntry = new RaceEntry();
            raceEntry.AddRider(new UnitRider("Pesho", 
                new UnitMotorcycle("SuperMotocycle", 30, 30)));

            Assert.Throws<InvalidOperationException>(() => raceEntry.AddRider(new UnitRider("Pesho",
                new UnitMotorcycle("SuperMotocycle", 30, 30))));
        }

        [Test]
        public void Add_Rider_Succesfully()
        {
            RaceEntry raceEntry = new RaceEntry();
            raceEntry.AddRider(new UnitRider("Pesho",
                new UnitMotorcycle("SuperMotocycle", 30, 30)));

            Assert.AreEqual(raceEntry.Counter, 1);
        }

        [Test]
        public void Invalid_Rider_Count_Calculate_AverageHorse_Power()
        {
            RaceEntry raceEntry = new RaceEntry();
            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
        }

        [Test]
        public void Calculate_Average_Horse_Power_Succesfully()
        {
            RaceEntry raceEntry = new RaceEntry();
            raceEntry.AddRider(new UnitRider("Pesho",
                new UnitMotorcycle("SuperMotocycle", 30, 30)));

            raceEntry.AddRider(new UnitRider("Gosho",
               new UnitMotorcycle("GoshoMotocycle", 30, 30)));

            raceEntry.AddRider(new UnitRider("Ivan",
             new UnitMotorcycle("Motocycle", 30, 30)));

            double average = raceEntry.CalculateAverageHorsePower();
            Assert.AreEqual(average, 30);
        }
    }
}