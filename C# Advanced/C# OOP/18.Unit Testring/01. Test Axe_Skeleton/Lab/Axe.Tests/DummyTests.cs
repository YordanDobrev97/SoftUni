using NUnit.Framework;
using System;

public class DummyTests
{
    [Test]
    public void Dummy_Dead_Not_Attacked()
    {
        Dummy dummy = new Dummy(0, 0);

        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
    }

    [Test]
    public void Desceasing_Health_With_Attack_Points()
    {
        Dummy dummy = new Dummy(10, 10);

        dummy.TakeAttack(5);
        Assert.AreEqual(dummy.Health, 5);
    }

    [Test]
    public void Give_Experience_Correctly()
    {
        Dummy dummy = new Dummy(0, 10);

        int result = dummy.GiveExperience();
        Assert.AreEqual(10, result);
    }

    [Test]
    public void Target_Experience_Not_Dead()
    {
        Dummy dummy = new Dummy(10, 10);

        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }
}
