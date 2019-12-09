using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Core
{
    public class Controller : IController
    {
        private List<IPlayer> players;
        private List<IGun> gunsCollection;
        private GangNeighbourhood neighbourhood;

        public Controller()
        {
            this.gunsCollection = new List<IGun>();
            this.players = new List<IPlayer>();
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
            if (this.gunsCollection.Count == 0)
            {
                return "There are no guns in the queue!";
            }
            if (name == "Vercetti")
            {
                var mainPlayer = this.players.Where(x => x.Name == name && x is MainPlayer).FirstOrDefault();
                var gun = this.gunsCollection.FirstOrDefault();
                if (mainPlayer != null && gun != null)
                {
                    mainPlayer.GunRepository.Add(gun);
                    return $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
                }
            }
            
            if (!this.players.Any(x => x.Name == name))
            {
                return "Civil player with that name doesn't exists!";
            }

            var player = this.players.FirstOrDefault(x => x.Name == name);
            var currentGun = this.gunsCollection.FirstOrDefault(x => x.CanFire);
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
            var mainPlayer = this.players.Where(x => x is MainPlayer).FirstOrDefault();
            var pointsMainPlayer = mainPlayer.LifePoints;

            var civilPlayers = this.players.Where(x => x is CivilPlayer).ToList();
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
