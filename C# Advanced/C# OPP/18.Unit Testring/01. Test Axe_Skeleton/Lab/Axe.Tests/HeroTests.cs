using NUnit.Framework;
using System;

public class HeroTests
{
    [Test]
    public void Weapon_With_10_Attack_And_Durability()
    {
        Hero hero = new Hero("Joni");
        int durabilityPoints = hero.Weapon.DurabilityPoints;

        Assert.AreEqual(10, durabilityPoints);
    }

    [Test]
    public void Is_Alive_After_Attack()
    {
        Hero hero = new Hero("Joni Test");
        Dummy dummy = new Dummy(3,3);

        hero.Attack(dummy);
        Assert.AreEqual(hero.Weapon.DurabilityPoints, 9);
    }

    [Test]
    public void Dead_After_Attacked()
    {
        Hero hero = new Hero("Joni Test");
        Dummy dummy = new Dummy(0, 0);

        Assert.Throws<InvalidOperationException>(() => hero.Attack(dummy));
    }
}
