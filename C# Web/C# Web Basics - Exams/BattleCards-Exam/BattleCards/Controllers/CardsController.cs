using BattleCards.Services;
using BattleCards.ViewModels;
using SUS.HTTP;
using SUS.MvcFramework;

namespace BattleCards.Controllers
{
    public class CardsController : Controller
    {
        private readonly ICardsService cardsService;

        public CardsController(ICardsService cardsService)
        {
            this.cardsService = cardsService;
        }

        public HttpResponse All()
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            var cards = this.cardsService.All();
            return this.View(cards);
        }

        public HttpResponse Add()
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            return this.View();
        }

        [HttpPost("/Cards/Add")]
        public HttpResponse Add(AddCardInputModel inputModel)
        {
            if (inputModel.Name.Length < 5 || inputModel.Name.Length > 15)
            {
                return this.Error("Invalid card name.");
            }

            if (string.IsNullOrWhiteSpace(inputModel.Image))
            {
                return this.Error("Invalid Image.");
            }

            if (string.IsNullOrWhiteSpace(inputModel.Keyword))
            {
                return this.Error("Invalid Keyword.");
            }

            if (inputModel.Attack < 0)
            {
                return this.Error("Attack doesn't can be negative value.");
            }

            if (inputModel.Health < 0)
            {
                return this.Error("Health doesn't can be negative value.");
            }

            if (inputModel.Description.Length > 200)
            {
                return this.Error("Description cannot be very long length.");
            }

            var userId = this.GetUserId();
            this.cardsService.Add(inputModel, userId);
            return this.Redirect("/Cards/All");
        }

        public HttpResponse Collection()
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            var userId = this.GetUserId();
            var collection = this.cardsService.Collection(userId);
            return this.View(collection);
        }

        public HttpResponse AddToCollection(int cardId)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            var userId = this.GetUserId();
            this.cardsService.AddToCollection(cardId, userId);

            return this.Redirect("/Cards/All");
        }

        public HttpResponse RemoveFromCollection(int cardId)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            var userId = this.GetUserId();
            this.cardsService.RemoveFromCollection(cardId, userId);

            return this.Redirect("/Cards/Collection");
        }
    }
}
