using NUnit.Framework;
using FightingArena;
using System;

namespace Tests
{
    public class WarriorTests
    {
        [TestCase("Pesho", 30, 40)]
        [TestCase("Gosho", 130, 140)]
        public void Create_Warrior_Success(string name, int damage, int hp)
        {
            Warrior warrior = new Warrior(name, damage, hp);
            Assert.AreEqual(warrior.Name, name);
            Assert.AreEqual(warrior.Damage, damage);
            Assert.AreEqual(warrior.HP, hp);
        }

        [TestCase(null, 30, 40)]
        [TestCase("", 30, 40)]
        [TestCase(" ", 30, 40)]
        [TestCase("Gosho", -20, 140)]
        [TestCase("Gosho", -20, -40)]
        public void Create_Warrior_Invalid_Data(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp));
        }

        [Test]
        public void Warrior_Attacked_Throw_Exception_Because_HP_Small_Min_HP()
        {
            Warrior warrior = new Warrior("Gosho", 50, 12);
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(new Warrior("Ivo", 40, 40)));
        }

        [Test]
        public void Warrior_Attacked_Throw_Exception_Because_Warror_HP_Small_Min_HP()
        {
            Warrior warrior = new Warrior("Gosho", 50, 52);
            Assert.Throws<InvalidOperationException>(() => 
            warrior.Attack(new Warrior("Ivo", 40, 2)));
        }

        [Test]
        public void Warrior_Attacked_Throw_Exception_Because_Negative_HP()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Gosho", 50, -52));
        }

        [Test]
        public void Warrior_Attacked_Throw_Exception_Because_HP_Smallest_Damage()
        {
            Warrior warrior = new Warrior("Gosho", 50, 52);
            Assert.Throws<InvalidOperationException>(() =>
            warrior.Attack(new Warrior("Ivo", 1340, 60)));
        }

        [Test]
        public void Warrior_Attacked_Decreas_HP()
        {
            Warrior warrior = new Warrior("Gosho", 50, 52);
            warrior.Attack(new Warrior("Pesho", 40, 40));

            int hp = warrior.HP;
            Assert.AreEqual(hp, 12);
        }
    }
}