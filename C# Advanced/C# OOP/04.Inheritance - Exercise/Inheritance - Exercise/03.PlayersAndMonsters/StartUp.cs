using System;
using System.Collections.Generic;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main()
        {
            Elf elf = new Elf("Pesho", 10);
            Wizard wizard = new Wizard("Petq", 10);
            Knight knight = new Knight("Gosho", 3);
            MuseElf museElf = new MuseElf("Pesho child", 2);
            DarkWizard darkWizard = new DarkWizard("Petq dark", 1);
            SoulMaster soulMaster = new SoulMaster("Ivan", 33);
            BladeKnight bladeKnight = new BladeKnight("Joro", 67);

            var heros = new List<Hero>();
            heros.Add(elf);
            heros.Add(wizard);
            heros.Add(knight);
            heros.Add(museElf);
            heros.Add(darkWizard);
            heros.Add(soulMaster);
            heros.Add(bladeKnight);

            foreach (var item in heros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
