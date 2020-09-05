using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Core
{
    public class Controller : IController
    {
        private List<IPlayer> players;
        private IPlayer mainPlayer;
        private IRepository<IGun> gunsCollection;
        private GangNeighbourhood neighbourhood;

        public Controller()
        {
            this.mainPlayer = new MainPlayer();
            this.gunsCollection = new GunRepository();
            this.players = new List<IPlayer>();
            this.players.Add(mainPlayer);
            this.neighbourhood = new GangNeighbourhood();
        }

        public string AddGun(string type, string name)
        {
            IGun gun = null;
            if (type == "Pistol")
            {
                gun = new Pistol(name);
            }
            else if (type == "Rifle")
            {
                gun = new Rifle(name);
            }
            else
            {
                return "Invalid gun type!";
            }

            this.gunsCollection.Add(gun);
            return $"Successfully added {name} of type: {type}";
        }

        public string AddGunToPlayer(string name)
        {
            if (this.gunsCollection.Models.Count == 0)
            {
                return "There are no guns in the queue!";
            }

            if (name == "Vercetti")
            {
                var mainPlayer = this.players.Where(x => x is MainPlayer).FirstOrDefault();
                var gun = this.gunsCollection.Models.FirstOrDefault();
                if (mainPlayer != null && gun != null)
                {
                    mainPlayer.GunRepository.Add(gun);
                    this.gunsCollection.Remove(gun);
                    return $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
                }
            }
            
            if (!this.players.Any(x => x.Name == name))
            {
                return "Civil player with that name doesn't exists!";
            }

            var player = this.players.FirstOrDefault(x => x.Name == name);
            var currentGun = this.gunsCollection.Models.FirstOrDefault(x => x.CanFire);
            player.GunRepository.Add(currentGun);

            return $"Successfully added {currentGun.Name} to the Civil Player: {player.Name}";
        }

        public string AddPlayer(string name)
        {
            IPlayer player = new CivilPlayer(name);
            this.players.Add(player);
            return $"Successfully added civil player: {name}!";
        }

        public string Fight()
        {
            var civilPlayers = this.players.Where(x => x is CivilPlayer).ToList();
            var pointsMainPlayer = mainPlayer.LifePoints;

            neighbourhood.Action(mainPlayer, civilPlayers);

            if (mainPlayer.LifePoints == pointsMainPlayer && civilPlayers.Any(x => x.IsAlive))
            {
                return "Everything is okay!";
            }

            StringBuilder sb = new StringBuilder();
            var deadCivilPlayersCount = civilPlayers.Count(x => !x.IsAlive);
            sb.AppendLine($"A fight happened:");
            sb.AppendLine($"Tommy live points: {mainPlayer.LifePoints}!");
            sb.AppendLine($"Tommy has killed: {deadCivilPlayersCount} players!");
            sb.AppendLine($"Left Civil Players: {civilPlayers.Count}!");

            return sb.ToString();
        }
    }
}
