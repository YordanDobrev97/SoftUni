namespace PetStore.Services.Interfaces
{
    using PetStore.Models;
    using PetStore.ServiceModels.InputModels;

    public interface IOwnerService
    {
        void CreateOwner(OwnerInputViewModelService model);

        void BuyPet(PetInputViewModelService model);

        void FeedPet(Pet pet, Food food);

        void BuyProduct(ProductInputViewModelService model);

        void BuyToy(ToyInputViewModelService model);
    }
}
