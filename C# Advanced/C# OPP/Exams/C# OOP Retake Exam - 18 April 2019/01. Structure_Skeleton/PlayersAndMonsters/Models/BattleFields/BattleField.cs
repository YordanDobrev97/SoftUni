using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Linq;

namespace PlayersAndMonsters.Models.BattleFields
{
    class BattleField : IBattleField
    {
        private int begginerPlayerPoints = 50;

        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            IncreasingPlayer(attackPlayer);
            IncreasingPlayer(enemyPlayer);

            int attackedPlayerDamange = attackPlayer.CardRepository.Cards.Sum(x => x.DamagePoints);
            int enemyPlayerDamange = enemyPlayer.CardRepository.Cards.Sum(x => x.DamagePoints);

            while (true)
            {
                enemyPlayer.TakeDamage(attackedPlayerDamange);

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                attackPlayer.TakeDamage(enemyPlayerDamange);

                if (attackPlayer.IsDead)
                {
                    break;
                }
            }
        }

        private void IncreasingPlayer(IPlayer player)
        {
            if (player.Health == begginerPlayerPoints)
            {
                player.Health += 40;
                player.CardRepository.Cards.Select(x => x.DamagePoints += 30);
            }
        }
    }
}
