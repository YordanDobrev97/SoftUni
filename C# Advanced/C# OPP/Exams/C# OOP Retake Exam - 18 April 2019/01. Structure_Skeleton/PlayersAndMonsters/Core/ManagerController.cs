namespace PlayersAndMonsters.Core
{
    using System;
    using System.Text;
    using Contracts;
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Models.BattleFields;
    using PlayersAndMonsters.Models.BattleFields.Contracts;
    using PlayersAndMonsters.Models.Cards.Contracts;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories;
    using PlayersAndMonsters.Repositories.Contracts;

    public class ManagerController : IManagerController
    {
        private IPlayerRepository playerRepository;
        private ICardRepository cardRepository;
        private IBattleField battleField; 

        public ManagerController(IPlayerRepository playerRepository, 
            ICardRepository cardRepository, IBattleField battleField)
        {
            this.playerRepository = playerRepository;
            this.cardRepository = cardRepository;
            this.battleField = battleField;
        }

        public string AddPlayer(string type, string username)
        {
            PlayerFactory factory = new PlayerFactory();
            IPlayer newPlayer = factory.CreatePlayer(type, username);

            this.playerRepository.Add(newPlayer);

            return string.
                Format(ConstantMessages.
                SuccessfullyAddedPlayer, 
                type, username);
        }

        public string AddCard(string type, string name)
        {
            CardFactory factory = new CardFactory();
            ICard card = factory.CreateCard(type, name);

            this.cardRepository.Add(card);

            return string.Format(ConstantMessages.SuccessfullyAddedCard, type, name);
        }

        public string AddPlayerCard(string username, string cardName)
        {
            var player = this.playerRepository.Find(username);
            var card = this.cardRepository.Find(cardName);

            player.CardRepository.Add(card);

            return string.Format(ConstantMessages.SuccessfullyAddedPlayerWithCards, username, cardName);
        }

        public string Fight(string attackUser, string enemyUser)
        {
            var user = this.playerRepository.Find(attackUser);
            var enemy = this.playerRepository.Find(enemyUser);



            this.battleField.Fight(user, enemy);
            return string.Format(ConstantMessages.FightInfo, user.Health, enemy.Health);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var player in this.playerRepository.Players)
            {
                var username = string.Format(ConstantMessages.PlayerReportInfo, 
                    player.Username, player.Health, player.CardRepository.Count);

                sb.AppendLine(username);

                foreach (var card in player.CardRepository.Cards)
                {
                    var currentCard = string.Format(ConstantMessages.CardReportInfo, card.Name, card.DamagePoints);
                    sb.AppendLine(currentCard);
                }
            }

            return sb.ToString();
        }
    }
}
