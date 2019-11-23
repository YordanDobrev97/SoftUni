using PlayersAndMonsters.Models.Players;
using System.Linq;
using PlayersAndMonsters.Models.Players.Contracts;
using System.Reflection;
using System;
using PlayersAndMonsters.Repositories.Contracts;
using PlayersAndMonsters.Repositories;

namespace PlayersAndMonsters.Core
{
    public class PlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            var typePlayer = Assembly.GetCallingAssembly()
                 .GetTypes()
                 .FirstOrDefault(x => x.Name == type);

            if (typePlayer == null)
            {
                throw new ArgumentNullException();
            }

            ICardRepository repository = new CardRepository();
            var newPlayer = (IPlayer)Activator.CreateInstance(typePlayer, repository, username);

            return newPlayer;
        }
    }
}
