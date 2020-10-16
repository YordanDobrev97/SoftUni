using BattleCards.ViewModels;
using System.Collections.Generic;

namespace BattleCards.Services
{
    public interface ICardsService
    {
        List<AllCardsViewModel> All();

        void Add(AddCardInputModel inputModel, string userId);

        List<AllCardsViewModel> Collection(string userId);

        void AddToCollection(int cardId, string userId);

        void RemoveFromCollection(int cardId, string userId);
    }
}
