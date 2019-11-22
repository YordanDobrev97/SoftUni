namespace BlueOrigin.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    public class SpaceshipTests
    {
        private Spaceship spaceship;
        
        [SetUp]
        public void SetUp()
        {
            this.spaceship = new Spaceship("Ivo", 30);
        }

        [Test]
        public void Valid_Spaceship_Count()
        {
            Assert.AreEqual(this.spaceship.Count, 0);
        }

        [Test]
        public void Valid_Spaceship_Name()
        {
            Assert.AreEqual(this.spaceship.Name, "Ivo");
        }

        [Test]
        public void Invalid_Spaceship_Name()
        {
            this.spaceship = null;
            Assert.AreEqual(this.spaceship, null);
        }

        public void Valid_Spaceship_Capacity()
        {
            Assert.AreEqual(this.spaceship.Capacity, 30);
        }

        [Test]
        public void Is_Null_Name()
        {
            Assert.Throws<ArgumentNullException>(() => this.spaceship = new Spaceship(null, 200));
        }

        [Test]
        public void Is_Negative_Capacity()
        {
            Assert.Throws<ArgumentException>(() => this.spaceship = new Spaceship("Pesho", -200));
        }

        [Test]
        public void Correctly_Add_Astronaut()
        {
            Astronaut astronaut1 = new Astronaut("Pesho", 30);
            Astronaut astronaut2 = new Astronaut("Gosho", 50);

            this.spaceship.Add(astronaut1);
            this.spaceship.Add(astronaut2);

            Assert.AreEqual(astronaut1.Name, "Pesho");
            Assert.AreEqual(astronaut2.Name, "Gosho");
        }

        [Test]
        public void Exist_Add_Astronaut()
        {
            Astronaut astronaut1 = new Astronaut("Pesho", 30);
            Astronaut astronaut2 = new Astronaut("Pesho", 50);

            this.spaceship.Add(astronaut1);


            Assert.Throws<InvalidOperationException>(() => this.spaceship.Add(astronaut2));
        }

        [Test]
        public void Max_Capacity_Exception()
        {
            this.spaceship = new Spaceship("Free", 1);

            Astronaut astronaut = new Astronaut("Gosho", 300);
            Astronaut astronaut2 = new Astronaut("Iva", 20);

            this.spaceship.Add(astronaut);


            Assert.Throws<InvalidOperationException>(() => this.spaceship.Add(astronaut2));
        }

        [Test]
        public void Is_Remove_Correctly()
        {
            Astronaut astronaut = new Astronaut("Gosho", 12);
            this.spaceship.Add(astronaut);

            bool removeSuccess = this.spaceship.Remove(astronaut.Name);
            Assert.AreEqual(true, removeSuccess);
        }

        [Test]
        public void Is_Invalid_Remove()
        {
            Astronaut astronaut = new Astronaut("Gosho", 12);
            this.spaceship.Add(astronaut);

            bool removeSuccess = this.spaceship.Remove("Pesho");
            Assert.AreEqual(false, removeSuccess);
        }
    }
}