namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;

    public class Tests
    {
        private Phone phone;

        [SetUp]
        public void SetUp()
        {
            this.phone = new Phone("Kiro", "Nokia");
        }

        [Test]
        public void Invalid_Make()
        {
            Assert.Throws<ArgumentException>(() => this.phone = new Phone(null, "Huawei"));
        }

        [Test]
        public void Valid_Make()
        {
            Assert.AreEqual(this.phone.Make, "Kiro");
        }

        [Test]
        public void Invalid_Model_With_Null()
        {
            Assert.Throws<ArgumentException>(() => this.phone = new Phone("Kiro", null));
        }

        [Test]
        public void Invalid_Model_With_Empty_String()
        {
            Assert.Throws<ArgumentException>(() => this.phone = new Phone("Kiro", string.Empty));
        }

        [Test]
        public void Add_Contact_Succesfuly()
        {
            this.phone.AddContact("Elena", "+3594342112");
            Assert.AreEqual(this.phone.Count, 1);
        }

        [Test]
        public void Add_Exist_Phonebook()
        {
            this.phone.AddContact("Elena", "+3594342112");
            Assert.Throws<InvalidOperationException>(() => this.phone.AddContact("Elena", "+3594342112"));
        }

        [Test]
        public void Call_Successfuly()
        {
            this.phone.AddContact("Elena", "+3594342112");
            string personCalling = this.phone.Call("Elena");
            Assert.AreEqual(personCalling, "Calling Elena - +3594342112...");
        }

        [Test]
        public void Call_Not_Exist_Person()
        {
            Assert.Throws<InvalidOperationException>(() => this.phone.Call("Jikvo"));
        }
    }
}