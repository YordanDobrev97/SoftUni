using NUnit.Framework;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        
        public void Success_Create_Car(string data)
        {
            CarManager.Car car = new CarManager.Car("Kiro", "BMW", 30, 40);
            
        }
    }
}