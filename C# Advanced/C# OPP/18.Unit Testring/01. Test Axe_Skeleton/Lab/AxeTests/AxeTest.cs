using NUnit.Framework;
using System;

namespace AxeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Axe_Loosees_Durability_After_Attack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            axe.Attack(dummy);

            Assert.AreEqual(axe.DurabilityPoints, 9);
        }

        [Test]
        public void Axe_Broken()
        {
            Axe axe = new Axe(1, 1);
            Dummy dummy = new Dummy(20, 10);
            //axe.Attack(dummy);

            Assert.That(() => axe.Attack(dummy), Throws.
                InvalidOperationException.
                With.Message.EqualTo("Axe is broken."));
        }
    }
}