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
                    if (!gunPlayer.CanFire)
                    {
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
            while (true)
            {
                var civilPlayer = civilPlayers.FirstOrDefault();

                var gunCivilPlayer = civilPlayer.GunRepository.Models.FirstOrDefault();

                while (true)
                {
                    if (!gunCivilPlayer.CanFire)
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
