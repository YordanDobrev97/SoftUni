using System;
using System.Linq;
using System.Collections.Generic;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods
{
    public class GangNeighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            while (true)
            {
                var gunPlayer = mainPlayer.GunRepository.Models.FirstOrDefault();

                if (gunPlayer == null || !mainPlayer.IsAlive)
                {
                    break;
                }

                var enemyPlayer = civilPlayers.FirstOrDefault();
                while (true)
                {
                    if (gunPlayer.TotalBullets == 0 && gunPlayer.BulletsPerBarrel == 0)
                    {
                        mainPlayer.GunRepository.Remove(gunPlayer);
                        break;
                    }

                    int bullets = gunPlayer.Fire();
                    enemyPlayer.TakeLifePoints(bullets);

                    if (!enemyPlayer.IsAlive)
                    {
                        civilPlayers.Remove(enemyPlayer);
                        enemyPlayer = civilPlayers.FirstOrDefault();
                    }
                }
            }

            bool isDeadMainPlayer = false;
            var curentCivilPlayers = civilPlayers.FirstOrDefault();

            //TODO (Infinity Loop?)
            //if (curentCivilPlayers.GunRepository.Models.Count == 0)
            //{
            //    return;
            //}

            while (true)
            {
                var gunCivilPlayer = curentCivilPlayers.GunRepository.Models.FirstOrDefault();

                while (true)
                {
                    if (gunCivilPlayer == null || !gunCivilPlayer.CanFire)
                    {
                        break;
                    }

                    mainPlayer.TakeLifePoints(gunCivilPlayer.Fire());

                    if (!mainPlayer.IsAlive)
                    {
                        isDeadMainPlayer = true;
                        break;
                    }
                }

                if (isDeadMainPlayer)
                {
                    break;
                }
            }
        }
    }
}
