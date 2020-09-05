using System.Collections.Generic;
using System.Linq;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;

namespace ViceCity.Core
{
    public class Controller : IController
    {
        private List<IPlayer> players;
        private GunRepository gunRepository;

        public Controller()
        {
            this.players = new List<IPlayer>();
            this.gunRepository = new GunRepository();
        }

        public string AddGun(string type, string name)
        {
            bool addSuccess = true;
            IGun gun = null;
            switch (type)
            {
                case "Pistol":
                    gun = new Pistol(name);
                    break;
                case "Rifle ":
                    gun = new Rifle(name);
                    break;
                default:
                    addSuccess = false;
                    break;
            }

            if (!addSuccess)
            {
                return "Invalid gun type";
            }

            this.gunRepository.Add(gun);

            return $"Successfully added {name} of type: {type}.";
        }

        public string AddGunToPlayer(string name)
        {
            if (!this.gunRepository.Models.Any(x => x.Name == name))
            {
                return "Civil player with that name doesn't exists!";
            }

            if (this.gunRepository.Models.Count == 0)
            {
                return "There are no guns in the queue!";
            }

            var gun = this.gunRepository.Models.FirstOrDefault(x => x.CanFire);
            this.gunRepository.Remove(gun);
            var player = this.players.FirstOrDefault();
            this.players.Remove(player);

            if (name == "Vercetti")
            {
                var mainPlayer = this.players.FirstOrDefault(x => x is MainPlayer);
                if (gun != null)
                {
                    mainPlayer.GunRepository.Add(gun);
                        
                    return $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
                }
            }


            return $"Successfully added {gun.Name} to the Civil Player: {player.Name}";
        }

        public string AddPlayer(string name)
        {
            CivilPlayer civilPlayer = new CivilPlayer(name);
            this.players.Add(civilPlayer);

            return $"Successfully added civil player: {name}!";
        }

        public string Fight()
        {
            throw new System.NotImplementedException();
        }
    }
}
