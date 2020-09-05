using NUnit.Framework;
using FightingArena;
using System;

namespace Tests
{
    public class ArenaTests
    {
        [Test]
        public void Test_Add_Entroll_Warrior()
        {
            Arena arena = new Arena();
            arena.Enroll(new Warrior("Gosho", 40, 60));

            Assert.AreEqual(arena.Count, 1);
        }

        [Test]
        public void Not_Add_Entroll_Warrior()
        {
            Arena arena = new Arena();
            arena.Enroll(new Warrior("Gosho", 40, 60));

            Assert.Throws<InvalidOperationException>(() 
                => arena.Enroll(new Warrior("Gosho", 40, 60)));
        }

        [Test]
        public void Fight_Warrior()
        {
            Arena arena = new Arena();
            var gosho = new Warrior("Gosho", 40, 60);
            var pesho = new Warrior("Pesho", 50, 80);
            arena.Enroll(gosho);
            arena.Enroll(pesho);

            arena.Fight(gosho.Name, pesho.Name);
            Assert.AreEqual(gosho.HP, 10);
        }

        [Test]
        [TestCase(null, "Pesho")]
        [TestCase(null, null)]
        public void Fight_Warrior_With_Missing_Name(string attackerName, string defenderName)
        {
            Arena arena = new Arena();
            var gosho = new Warrior("Gosho", 40, 60);
            var pesho = new Warrior("Pesho", 50, 80);
            arena.Enroll(gosho);
            arena.Enroll(pesho);

            Assert.Throws<InvalidOperationException>(() => 
            arena.Fight(attackerName, defenderName));
        }
    }
}
