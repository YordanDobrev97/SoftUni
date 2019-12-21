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
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            IncreasingHealthAndDamangePoints(attackPlayer);
            IncreasingHealthAndDamangePoints(enemyPlayer);

            BonusHealth(attackPlayer);
            BonusHealth(enemyPlayer);

            while (true)
            {
                var damageAttackedPlayer = attackPlayer.CardRepository.Cards.Sum(x => x.DamagePoints);
                enemyPlayer.TakeDamage(damageAttackedPlayer);

                if (enemyPlayer.Health == 0)
                {
                    break;
                }

                var damangeEnemyPlayer = enemyPlayer.CardRepository.Cards.Sum(x => x.DamagePoints);
                attackPlayer.TakeDamage(damangeEnemyPlayer);

                if (attackPlayer.Health == 0)
                {
                    break;
                }
            }
        }

        private void BonusHealth(IPlayer attackPlayer)
        {
            attackPlayer.Health += attackPlayer.CardRepository.Cards.Sum(x => x.HealthPoints);
        }

        private static void IncreasingHealthAndDamangePoints(IPlayer attackPlayer)
        {
            if (attackPlayer is Beginner)
            {
                attackPlayer.Health += 40;
                attackPlayer.CardRepository.Cards.Select(x => x.DamagePoints += 30);
            }
        }
    }
}
