using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        public List<Hero> Heros { get; set; }

        public int Count => this.Heros.Count;

        public HeroRepository()
        {
            this.Heros = new List<Hero>();
        }

        public void Add(Hero hero)
        {
            this.Heros.Add(hero);
        }

        public void Remove(string name)
        {
            Hero heroRemove = null;

            foreach (var item in Heros)
            {
                if (item.Name == name)
                {
                    heroRemove = item;
                    break;
                }
            }

            this.Heros.Remove(heroRemove);
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero maxHeroStregth = null;

            int maxStregth = 0;

            foreach (var hero in this.Heros)
            {
                if (hero.Item.Strength > maxStregth)
                {
                    maxStregth = hero.Item.Strength;
                    maxHeroStregth = hero;
                }
            }

            return maxHeroStregth;
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero maxHeroAbility = null;

            int maxAbility = 0;

            foreach (var hero in this.Heros)
            {
                if (hero.Item.Ability > maxAbility)
                {
                    maxAbility = hero.Item.Ability;
                    maxHeroAbility = hero;
                }
            }

            return maxHeroAbility;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero maxHeroIntelligence = null;

            int maxIntelligence = 0;

            foreach (var hero in this.Heros)
            {
                if (hero.Item.Intelligence > maxIntelligence)
                {
                    maxIntelligence = hero.Item.Intelligence;
                    maxHeroIntelligence = hero;
                }
            }

            return maxHeroIntelligence;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in this.Heros)
            {
                sb.AppendLine(hero.ToString());
            }

            return sb.ToString();
        }
    }
}