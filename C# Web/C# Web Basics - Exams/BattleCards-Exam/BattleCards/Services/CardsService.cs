using BattleCards.Data;
using BattleCards.Models;
using BattleCards.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BattleCards.Services
{
    public class CardsService : ICardsService
    {
        private readonly ApplicationDbContext db;

        public CardsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Add(AddCardInputModel inputModel, string userId)
        {
            if (this.db.Cards.Any(c => c.Name == inputModel.Name))
            {
                return;
            }

            var newCard = new Card
            {
                Name = inputModel.Name,
                ImageUrl = inputModel.Image,
                Description = inputModel.Description,
                Keyword = inputModel.Keyword,
                Attack = inputModel.Attack,
                Health = inputModel.Health,
            };

            this.db.Cards.Add(newCard);
            this.db.UserCards.Add(new UserCard
            {
                Card = newCard,
                UserId = userId
            });

            this.db.SaveChanges();
        }

        public void AddToCollection(int cardId, string userId)
        {
            this.db.UserCards.Add(new UserCard
            {
                CardId = cardId,
                UserId = userId
            });

            this.db.SaveChanges();
        }

        public List<AllCardsViewModel> All()
        {
            return this.db.Cards.Select(c => new AllCardsViewModel
            {
                Id = c.Id,
                Name = c.Name,
                ImageUrl = c.ImageUrl,
                Description = c.Description,
                Attack = c.Attack,
                Health = c.Health,
                Keyword = c.Keyword
            }).ToList();
        }

        public List<AllCardsViewModel> Collection(string userId)
        {
            var userCards = this.db.UserCards
                .Where(u => u.UserId == userId)
                .Select(c => new AllCardsViewModel
            {
                Id = c.Card.Id,
                Name = c.Card.Name,
                ImageUrl = c.Card.ImageUrl,
                Keyword = c.Card.Keyword,
                Description = c.Card.Description,
                Attack = c.Card.Attack,
                Health = c.Card.Health,
            }).ToList();

            return userCards;
        }

        public void RemoveFromCollection(int cardId, string userId)
        {
            var card = this.db.UserCards.Where(x => x.CardId == cardId && x.UserId == userId).FirstOrDefault();

            if (card == null)
            {
                return;
            }

            this.db.UserCards.Remove(card);
            this.db.SaveChanges();
        }
    }
}
