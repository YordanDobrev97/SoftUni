using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Linq;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (IsBeginnerPlayer(attackPlayer))
            {
                IncreasHealthAndDamangePointsPlayer(attackPlayer);
            }

            if (IsBeginnerPlayer(enemyPlayer))
            {
                IncreasHealthAndDamangePointsPlayer(enemyPlayer);
            }

            var bonusAttackedPlayer = attackPlayer.CardRepository.Cards.Sum(x => x.HealthPoints);
            attackPlayer.Health += bonusAttackedPlayer;

            var bonusEnemyPlayer = enemyPlayer.CardRepository.Cards.Sum(x => x.HealthPoints);
            enemyPlayer.Health += bonusEnemyPlayer;

            while (true)
            {
                if (enemyPlayer.IsDead || attackPlayer.IsDead)
                {
                    break;
                }

                var attackedPlayerDamange = attackPlayer.CardRepository.Cards.Sum(x => x.DamagePoints);
                enemyPlayer.TakeDamage(attackedPlayerDamange);
            }
        }

        private static void IncreasHealthAndDamangePointsPlayer(IPlayer attackPlayer)
        {
            attackPlayer.Health += 40;
            attackPlayer.CardRepository.Cards.Select(x => x.DamagePoints += 30);
        }

        private static bool IsBeginnerPlayer(IPlayer attackPlayer)
        {
            return attackPlayer is Beginner;
        }
    }
}
