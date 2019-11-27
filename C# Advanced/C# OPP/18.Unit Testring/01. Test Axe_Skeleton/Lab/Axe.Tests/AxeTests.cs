using NUnit.Framework;
using System;

[TestFixture]
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
    public void Axe_Broken_Throw_Invalid_Operation_Exception()
    {
        Axe axe = new Axe(2, 0);
        Dummy dummy = new Dummy(10, 10);

        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy), "Axe is broken."); 
    }
}