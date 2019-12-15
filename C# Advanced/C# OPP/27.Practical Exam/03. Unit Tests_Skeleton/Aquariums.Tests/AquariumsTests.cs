namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    public class AquariumsTests
    {
        [Test]
        public void Set_Null_Value_Of_Name()
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium(null, 10));
        }

        [Test]
        public void Set_Invalid_Capacity()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("Something", -10));
        }

        [Test]
        public void Add_Fish_Success()
        {
            var fish = new Fish("Caca");
            var aquarium = new Aquarium("Something", 10);
            aquarium.Add(fish);

            Assert.AreEqual(1, aquarium.Count);
        }

        [Test]
        public void Try_Add_Full_Capacity_Aquarium()
        {
            var aquarium = new Aquarium("Something", 1);
            var fish = new Fish("Caca");
            aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(() => 
            aquarium.Add(fish));
        }

        [Test]
        public void Remove_Fish_Aquarium()
        {
            var aquarium = new Aquarium("Something", 1);
            var fish = new Fish("Caca");
            aquarium.Add(fish);
            aquarium.RemoveFish("Caca");

            Assert.AreEqual(0, aquarium.Count);
        }

        [Test]
        public void Try_Remove_Fish_Not_Found_Aquarium()
        {
            var aquarium = new Aquarium("Something", 1);
            var fish = new Fish("Caca");
            aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(() =>
            aquarium.RemoveFish("Scaridi"));
        }

        [Test]
        public void Sell_Fish_Not_Found_Aquarium()
        {
            var aquarium = new Aquarium("Something", 1);
            var fish = new Fish("Caca");
            aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(() =>
            aquarium.SellFish("Scaridi"));
        }

        [Test]
        public void Sell_Fish_Success_Aquarium()
        {
            var aquarium = new Aquarium("Something", 1);
            var fish = new Fish("Caca");
            aquarium.Add(fish);
            var sellFish = aquarium.SellFish("Caca");

            Assert.AreEqual("Caca", sellFish.Name);
        }

        [Test]
        public void Report_Success_Aquarium()
        {
            var aquarium = new Aquarium("Something", 1);
            var fish = new Fish("Caca");
            aquarium.Add(fish);
            
            Assert.AreEqual("Fish available at Something: Caca", 
                aquarium.Report());
        }
    }
}
