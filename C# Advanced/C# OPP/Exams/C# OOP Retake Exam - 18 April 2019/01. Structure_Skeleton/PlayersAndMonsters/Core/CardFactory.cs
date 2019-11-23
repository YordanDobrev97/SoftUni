using PlayersAndMonsters.Models.Cards.Contracts;
using System.Reflection;
using System.Linq;
using System;

namespace PlayersAndMonsters.Core
{
    public class CardFactory
    {
        public ICard CreateCard(string type, string name)
        {
            var typeCard = Assembly.GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == (type + "Card"));

            if (typeCard == null)
            {
                throw new ArgumentException(); 
            }

            var card = (ICard)Activator.CreateInstance(typeCard, name);
            return card;
        }
    }
}
