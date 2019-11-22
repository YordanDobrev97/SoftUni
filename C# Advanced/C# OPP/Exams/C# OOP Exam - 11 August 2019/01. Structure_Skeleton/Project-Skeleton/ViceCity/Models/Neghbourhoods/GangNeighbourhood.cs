using System.Collections.Generic;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;
using System.Linq;

namespace ViceCity.Models.Neghbourhoods
{
    public class GangNeighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            while (true)
            {
                var gun = mainPlayer.
                    GunRepository.
                    Models.
                    FirstOrDefault(x => x.CanFire);

                if (gun == null)
                {
                    break;
                }

                var enemy = civilPlayers.FirstOrDefault(x => x.IsAlive);

                if (enemy == null)
                {
                    break;
                }

                int fire = gun.Fire();

                enemy.TakeLifePoints(fire);
            }

            while (true)
            {
                var enemyShoot = civilPlayers.FirstOrDefault(x => x.IsAlive);

                if (enemyShoot == null)
                {

                }

                var enemyGun = enemyShoot.GunRepository.Models.FirstOrDefault(x => x.CanFire);

                int fire = enemyGun.Fire();

                mainPlayer.TakeLifePoints(fire);
            }
        }
    }
}
